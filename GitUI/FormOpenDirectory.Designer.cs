namespace GitUI
{
    partial class Open
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.DirectoryComboBox = new System.Windows.Forms.ComboBox();
            this.Browse = new System.Windows.Forms.Button();
            this.Load = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Directory";
            // 
            // DirectoryComboBox
            // 
            this.DirectoryComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DirectoryComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.DirectoryComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories;
            this.SetDontTranslate(this.DirectoryComboBox, true);
            this.DirectoryComboBox.FormattingEnabled = true;
            this.DirectoryComboBox.Location = new System.Drawing.Point(85, 10);
            this.DirectoryComboBox.Name = "DirectoryComboBox";
            this.DirectoryComboBox.Size = new System.Drawing.Size(226, 23);
            this.DirectoryComboBox.TabIndex = 1;
            this.DirectoryComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DirectoryKeyPress);
            // 
            // Browse
            // 
            this.Browse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Browse.Location = new System.Drawing.Point(317, 8);
            this.Browse.Name = "Browse";
            this.Browse.Size = new System.Drawing.Size(102, 25);
            this.Browse.TabIndex = 2;
            this.Browse.Text = "Browse";
            this.Browse.UseVisualStyleBackColor = true;
            this.Browse.Click += new System.EventHandler(this.BrowseClick);
            // 
            // Load
            // 
            this.Load.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Load.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Load.Location = new System.Drawing.Point(317, 39);
            this.Load.Name = "Load";
            this.Load.Size = new System.Drawing.Size(102, 25);
            this.Load.TabIndex = 3;
            this.Load.Text = "Open";
            this.Load.UseVisualStyleBackColor = true;
            this.Load.Click += new System.EventHandler(this.LoadClick);
            // 
            // Open
            // 
            this.AcceptButton = this.Load;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 72);
            this.Controls.Add(this.Load);
            this.Controls.Add(this.Browse);
            this.Controls.Add(this.DirectoryComboBox);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1000, 110);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(335, 110);
            this.Name = "Open";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Open repository";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox DirectoryComboBox;
        private System.Windows.Forms.Button Browse;
        private new System.Windows.Forms.Button Load;
    }
}