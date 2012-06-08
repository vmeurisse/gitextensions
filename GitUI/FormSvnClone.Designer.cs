namespace GitUI
{
    partial class FormSvnClone
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSvnClone));
            this.svnRepositoryComboBox = new System.Windows.Forms.ComboBox();
            this.destinationComboBox = new System.Windows.Forms.ComboBox();
            this.browseButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.subdirectoryTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.authorsFileTextBox = new System.Windows.Forms.TextBox();
            this.authorsFileBrowseButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // svnRepositoryComboBox
            // 
            this.svnRepositoryComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SetDontTranslate(this.svnRepositoryComboBox, true);
            this.svnRepositoryComboBox.FormattingEnabled = true;
            this.svnRepositoryComboBox.Location = new System.Drawing.Point(160, 13);
            this.svnRepositoryComboBox.Name = "svnRepositoryComboBox";
            this.svnRepositoryComboBox.Size = new System.Drawing.Size(320, 23);
            this.svnRepositoryComboBox.TabIndex = 1;
            // 
            // destinationComboBox
            // 
            this.destinationComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SetDontTranslate(this.destinationComboBox, true);
            this.destinationComboBox.FormattingEnabled = true;
            this.destinationComboBox.Location = new System.Drawing.Point(160, 41);
            this.destinationComboBox.Name = "destinationComboBox";
            this.destinationComboBox.Size = new System.Drawing.Size(217, 23);
            this.destinationComboBox.TabIndex = 2;
            this.destinationComboBox.DropDown += new System.EventHandler(this.destinationComboBox_DropDown);
            // 
            // browseButton
            // 
            this.browseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.browseButton.Location = new System.Drawing.Point(383, 40);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(97, 25);
            this.browseButton.TabIndex = 3;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Svn repository to clone";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Destination";
            // 
            // subdirectoryTextBox
            // 
            this.subdirectoryTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SetDontTranslate(this.subdirectoryTextBox, true);
            this.subdirectoryTextBox.Location = new System.Drawing.Point(160, 69);
            this.subdirectoryTextBox.Name = "subdirectoryTextBox";
            this.subdirectoryTextBox.Size = new System.Drawing.Size(217, 23);
            this.subdirectoryTextBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Subdirectory to create";
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.Location = new System.Drawing.Point(383, 137);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(97, 25);
            this.okButton.TabIndex = 5;
            this.okButton.Text = "Clone";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // authorsFileTextBox
            // 
            this.authorsFileTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SetDontTranslate(this.authorsFileTextBox, true);
            this.authorsFileTextBox.Location = new System.Drawing.Point(160, 97);
            this.authorsFileTextBox.Name = "authorsFileTextBox";
            this.authorsFileTextBox.Size = new System.Drawing.Size(217, 23);
            this.authorsFileTextBox.TabIndex = 8;
            // 
            // authorsFileBrowseButton
            // 
            this.authorsFileBrowseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.authorsFileBrowseButton.Location = new System.Drawing.Point(383, 95);
            this.authorsFileBrowseButton.Name = "authorsFileBrowseButton";
            this.authorsFileBrowseButton.Size = new System.Drawing.Size(97, 25);
            this.authorsFileBrowseButton.TabIndex = 9;
            this.authorsFileBrowseButton.Text = "Browse";
            this.authorsFileBrowseButton.UseVisualStyleBackColor = true;
            this.authorsFileBrowseButton.Click += new System.EventHandler(this.authorsFileBrowseButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Authors file";
            // 
            // FormSvnClone
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 170);
            this.Controls.Add(this.authorsFileTextBox);
            this.Controls.Add(this.subdirectoryTextBox);
            this.Controls.Add(this.destinationComboBox);
            this.Controls.Add(this.svnRepositoryComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.authorsFileBrowseButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.browseButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(700, 208);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 208);
            this.Name = "FormSvnClone";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Svn Clone";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox svnRepositoryComboBox;
        private System.Windows.Forms.ComboBox destinationComboBox;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox subdirectoryTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.TextBox authorsFileTextBox;
        private System.Windows.Forms.Button authorsFileBrowseButton;
        private System.Windows.Forms.Label label4;
    }
}