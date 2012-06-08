using System;
using System.IO;
using System.Windows.Forms;
using GitCommands;
using GitCommands.Repository;
using ResourceManager.Translation;

namespace GitUI
{
    public partial class Open : GitExtensionsForm
    {
        private readonly TranslationString _warningOpenFailed =
            new TranslationString("Directory does not exist.");

        private readonly TranslationString _warningOpenFailedCaption =
            new TranslationString("Error");

        public Open()
        {
            InitializeComponent();
            Translate();

            DirectoryComboBox.DataSource = Repositories.RepositoryHistory.Repositories;
            DirectoryComboBox.DisplayMember = "Path";

            Load.Select();

            DirectoryComboBox.Focus();
            DirectoryComboBox.Select();
        }

        private void BrowseClick(object sender, EventArgs e)
        {
            var browseDialog = new FolderBrowserDialog {SelectedPath = DirectoryComboBox.Text};

            if (browseDialog.ShowDialog(this) == DialogResult.OK)
            {
                DirectoryComboBox.Text = browseDialog.SelectedPath;
            }
        }

        private void LoadClick(object sender, EventArgs e)
        {
            if (Directory.Exists(DirectoryComboBox.Text))
            {
                Settings.WorkingDir = DirectoryComboBox.Text;

                Repositories.AddMostRecentRepository(Settings.WorkingDir);

                Close();
            }
            else
            {
                MessageBox.Show(this, _warningOpenFailed.Text, _warningOpenFailedCaption.Text);
            }
        }

        private void DirectoryKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char) Keys.Enter)
            {
                LoadClick(null, null);
            }
        }
    }
}