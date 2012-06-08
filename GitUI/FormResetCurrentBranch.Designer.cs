namespace GitUI
{
    partial class FormResetCurrentBranch
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
            this.BranchInfoLbl = new System.Windows.Forms.Label();
            this.Commit = new System.Windows.Forms.Label();
            this.Author = new System.Windows.Forms.Label();
            this.Message = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Hard = new System.Windows.Forms.RadioButton();
            this.Mixed = new System.Windows.Forms.RadioButton();
            this.Soft = new System.Windows.Forms.RadioButton();
            this.Ok = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BranchInfoLbl
            // 
            this.BranchInfoLbl.AutoSize = true;
            this.SetDontTranslate(this.BranchInfoLbl, true);
            this.BranchInfoLbl.Location = new System.Drawing.Point(13, 13);
            this.BranchInfoLbl.Name = "BranchInfoLbl";
            this.BranchInfoLbl.Size = new System.Drawing.Size(83, 15);
            this.BranchInfoLbl.TabIndex = 0;
            this.BranchInfoLbl.Text = "##Reset {0} to:";
            // 
            // Commit
            // 
            this.Commit.AutoSize = true;
            this.SetDontTranslate(this.Commit, true);
            this.Commit.Location = new System.Drawing.Point(31, 34);
            this.Commit.Name = "Commit";
            this.Commit.Size = new System.Drawing.Size(85, 15);
            this.Commit.TabIndex = 1;
            this.Commit.Text = "##Commit: {0}";
            // 
            // Author
            // 
            this.Author.AutoSize = true;
            this.SetDontTranslate(this.Author, true);
            this.Author.Location = new System.Drawing.Point(31, 57);
            this.Author.Name = "Author";
            this.Author.Size = new System.Drawing.Size(78, 15);
            this.Author.TabIndex = 2;
            this.Author.Text = "##Author: {0}";
            // 
            // Message
            // 
            this.Message.AutoSize = true;
            this.SetDontTranslate(this.Message, true);
            this.Message.Location = new System.Drawing.Point(31, 106);
            this.Message.Name = "Message";
            this.Message.Size = new System.Drawing.Size(87, 15);
            this.Message.TabIndex = 3;
            this.Message.Text = "##Message: {0}";
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.SetDontTranslate(this.Date, true);
            this.Date.Location = new System.Drawing.Point(31, 82);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(111, 15);
            this.Date.TabIndex = 4;
            this.Date.Text = "##Commit date: {0}";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Hard);
            this.groupBox1.Controls.Add(this.Mixed);
            this.groupBox1.Controls.Add(this.Soft);
            this.groupBox1.Location = new System.Drawing.Point(16, 133);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(510, 100);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reset type";
            // 
            // Hard
            // 
            this.Hard.AutoSize = true;
            this.Hard.Location = new System.Drawing.Point(7, 68);
            this.Hard.Name = "Hard";
            this.Hard.Size = new System.Drawing.Size(500, 19);
            this.Hard.TabIndex = 2;
            this.Hard.Text = "Hard: reset working dir and index (discard ALL local changes, even uncommitted ch" +
    "anges)";
            this.Hard.UseVisualStyleBackColor = true;
            // 
            // Mixed
            // 
            this.Mixed.AutoSize = true;
            this.Mixed.Checked = true;
            this.Mixed.Location = new System.Drawing.Point(7, 44);
            this.Mixed.Name = "Mixed";
            this.Mixed.Size = new System.Drawing.Size(276, 19);
            this.Mixed.TabIndex = 1;
            this.Mixed.TabStop = true;
            this.Mixed.Text = "Mixed: leave working dir untouched, reset index";
            this.Mixed.UseVisualStyleBackColor = true;
            // 
            // Soft
            // 
            this.Soft.AutoSize = true;
            this.Soft.Location = new System.Drawing.Point(7, 20);
            this.Soft.Name = "Soft";
            this.Soft.Size = new System.Drawing.Size(257, 19);
            this.Soft.TabIndex = 0;
            this.Soft.Text = "Soft: leave working dir and index untouched";
            this.Soft.UseVisualStyleBackColor = true;
            // 
            // Ok
            // 
            this.Ok.Location = new System.Drawing.Point(335, 239);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(91, 25);
            this.Ok.TabIndex = 6;
            this.Ok.Text = "OK";
            this.Ok.UseVisualStyleBackColor = true;
            this.Ok.Click += new System.EventHandler(this.Ok_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(432, 239);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(91, 25);
            this.Cancel.TabIndex = 7;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // FormResetCurrentBranch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 269);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Ok);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.Message);
            this.Controls.Add(this.Author);
            this.Controls.Add(this.Commit);
            this.Controls.Add(this.BranchInfoLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormResetCurrentBranch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Reset current branch";
            this.Load += new System.EventHandler(this.FormResetCurrentBranch_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BranchInfoLbl;
        private System.Windows.Forms.Label Commit;
        private System.Windows.Forms.Label Author;
        private System.Windows.Forms.Label Message;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Hard;
        private System.Windows.Forms.RadioButton Mixed;
        private System.Windows.Forms.RadioButton Soft;
        private System.Windows.Forms.Button Ok;
        private System.Windows.Forms.Button Cancel;
    }
}