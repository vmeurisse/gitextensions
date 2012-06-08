using System;
using System.Drawing;
using System.Windows.Forms;
using GitCommands.Repository;
using GitUI.Properties;

namespace GitUI
{
    public sealed partial class DashboardItem : GitExtensionsControl
    {
        private ToolTip toolTip;

        private DashboardItem()
        {
            InitializeComponent();
            Translate();
        }

        public DashboardItem(Repository repository)
            : this()
        {
            if (repository == null)
                return;

            Bitmap icon = GetRepositoryIcon(repository);


            string branchName = string.Empty;

            if (GitCommands.Settings.DashboardShowCurrentBranch)
            {
                if (!GitCommands.GitModule.IsBareRepository(repository.Path))
                    branchName = GitCommands.GitModule.GetSelectedBranchFast(repository.Path);
            }

            Initialize(icon, repository.Path, repository.Title, repository.Description, branchName);
        }

        public DashboardItem(Bitmap icon, string title)
            : this()
        {
            Initialize(icon, title, title, null, null);
        }

        public void Close()
        {
            if (toolTip != null)
                toolTip.RemoveAll();
        }

        private void Initialize(Bitmap icon, string path, string title, string text, string branchName)
        {
            Title.Text = title;
            Title.AutoEllipsis = true;

            Path = path;

            if (string.IsNullOrEmpty(Title.Text))
                Title.Text = Path;

            Description.Visible = !string.IsNullOrEmpty(text);
            Description.Text = text;

            //if (Description.Visible)
            //{
            //    SizeF size = Description.CreateGraphics().MeasureString(Description.Text, Description.Font);
            //    int lines = ((int)size.Width / (int)Description.Width) + 1;
            //    Description.Height = ((int)size.Height) * lines;
            //}

            BranchName.Visible = !string.IsNullOrEmpty(branchName);
            BranchName.Text = branchName;

            Height = Title.Height + 6;
            if (Description.Visible)
            {
                Description.Top = Title.Height + 4;
                Height += Description.Height + 2;
            }


            if (icon != null)
                Icon.Image = icon;


            toolTip = new ToolTip
                              {
                                  InitialDelay = 1,
                                  AutomaticDelay = 1,
                                  AutoPopDelay = 5000,
                                  UseFading = false,
                                  UseAnimation = false,
                                  ReshowDelay = 1
                              };
            toolTip.SetToolTip(Title, Path);

            Title.MouseDown += Title_MouseDown;
            Title.Click += Title_Click;
            Description.Click += Title_Click;
            Icon.Click += Title_Click;
        }

        void Title_Click(object sender, EventArgs e)
        {
            OnClick(e);
        }

        void Title_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (ContextMenuStrip != null)
                    ContextMenuStrip.Show((Control)sender, e.Location);
            }
        }

        public string Path { get; private set; }

        private void DashboardItem_SizeChanged(object sender, EventArgs e)
        {
            Title.Width = Width - Title.Location.X;
            Description.Width = Width - Title.Location.X;
        }

        private void DashboardItem_MouseEnter(object sender, EventArgs e)
        {
            BackColor = SystemColors.ControlLight;
        }

        private void DashboardItem_MouseLeave(object sender, EventArgs e)
        {
            BackColor = SystemColors.Control;
        }

        private static Bitmap GetRepositoryIcon(Repository repository)
        {
            switch (repository.RepositoryType)
            {
                case RepositoryType.Repository:
                    return Resources.Star;
                case RepositoryType.RssFeed:
                    return Resources.rss;
                case RepositoryType.History:
                    return Resources.history;
                default:
                    throw new ArgumentException("Repository type is not supported.", "repository");
            }
        }
    }
}
