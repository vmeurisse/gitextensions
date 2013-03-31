using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using LibGit2Sharp;

namespace GitCommands
{
    [Flags]
    public enum LogOptions
    {
        All = 1,            // --all
        Boundary = 2,       // --boundary
        ShowGitNotes = 4    // --not --glob=notes --not
    }

    public abstract class RevisionGraphInMemFilter
    {
        public abstract bool PassThru(GitRevision rev);
    }

    public sealed class RevisionGraph : IDisposable
    {
        public event EventHandler Exited;
        public event EventHandler<AsyncErrorEventArgs> Error 
        {
            add 
            {
                _backgroundLoader.LoadingError += value;
            }
            
            remove 
            {
                _backgroundLoader.LoadingError -= value;
            }
        }
        public event EventHandler Updated;
        public int RevisionCount { get; set; }

        public class RevisionGraphUpdatedEventArgs : EventArgs
        {
            public RevisionGraphUpdatedEventArgs(GitRevision revision)
            {
                Revision = revision;
            }

            public readonly GitRevision Revision;
        }

        public bool BackgroundThread { get; set; }
        public bool ShaOnly { get; set; }

        private Dictionary<string, List<GitHead>> _heads;

        private readonly AsyncLoader _backgroundLoader = new AsyncLoader();

        private readonly GitModule _module;

        public RevisionGraph(GitModule module)
        {
            BackgroundThread = true;
            _module = module;
        }

        ~RevisionGraph()
        {
            Dispose();
        }

        public void Dispose()
        {
            _backgroundLoader.Cancel();
        }

        public LogOptions LogParam = LogOptions.All;
        public string Filter = String.Empty;
        public string BranchFilter = String.Empty;
        public RevisionGraphInMemFilter InMemFilter;
        private string _selectedBranchName;

        public void Execute()
        {
            if (BackgroundThread)
            {
                _backgroundLoader.Load(ProccessGitLog, ProccessGitLogExecuted);
            }
            else
            {
                ProccessGitLog(new CancellationToken(false));
                ProccessGitLogExecuted();
            }
        }

        private void ProccessGitLog(CancellationToken taskState)
        {
            RevisionCount = 0;
            _heads = GetHeads().ToDictionaryOfList(head => head.Guid);

            Filter filter;
            if (Settings.OrderRevisionByDate)
            {
                filter = new Filter { SortBy = GitSortOptions.Time };
            }
            else
            {
                filter = new Filter { SortBy = GitSortOptions.Topological };
            }

            // TODO: Support BranchFilter
            // TODO: Support LogParam
            // TODO: Support Filter
            foreach (var commit in _module.Repository.Commits.QueryBy(filter))
            {
                GitRevision revision = new GitRevision(_module, null);
                revision.Author = commit.Author.Name;
                revision.AuthorEmail = commit.Author.Email;
                revision.AuthorDate = commit.Author.When.UtcDateTime;
                revision.Committer = commit.Committer.Name;
                revision.CommitterEmail = commit.Committer.Email;
                revision.CommitDate = commit.Committer.When.UtcDateTime;
                revision.Guid = commit.Id.Sha;

                List<GitHead> headList;
                if (_heads.TryGetValue(revision.Guid, out headList))
                    revision.Heads.AddRange(headList);
                revision.Message = commit.MessageShort;
                // TODO: Support notes
                //revision.MessageEncoding = ??
                revision.TreeGuid = commit.Tree.Sha;
                revision.ParentGuids = commit.Parents.Select(p => p.Sha).ToArray();

                RevisionCount++;

                if (Updated != null)
                    Updated(this, new RevisionGraphUpdatedEventArgs(revision));
                if (taskState.IsCancellationRequested)
                    return;
            }
        }

        private void ProccessGitLogExecuted()
        {
            if (Exited != null)
                Exited(this, EventArgs.Empty);            
        }

        private IList<GitHead> GetHeads()
        {
            var result = _module.GetHeads(true);
            bool validWorkingDir = _module.IsValidGitWorkingDir();
            _selectedBranchName = validWorkingDir ? _module.GetSelectedBranch() : string.Empty;
            GitHead selectedHead = result.FirstOrDefault(head => head.Name == _selectedBranchName);

            if (selectedHead != null)
            {
                selectedHead.Selected = true;

                var localConfigFile = _module.GetLocalConfig();

                var selectedHeadMergeSource =
                    result.FirstOrDefault(head => head.IsRemote
                                        && selectedHead.GetTrackingRemote(localConfigFile) == head.Remote
                                        && selectedHead.GetMergeWith(localConfigFile) == head.LocalName);

                if (selectedHeadMergeSource != null)
                    selectedHeadMergeSource.SelectedHeadMergeSource = true;
            }

            return result;
        }
    }
}
