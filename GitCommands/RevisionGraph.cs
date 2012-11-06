using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using GitCommands.Config;

namespace GitCommands
{
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
                backgroundLoader.LoadingError += value;
            }
            
            remove 
            {
                backgroundLoader.LoadingError -= value;
            }
        }
        public event EventHandler Updated;
        public event EventHandler BeginUpdate;
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

        private readonly char[] splitChars = " \t\n".ToCharArray();

        private readonly char[] hexChars = "0123456789ABCDEFabcdef".ToCharArray();

        private const string COMMIT_BEGIN = "<(__BEGIN_COMMIT__)>"; // Something unlikely to show up in a comment

        private Dictionary<string, List<GitHead>> heads;


        private enum ReadStep
        {
            Commit,
            Hash,
            Parents,
            Tree,
            AuthorName,
            AuthorEmail,
            AuthorDate,
            CommitterName,
            CommitterDate,
            CommitMessageEncoding,
            CommitMessage,
            FileName,
            Done,
        }

        private ReadStep nextStep = ReadStep.Commit;

        private GitRevision revision;

        private AsyncLoader backgroundLoader = new AsyncLoader();

        private GitModule Module;

        public RevisionGraph(GitModule module)
        {
            BackgroundThread = true;
            Module = module;
        }

        ~RevisionGraph()
        {
            Dispose();
        }

        public void Dispose()
        {
            backgroundLoader.Cancel();
        }

        public string LogParam = "HEAD --all";//--branches --remotes --tags";
        public string BranchFilter = String.Empty;
        public RevisionGraphInMemFilter InMemFilter;
        private string selectedBranchName;

        public void Execute()
        {
            if (BackgroundThread)
            {
                backgroundLoader.Load(execute, null);
            }
            else
            {
                execute(new FixedLoadingTaskState(false));                
            }
        }

        private void execute(ILoadingTaskState taskState)
        {
            RevisionCount = 0;
            heads = GetHeads().ToDictionaryOfList(head => head.Guid);

            // TODO: Support Settings.OrderRevisionByDate
            // TODO: Support BranchFilter
            foreach (var commit in Module.Repository.Commits.Where(p => true))
            {
                GitRevision revision = new GitRevision(Module, null);
                revision.Author = commit.Author.Name;
                revision.AuthorDate = commit.Author.When.UtcDateTime;
                revision.AuthorEmail = commit.Author.Email;
                revision.CommitDate = commit.Committer.When.UtcDateTime;
                revision.Committer = commit.Committer.Name;
                revision.Guid = commit.Id.Sha;

                List<GitHead> headList;
                if (heads.TryGetValue(revision.Guid, out headList))
                    revision.Heads.AddRange(headList);
                revision.Message = commit.MessageShort;
                // TODO: Support notes
                //revision.MessageEncoding = ??
                revision.TreeGuid = commit.Tree.Sha;
                revision.ParentGuids = commit.Parents.Select(p => p.Sha).ToArray();

                RevisionCount++;

                if (Updated != null)
                    Updated(this, new RevisionGraphUpdatedEventArgs(revision));
            }

            if (Exited != null)
                Exited(this, EventArgs.Empty);            
        }

        private List<GitHead> GetHeads()
        {
            var result = Module.GetHeads(true);
            bool validWorkingDir = Module.ValidWorkingDir();
            selectedBranchName = validWorkingDir ? Module.GetSelectedBranch() : string.Empty;
            GitHead selectedHead = result.Find(head => head.Name == selectedBranchName);

            if (selectedHead != null)
            {
                selectedHead.Selected = true;

                ConfigFile localConfigFile = Module.GetLocalConfig();

                GitHead selectedHeadMergeSource =
                    result.Find(head => head.IsRemote
                                        && selectedHead.GetTrackingRemote(localConfigFile) == head.Remote
                                        && selectedHead.GetMergeWith(localConfigFile) == head.LocalName);

                if (selectedHeadMergeSource != null)
                    selectedHeadMergeSource.SelectedHeadMergeSource = true;
            }

            return result;
        }
    }
}
