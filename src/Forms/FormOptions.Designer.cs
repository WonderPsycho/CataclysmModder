namespace CataclysmModder
{
    partial class FormOptions
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
            this.exportOptionsGroupBox = new System.Windows.Forms.GroupBox();
            this.preserveUnchangedCheck = new System.Windows.Forms.CheckBox();
            this.indentSpacesNumeric = new System.Windows.Forms.NumericUpDown();
            this.indentSpacesLabel = new System.Windows.Forms.Label();
            this.indentTabsCheck = new System.Windows.Forms.CheckBox();
            this.dontFormatJsonCheck = new System.Windows.Forms.CheckBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.applyButton = new System.Windows.Forms.Button();
            this.defaultJsonFolderTextBox = new System.Windows.Forms.TextBox();
            this.defaultJsonFolderLabel = new System.Windows.Forms.Label();
            this.exportOptionsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.indentSpacesNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // exportOptionsGroupBox
            // 
            this.exportOptionsGroupBox.Controls.Add(this.preserveUnchangedCheck);
            this.exportOptionsGroupBox.Controls.Add(this.indentSpacesNumeric);
            this.exportOptionsGroupBox.Controls.Add(this.indentSpacesLabel);
            this.exportOptionsGroupBox.Controls.Add(this.indentTabsCheck);
            this.exportOptionsGroupBox.Controls.Add(this.dontFormatJsonCheck);
            this.exportOptionsGroupBox.Location = new System.Drawing.Point(17, 16);
            this.exportOptionsGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.exportOptionsGroupBox.Name = "exportOptionsGroupBox";
            this.exportOptionsGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.exportOptionsGroupBox.Size = new System.Drawing.Size(208, 154);
            this.exportOptionsGroupBox.TabIndex = 0;
            this.exportOptionsGroupBox.TabStop = false;
            this.exportOptionsGroupBox.Text = "Export Options";
            // 
            // preserveUnchangedCheck
            // 
            this.preserveUnchangedCheck.AutoSize = true;
            this.preserveUnchangedCheck.Location = new System.Drawing.Point(9, 116);
            this.preserveUnchangedCheck.Margin = new System.Windows.Forms.Padding(4);
            this.preserveUnchangedCheck.Name = "preserveUnchangedCheck";
            this.preserveUnchangedCheck.Size = new System.Drawing.Size(194, 21);
            this.preserveUnchangedCheck.TabIndex = 4;
            this.preserveUnchangedCheck.Text = "Preserve unchanged data";
            this.preserveUnchangedCheck.UseVisualStyleBackColor = true;
            // 
            // indentSpacesNumeric
            // 
            this.indentSpacesNumeric.Location = new System.Drawing.Point(113, 84);
            this.indentSpacesNumeric.Margin = new System.Windows.Forms.Padding(4);
            this.indentSpacesNumeric.Name = "indentSpacesNumeric";
            this.indentSpacesNumeric.Size = new System.Drawing.Size(57, 22);
            this.indentSpacesNumeric.TabIndex = 3;
            // 
            // indentSpacesLabel
            // 
            this.indentSpacesLabel.AutoSize = true;
            this.indentSpacesLabel.Location = new System.Drawing.Point(9, 84);
            this.indentSpacesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.indentSpacesLabel.Name = "indentSpacesLabel";
            this.indentSpacesLabel.Size = new System.Drawing.Size(102, 17);
            this.indentSpacesLabel.TabIndex = 2;
            this.indentSpacesLabel.Text = "Indent Spaces:";
            // 
            // indentTabsCheck
            // 
            this.indentTabsCheck.AutoSize = true;
            this.indentTabsCheck.Location = new System.Drawing.Point(9, 54);
            this.indentTabsCheck.Margin = new System.Windows.Forms.Padding(4);
            this.indentTabsCheck.Name = "indentTabsCheck";
            this.indentTabsCheck.Size = new System.Drawing.Size(133, 21);
            this.indentTabsCheck.TabIndex = 1;
            this.indentTabsCheck.Text = "Indent with Tabs";
            this.indentTabsCheck.UseVisualStyleBackColor = true;
            this.indentTabsCheck.CheckedChanged += new System.EventHandler(this.indentTabsCheck_CheckedChanged);
            // 
            // dontFormatJsonCheck
            // 
            this.dontFormatJsonCheck.AutoSize = true;
            this.dontFormatJsonCheck.Location = new System.Drawing.Point(9, 25);
            this.dontFormatJsonCheck.Margin = new System.Windows.Forms.Padding(4);
            this.dontFormatJsonCheck.Name = "dontFormatJsonCheck";
            this.dontFormatJsonCheck.Size = new System.Drawing.Size(157, 21);
            this.dontFormatJsonCheck.TabIndex = 0;
            this.dontFormatJsonCheck.Text = "Do not format JSON";
            this.dontFormatJsonCheck.UseVisualStyleBackColor = true;
            this.dontFormatJsonCheck.CheckedChanged += new System.EventHandler(this.dontFormatJsonCheck_CheckedChanged);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(125, 279);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(100, 28);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // applyButton
            // 
            this.applyButton.Location = new System.Drawing.Point(17, 279);
            this.applyButton.Margin = new System.Windows.Forms.Padding(4);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(100, 28);
            this.applyButton.TabIndex = 2;
            this.applyButton.Text = "Apply";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // defaultJsonFolderTextBox
            // 
            this.defaultJsonFolderTextBox.Location = new System.Drawing.Point(17, 204);
            this.defaultJsonFolderTextBox.Name = "defaultJsonFolderTextBox";
            this.defaultJsonFolderTextBox.Size = new System.Drawing.Size(208, 22);
            this.defaultJsonFolderTextBox.TabIndex = 7;
            this.defaultJsonFolderTextBox.TextChanged += new System.EventHandler(this.defaultJsonFolderTextBox_TextChanged);
            // 
            // defaultJsonFolderLabel
            // 
            this.defaultJsonFolderLabel.AutoSize = true;
            this.defaultJsonFolderLabel.Location = new System.Drawing.Point(14, 184);
            this.defaultJsonFolderLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.defaultJsonFolderLabel.Name = "defaultJsonFolderLabel";
            this.defaultJsonFolderLabel.Size = new System.Drawing.Size(138, 17);
            this.defaultJsonFolderLabel.TabIndex = 8;
            this.defaultJsonFolderLabel.Text = "Default JSON folder:";
            // 
            // FormOptions
            // 
            this.AcceptButton = this.applyButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(245, 322);
            this.Controls.Add(this.defaultJsonFolderLabel);
            this.Controls.Add(this.defaultJsonFolderTextBox);
            this.Controls.Add(this.applyButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.exportOptionsGroupBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormOptions";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Options";
            this.exportOptionsGroupBox.ResumeLayout(false);
            this.exportOptionsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.indentSpacesNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox exportOptionsGroupBox;
        private System.Windows.Forms.NumericUpDown indentSpacesNumeric;
        private System.Windows.Forms.Label indentSpacesLabel;
        private System.Windows.Forms.CheckBox indentTabsCheck;
        private System.Windows.Forms.CheckBox dontFormatJsonCheck;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.CheckBox preserveUnchangedCheck;
        private System.Windows.Forms.TextBox defaultJsonFolderTextBox;
        private System.Windows.Forms.Label defaultJsonFolderLabel;
    }
}