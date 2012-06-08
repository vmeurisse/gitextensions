using System;
using System.ComponentModel;
using System.Windows.Forms;
using GitCommands.Repository;
using System.Drawing;

namespace GitUI
{
    public partial class DashboardEditor : GitExtensionsControl
    {
        public DashboardEditor()
        {
            InitializeComponent();
            Translate();
            Initialize();
        }

        protected override void OnHandleDestroyed(EventArgs e)
        {
            if (Categories.SelectedItem == null)
                return;

            var repositoryCategory = (RepositoryCategory) Categories.SelectedItem;
            repositoryCategory.SetIcon();
        }

        private bool bChangingDataSource;

        public void Initialize()
        {
            bChangingDataSource = true;
            Categories.DataSource = null;
            Categories.DataSource = Repositories.RepositoryCategories;
            bChangingDataSource = false;
            Categories.DisplayMember = "Description";
        }

        private void Categories_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Categories.SelectedItem == null)
            {
                if (!bChangingDataSource)
                    splitContainer2.Panel2.Enabled = false;
                return;
            }

            if (!bChangingDataSource)
                splitContainer2.Panel2.Enabled = true;
            var repositoryCategory = (RepositoryCategory)Categories.SelectedItem;
            RepositoriesGrid.DataSource = repositoryCategory.Repositories;

            Caption.Text = repositoryCategory.Description;
            RssFeedType.Checked = repositoryCategory.CategoryType == RepositoryCategoryType.RssFeed;
            RepositoriesType.Checked = !RssFeedType.Checked;
            RssFeed.Text = repositoryCategory.RssFeedUrl;

            RssFeedType_CheckedChanged(this, null);
        }

        private void Add_Click(object sender, EventArgs e)
        {
            var category = new RepositoryCategory("new");
            Repositories.RepositoryCategories.Add(category);
            Categories_SelectedIndexChanged(null, null);
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            if (Categories.SelectedItem == null)
                return;

            Repositories.RepositoryCategories.Remove((RepositoryCategory) Categories.SelectedItem);
            Categories_SelectedIndexChanged(null, null);
        }

        private void Caption_TextChanged(object sender, EventArgs e)
        {
            if (Categories.SelectedItem == null)
                return;

            var repositoryCategory = (RepositoryCategory) Categories.SelectedItem;
            repositoryCategory.Description = Caption.Text;
            Initialize();
        }

        private void RssFeedType_CheckedChanged(object sender, EventArgs e)
        {
            if (Categories.SelectedItem == null)
                return;

            var repositoryCategory = (RepositoryCategory) Categories.SelectedItem;


            if (RssFeedType.Checked)
            {
                RepositoriesGrid.ReadOnly = true;
                RepositoriesGrid.Enabled = false;
                RepositoriesGrid.BackgroundColor = Color.Gray;
                RssFeed.Enabled = true;
                repositoryCategory.CategoryType = RepositoryCategoryType.RssFeed;
            }

            if (RepositoriesType.Checked)
            {
                RepositoriesGrid.ReadOnly = false;
                RepositoriesGrid.Enabled = true;
                RepositoriesGrid.BackgroundColor = Color.White;
                RssFeed.Enabled = false;
                repositoryCategory.CategoryType = RepositoryCategoryType.Repositories;
            }

            repositoryCategory.SetIcon();
        }

        private void RssFeed_TextChanged(object sender, EventArgs e)
        {
            if (Categories.SelectedItem == null)
                return;

            var repositoryCategory = (RepositoryCategory) Categories.SelectedItem;
            repositoryCategory.RssFeedUrl = RssFeed.Text;
        }

        private void RssFeed_Validating(object sender, CancelEventArgs e)
        {
            if (Categories.SelectedItem == null)
                return;

            var repositoryCategory = (RepositoryCategory) Categories.SelectedItem;
            if (repositoryCategory.CategoryType == RepositoryCategoryType.RssFeed)
                repositoryCategory.DownloadRssFeed();
        }

        private void Caption_Validating(object sender, CancelEventArgs e)
        {
            if (Categories.SelectedItem == null)
                return;

            var repositoryCategory = (RepositoryCategory) Categories.SelectedItem;
            repositoryCategory.SetIcon();
        }

        private void RssFeedType_Validating(object sender, CancelEventArgs e)
        {
            if (Categories.SelectedItem == null)
                return;

            var repositoryCategory = (RepositoryCategory) Categories.SelectedItem;
            repositoryCategory.SetIcon();
        }

        private void RepositoriesType_Validating(object sender, CancelEventArgs e)
        {
            if (Categories.SelectedItem == null)
                return;

            var repositoryCategory = (RepositoryCategory) Categories.SelectedItem;
            repositoryCategory.SetIcon();
        }

        private void RepositoriesGrid_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (Categories.SelectedItem == null)
                return;

            var repositoryCategory = (RepositoryCategory) Categories.SelectedItem;
            repositoryCategory.SetIcon();
        }

        private void RepositoriesGrid_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            //We handle this ourself, let .net think the action is cancelled.
            e.Cancel = true;
            if (e.Row.DataBoundItem == null)
                return;

            var datasource = ((BindingList<Repository>) ((DataGridView) sender).DataSource);
            var repositoryToRemove = (Repository) e.Row.DataBoundItem;

            RepositoriesGrid.DataSource = null;
            datasource.Remove(repositoryToRemove);
            RepositoriesGrid.DataSource = datasource;
        }
    }
}