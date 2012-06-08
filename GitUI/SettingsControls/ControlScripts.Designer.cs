namespace GitUI.SettingsControls
{
    partial class ControlScripts
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlScripts));
            this.lbl_icon = new System.Windows.Forms.Label();
            this.sbtn_icon = new GitUI.Script.SplitButton();
            this.scriptNeedsConfirmation = new System.Windows.Forms.CheckBox();
            this.labelOnEvent = new System.Windows.Forms.Label();
            this.scriptEvent = new System.Windows.Forms.ComboBox();
            this.scriptEnabled = new System.Windows.Forms.CheckBox();
            this.ScriptList = new System.Windows.Forms.DataGridView();
            this.scriptInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.helpLabel = new System.Windows.Forms.Label();
            this.inMenuCheckBox = new System.Windows.Forms.CheckBox();
            this.argumentsLabel = new System.Windows.Forms.Label();
            this.commandLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.browseScriptButton = new System.Windows.Forms.Button();
            this.argumentsTextBox = new System.Windows.Forms.RichTextBox();
            this.commandTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.moveDownButton = new System.Windows.Forms.Button();
            this.removeScriptButton = new System.Windows.Forms.Button();
            this.addScriptButton = new System.Windows.Forms.Button();
            this.moveUpButton = new System.Windows.Forms.Button();
            this.contextMenuStrip_SplitButton = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.hotkeyCommandIdentifierDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enabledDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.onEventDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.askConfirmationDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.addToRevisionGridContextMenuDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ScriptList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scriptInfoBindingSource)).BeginInit();
            this.contextMenuStrip_SplitButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_icon
            // 
            this.lbl_icon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_icon.AutoSize = true;
            this.lbl_icon.Location = new System.Drawing.Point(326, 439);
            this.lbl_icon.Name = "lbl_icon";
            this.lbl_icon.Size = new System.Drawing.Size(33, 15);
            this.lbl_icon.TabIndex = 43;
            this.lbl_icon.Text = "Icon:";
            this.lbl_icon.Visible = false;
            // 
            // sbtn_icon
            // 
            this.sbtn_icon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.sbtn_icon.AutoSize = true;
            this.sbtn_icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.sbtn_icon.Location = new System.Drawing.Point(372, 434);
            this.sbtn_icon.Name = "sbtn_icon";
            this.sbtn_icon.Size = new System.Drawing.Size(109, 30);
            this.sbtn_icon.TabIndex = 42;
            this.sbtn_icon.Text = "Select icon";
            this.sbtn_icon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.sbtn_icon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.sbtn_icon.UseVisualStyleBackColor = true;
            this.sbtn_icon.Visible = false;
            this.sbtn_icon.WholeButtonDropdown = true;
            // 
            // scriptNeedsConfirmation
            // 
            this.scriptNeedsConfirmation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.scriptNeedsConfirmation.AutoSize = true;
            this.scriptNeedsConfirmation.Location = new System.Drawing.Point(109, 467);
            this.scriptNeedsConfirmation.Name = "scriptNeedsConfirmation";
            this.scriptNeedsConfirmation.Size = new System.Drawing.Size(135, 19);
            this.scriptNeedsConfirmation.TabIndex = 41;
            this.scriptNeedsConfirmation.Text = "Ask for confirmation";
            this.scriptNeedsConfirmation.UseVisualStyleBackColor = true;
            this.scriptNeedsConfirmation.Validating += new System.ComponentModel.CancelEventHandler(this.ScriptInfoEdit_Validating);
            // 
            // labelOnEvent
            // 
            this.labelOnEvent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelOnEvent.AutoSize = true;
            this.labelOnEvent.Location = new System.Drawing.Point(10, 441);
            this.labelOnEvent.Name = "labelOnEvent";
            this.labelOnEvent.Size = new System.Drawing.Size(58, 15);
            this.labelOnEvent.TabIndex = 40;
            this.labelOnEvent.Text = "On event:";
            // 
            // scriptEvent
            // 
            this.scriptEvent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.scriptEvent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.scriptEvent.FormattingEnabled = true;
            this.scriptEvent.Location = new System.Drawing.Point(109, 435);
            this.scriptEvent.Name = "scriptEvent";
            this.scriptEvent.Size = new System.Drawing.Size(188, 23);
            this.scriptEvent.TabIndex = 39;
            this.scriptEvent.SelectedIndexChanged += new System.EventHandler(this.scriptEvent_SelectedIndexChanged);
            this.scriptEvent.Validating += new System.ComponentModel.CancelEventHandler(this.ScriptInfoEdit_Validating);
            // 
            // scriptEnabled
            // 
            this.scriptEnabled.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.scriptEnabled.AutoSize = true;
            this.scriptEnabled.Location = new System.Drawing.Point(425, 255);
            this.scriptEnabled.Name = "scriptEnabled";
            this.scriptEnabled.Size = new System.Drawing.Size(68, 19);
            this.scriptEnabled.TabIndex = 38;
            this.scriptEnabled.Text = "Enabled";
            this.scriptEnabled.UseVisualStyleBackColor = true;
            this.scriptEnabled.Validating += new System.ComponentModel.CancelEventHandler(this.ScriptInfoEdit_Validating);
            // 
            // ScriptList
            // 
            this.ScriptList.AllowUserToAddRows = false;
            this.ScriptList.AllowUserToDeleteRows = false;
            this.ScriptList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ScriptList.AutoGenerateColumns = false;
            this.ScriptList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ScriptList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hotkeyCommandIdentifierDataGridViewTextBoxColumn,
            this.enabledDataGridViewCheckBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.onEventDataGridViewTextBoxColumn,
            this.askConfirmationDataGridViewCheckBoxColumn,
            this.addToRevisionGridContextMenuDataGridViewCheckBoxColumn});
            this.ScriptList.DataSource = this.scriptInfoBindingSource;
            this.ScriptList.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.ScriptList.Location = new System.Drawing.Point(5, 12);
            this.ScriptList.Name = "ScriptList";
            this.ScriptList.ReadOnly = true;
            this.ScriptList.RowHeadersVisible = false;
            this.ScriptList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ScriptList.Size = new System.Drawing.Size(691, 232);
            this.ScriptList.TabIndex = 37;
            this.ScriptList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ScriptList_CellClick);
            this.ScriptList.SelectionChanged += new System.EventHandler(this.ScriptList_SelectionChanged);
            // 
            // scriptInfoBindingSource
            // 
            this.scriptInfoBindingSource.DataSource = typeof(GitUI.Script.ScriptInfo);
            // 
            // helpLabel
            // 
            this.helpLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.helpLabel.AutoSize = true;
            this.helpLabel.BackColor = System.Drawing.SystemColors.Info;
            this.helpLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.helpLabel.Location = new System.Drawing.Point(530, 438);
            this.helpLabel.Name = "helpLabel";
            this.helpLabel.Size = new System.Drawing.Size(177, 17);
            this.helpLabel.TabIndex = 36;
            this.helpLabel.Text = "Press F1 to see available options";
            this.helpLabel.Visible = false;
            // 
            // inMenuCheckBox
            // 
            this.inMenuCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.inMenuCheckBox.AutoSize = true;
            this.inMenuCheckBox.Location = new System.Drawing.Point(109, 490);
            this.inMenuCheckBox.Name = "inMenuCheckBox";
            this.inMenuCheckBox.Size = new System.Drawing.Size(206, 19);
            this.inMenuCheckBox.TabIndex = 35;
            this.inMenuCheckBox.Text = "Add to revision grid context menu";
            this.inMenuCheckBox.UseVisualStyleBackColor = true;
            this.inMenuCheckBox.Validating += new System.ComponentModel.CancelEventHandler(this.ScriptInfoEdit_Validating);
            // 
            // argumentsLabel
            // 
            this.argumentsLabel.AutoSize = true;
            this.argumentsLabel.Location = new System.Drawing.Point(10, 311);
            this.argumentsLabel.Name = "argumentsLabel";
            this.argumentsLabel.Size = new System.Drawing.Size(69, 15);
            this.argumentsLabel.TabIndex = 34;
            this.argumentsLabel.Text = "Arguments:";
            // 
            // commandLabel
            // 
            this.commandLabel.AutoSize = true;
            this.commandLabel.Location = new System.Drawing.Point(10, 283);
            this.commandLabel.Name = "commandLabel";
            this.commandLabel.Size = new System.Drawing.Size(67, 15);
            this.commandLabel.TabIndex = 33;
            this.commandLabel.Text = "Command:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(10, 255);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(42, 15);
            this.nameLabel.TabIndex = 32;
            this.nameLabel.Text = "Name:";
            // 
            // browseScriptButton
            // 
            this.browseScriptButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.browseScriptButton.Location = new System.Drawing.Point(617, 278);
            this.browseScriptButton.Name = "browseScriptButton";
            this.browseScriptButton.Size = new System.Drawing.Size(75, 25);
            this.browseScriptButton.TabIndex = 31;
            this.browseScriptButton.Text = "Browse";
            this.browseScriptButton.UseVisualStyleBackColor = true;
            this.browseScriptButton.Click += new System.EventHandler(this.browseScriptButton_Click);
            // 
            // argumentsTextBox
            // 
            this.argumentsTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.helpProvider1.SetHelpString(this.argumentsTextBox, resources.GetString("argumentsTextBox.HelpString"));
            this.argumentsTextBox.Location = new System.Drawing.Point(109, 308);
            this.argumentsTextBox.Name = "argumentsTextBox";
            this.helpProvider1.SetShowHelp(this.argumentsTextBox, true);
            this.argumentsTextBox.Size = new System.Drawing.Size(587, 121);
            this.argumentsTextBox.TabIndex = 30;
            this.argumentsTextBox.Text = "";
            this.argumentsTextBox.Enter += new System.EventHandler(this.argumentsTextBox_Enter);
            this.argumentsTextBox.Leave += new System.EventHandler(this.argumentsTextBox_Leave);
            this.argumentsTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.ScriptInfoEdit_Validating);
            // 
            // commandTextBox
            // 
            this.commandTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.commandTextBox.Location = new System.Drawing.Point(109, 280);
            this.commandTextBox.Name = "commandTextBox";
            this.commandTextBox.Size = new System.Drawing.Size(496, 23);
            this.commandTextBox.TabIndex = 29;
            this.commandTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.ScriptInfoEdit_Validating);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameTextBox.Location = new System.Drawing.Point(109, 252);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(215, 23);
            this.nameTextBox.TabIndex = 28;
            this.nameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.ScriptInfoEdit_Validating);
            // 
            // moveDownButton
            // 
            this.moveDownButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.moveDownButton.Enabled = false;
            this.moveDownButton.Image = global::GitUI.Properties.Resources.ArrowDown;
            this.moveDownButton.Location = new System.Drawing.Point(727, 161);
            this.moveDownButton.Name = "moveDownButton";
            this.moveDownButton.Size = new System.Drawing.Size(26, 23);
            this.moveDownButton.TabIndex = 27;
            this.moveDownButton.UseVisualStyleBackColor = true;
            this.moveDownButton.Click += new System.EventHandler(this.moveDownButton_Click);
            // 
            // removeScriptButton
            // 
            this.removeScriptButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.removeScriptButton.Enabled = false;
            this.removeScriptButton.Location = new System.Drawing.Point(705, 130);
            this.removeScriptButton.Name = "removeScriptButton";
            this.removeScriptButton.Size = new System.Drawing.Size(75, 25);
            this.removeScriptButton.TabIndex = 26;
            this.removeScriptButton.Text = "Remove";
            this.removeScriptButton.UseVisualStyleBackColor = true;
            this.removeScriptButton.Click += new System.EventHandler(this.removeScriptButton_Click);
            // 
            // addScriptButton
            // 
            this.addScriptButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addScriptButton.Location = new System.Drawing.Point(705, 99);
            this.addScriptButton.Name = "addScriptButton";
            this.addScriptButton.Size = new System.Drawing.Size(75, 25);
            this.addScriptButton.TabIndex = 25;
            this.addScriptButton.Text = "Add";
            this.addScriptButton.UseVisualStyleBackColor = true;
            this.addScriptButton.Click += new System.EventHandler(this.addScriptButton_Click);
            // 
            // moveUpButton
            // 
            this.moveUpButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.moveUpButton.Enabled = false;
            this.moveUpButton.Image = global::GitUI.Properties.Resources.ArrowUp;
            this.moveUpButton.Location = new System.Drawing.Point(727, 70);
            this.moveUpButton.Name = "moveUpButton";
            this.moveUpButton.Size = new System.Drawing.Size(26, 23);
            this.moveUpButton.TabIndex = 24;
            this.moveUpButton.UseVisualStyleBackColor = true;
            this.moveUpButton.Click += new System.EventHandler(this.moveUpButton_Click);
            // 
            // contextMenuStrip_SplitButton
            // 
            this.contextMenuStrip_SplitButton.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.contextMenuStrip_SplitButton.Name = "contextMenuStrip1";
            this.contextMenuStrip_SplitButton.Size = new System.Drawing.Size(68, 70);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(67, 22);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(67, 22);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(67, 22);
            // 
            // hotkeyCommandIdentifierDataGridViewTextBoxColumn
            // 
            this.hotkeyCommandIdentifierDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.hotkeyCommandIdentifierDataGridViewTextBoxColumn.DataPropertyName = "HotkeyCommandIdentifier";
            this.hotkeyCommandIdentifierDataGridViewTextBoxColumn.HeaderText = "#";
            this.hotkeyCommandIdentifierDataGridViewTextBoxColumn.Name = "hotkeyCommandIdentifierDataGridViewTextBoxColumn";
            this.hotkeyCommandIdentifierDataGridViewTextBoxColumn.ReadOnly = true;
            this.hotkeyCommandIdentifierDataGridViewTextBoxColumn.Width = 39;
            // 
            // enabledDataGridViewCheckBoxColumn
            // 
            this.enabledDataGridViewCheckBoxColumn.DataPropertyName = "Enabled";
            this.enabledDataGridViewCheckBoxColumn.HeaderText = "Enabled";
            this.enabledDataGridViewCheckBoxColumn.Name = "enabledDataGridViewCheckBoxColumn";
            this.enabledDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // onEventDataGridViewTextBoxColumn
            // 
            this.onEventDataGridViewTextBoxColumn.DataPropertyName = "OnEvent";
            this.onEventDataGridViewTextBoxColumn.HeaderText = "OnEvent";
            this.onEventDataGridViewTextBoxColumn.Name = "onEventDataGridViewTextBoxColumn";
            this.onEventDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // askConfirmationDataGridViewCheckBoxColumn
            // 
            this.askConfirmationDataGridViewCheckBoxColumn.DataPropertyName = "AskConfirmation";
            this.askConfirmationDataGridViewCheckBoxColumn.HeaderText = "Confirmation";
            this.askConfirmationDataGridViewCheckBoxColumn.Name = "askConfirmationDataGridViewCheckBoxColumn";
            this.askConfirmationDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // addToRevisionGridContextMenuDataGridViewCheckBoxColumn
            // 
            this.addToRevisionGridContextMenuDataGridViewCheckBoxColumn.DataPropertyName = "AddToRevisionGridContextMenu";
            this.addToRevisionGridContextMenuDataGridViewCheckBoxColumn.HeaderText = "Context menu";
            this.addToRevisionGridContextMenuDataGridViewCheckBoxColumn.Name = "addToRevisionGridContextMenuDataGridViewCheckBoxColumn";
            this.addToRevisionGridContextMenuDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // ControlScripts
            // 
            this.Controls.Add(this.lbl_icon);
            this.Controls.Add(this.sbtn_icon);
            this.Controls.Add(this.scriptNeedsConfirmation);
            this.Controls.Add(this.labelOnEvent);
            this.Controls.Add(this.scriptEvent);
            this.Controls.Add(this.scriptEnabled);
            this.Controls.Add(this.ScriptList);
            this.Controls.Add(this.helpLabel);
            this.Controls.Add(this.inMenuCheckBox);
            this.Controls.Add(this.argumentsLabel);
            this.Controls.Add(this.commandLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.browseScriptButton);
            this.Controls.Add(this.argumentsTextBox);
            this.Controls.Add(this.commandTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.moveDownButton);
            this.Controls.Add(this.removeScriptButton);
            this.Controls.Add(this.addScriptButton);
            this.Controls.Add(this.moveUpButton);
            this.Name = "ControlScripts";
            this.Size = new System.Drawing.Size(785, 520);
            ((System.ComponentModel.ISupportInitialize)(this.ScriptList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scriptInfoBindingSource)).EndInit();
            this.contextMenuStrip_SplitButton.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_icon;
        private Script.SplitButton sbtn_icon;
        private System.Windows.Forms.CheckBox scriptNeedsConfirmation;
        private System.Windows.Forms.Label labelOnEvent;
        private System.Windows.Forms.ComboBox scriptEvent;
        private System.Windows.Forms.CheckBox scriptEnabled;
        private System.Windows.Forms.DataGridView ScriptList;
        private System.Windows.Forms.Label helpLabel;
        private System.Windows.Forms.CheckBox inMenuCheckBox;
        private System.Windows.Forms.Label argumentsLabel;
        private System.Windows.Forms.Label commandLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button browseScriptButton;
        private System.Windows.Forms.RichTextBox argumentsTextBox;
        private System.Windows.Forms.TextBox commandTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button moveDownButton;
        private System.Windows.Forms.Button removeScriptButton;
        private System.Windows.Forms.Button addScriptButton;
        private System.Windows.Forms.Button moveUpButton;
        private System.Windows.Forms.BindingSource scriptInfoBindingSource;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_SplitButton;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn hotkeyCommandIdentifierDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn enabledDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn onEventDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn askConfirmationDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn addToRevisionGridContextMenuDataGridViewCheckBoxColumn;

    }
}
