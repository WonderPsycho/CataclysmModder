namespace CataclysmModder
{
    partial class FormExportItems
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
            this.itemToExportCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.itemsToExportLabel = new System.Windows.Forms.Label();
            this.exportButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // itemToExportCheckedListBox
            // 
            this.itemToExportCheckedListBox.FormattingEnabled = true;
            this.itemToExportCheckedListBox.Location = new System.Drawing.Point(16, 36);
            this.itemToExportCheckedListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.itemToExportCheckedListBox.Name = "itemToExportCheckedListBox";
            this.itemToExportCheckedListBox.Size = new System.Drawing.Size(209, 344);
            this.itemToExportCheckedListBox.TabIndex = 0;
            // 
            // itemsToExportLabel
            // 
            this.itemsToExportLabel.AutoSize = true;
            this.itemsToExportLabel.Location = new System.Drawing.Point(17, 16);
            this.itemsToExportLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.itemsToExportLabel.Name = "itemsToExportLabel";
            this.itemsToExportLabel.Size = new System.Drawing.Size(104, 17);
            this.itemsToExportLabel.TabIndex = 1;
            this.itemsToExportLabel.Text = "Items to export:";
            // 
            // exportButton
            // 
            this.exportButton.Location = new System.Drawing.Point(17, 412);
            this.exportButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(100, 28);
            this.exportButton.TabIndex = 2;
            this.exportButton.Text = "Export";
            this.exportButton.UseVisualStyleBackColor = true;
            this.exportButton.Click += new System.EventHandler(this.exportButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(127, 412);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(100, 28);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // FormExportItems
            // 
            this.AcceptButton = this.exportButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(248, 455);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.exportButton);
            this.Controls.Add(this.itemsToExportLabel);
            this.Controls.Add(this.itemToExportCheckedListBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormExportItems";
            this.Text = "Export Items";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox itemToExportCheckedListBox;
        private System.Windows.Forms.Label itemsToExportLabel;
        private System.Windows.Forms.Button exportButton;
        private System.Windows.Forms.Button cancelButton;
    }
}