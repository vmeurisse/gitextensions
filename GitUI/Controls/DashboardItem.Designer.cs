namespace GitUI
{
    partial class DashboardItem
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Panel panel1;
            this.BranchName = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.LinkLabel();
            this.Icon = new System.Windows.Forms.PictureBox();
            this.Description = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Icon)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            panel1.Controls.Add(this.BranchName);
            panel1.Controls.Add(this.Title);
            panel1.Location = new System.Drawing.Point(28, 2);
            panel1.MinimumSize = new System.Drawing.Size(250, 15);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(250, 15);
            panel1.TabIndex = 5;
            panel1.MouseEnter += new System.EventHandler(this.DashboardItem_MouseEnter);
            panel1.MouseLeave += new System.EventHandler(this.DashboardItem_MouseLeave);
            // 
            // BranchName
            // 
            this.BranchName.AutoSize = true;
            this.BranchName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BranchName.Dock = System.Windows.Forms.DockStyle.Left;
            this.SetDontTranslate(this.BranchName, true);
            this.BranchName.Location = new System.Drawing.Point(52, 0);
            this.BranchName.Name = "BranchName";
            this.BranchName.Size = new System.Drawing.Size(58, 15);
            this.BranchName.TabIndex = 4;
            this.BranchName.Text = "##branch";
            this.BranchName.Click += new System.EventHandler(this.Title_Click);
            this.BranchName.MouseEnter += new System.EventHandler(this.DashboardItem_MouseEnter);
            this.BranchName.MouseLeave += new System.EventHandler(this.DashboardItem_MouseLeave);
            // 
            // Title
            // 
            this.Title.AutoEllipsis = true;
            this.Title.AutoSize = true;
            this.Title.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Title.Dock = System.Windows.Forms.DockStyle.Left;
            this.SetDontTranslate(this.Title, true);
            this.Title.Location = new System.Drawing.Point(0, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(52, 15);
            this.Title.TabIndex = 1;
            this.Title.TabStop = true;
            this.Title.Text = "##label1";
            this.Title.MouseEnter += new System.EventHandler(this.DashboardItem_MouseEnter);
            this.Title.MouseLeave += new System.EventHandler(this.DashboardItem_MouseLeave);
            // 
            // Icon
            // 
            this.Icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Icon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Icon.Location = new System.Drawing.Point(0, 2);
            this.Icon.Name = "Icon";
            this.Icon.Size = new System.Drawing.Size(19, 18);
            this.Icon.TabIndex = 0;
            this.Icon.TabStop = false;
            this.Icon.MouseEnter += new System.EventHandler(this.DashboardItem_MouseEnter);
            this.Icon.MouseLeave += new System.EventHandler(this.DashboardItem_MouseLeave);
            // 
            // Description
            // 
            this.Description.AutoSize = true;
            this.Description.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SetDontTranslate(this.Description, true);
            this.Description.Location = new System.Drawing.Point(29, 25);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(40, 15);
            this.Description.TabIndex = 3;
            this.Description.Text = "##text";
            this.Description.MouseEnter += new System.EventHandler(this.DashboardItem_MouseEnter);
            this.Description.MouseLeave += new System.EventHandler(this.DashboardItem_MouseLeave);
            // 
            // DashboardItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(panel1);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.Icon);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "DashboardItem";
            this.Size = new System.Drawing.Size(281, 40);
            this.SizeChanged += new System.EventHandler(this.DashboardItem_SizeChanged);
            this.MouseEnter += new System.EventHandler(this.DashboardItem_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.DashboardItem_MouseLeave);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Icon;
        private System.Windows.Forms.LinkLabel Title;
        private System.Windows.Forms.Label Description;
        private System.Windows.Forms.Label BranchName;
    }
}
