using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CataclysmModder
{
    public partial class FormExportItems : Form
    {
        public FormExportItems()
        {
            InitializeComponent();

            //Load up listbox
            itemToExportCheckedListBox.Items.Clear();
            foreach (ItemDataWrapper data in Storage.OpenItems)
            {
                itemToExportCheckedListBox.Items.Add(data.Display);
            }

            int index = 0;
            foreach (ItemDataWrapper data in Storage.OpenItems)
            {
                itemToExportCheckedListBox.SetItemChecked(index, data.Modified);
                index++;
            }
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.AddExtension = true;
            save.DefaultExt = "json";
            save.OverwritePrompt = true;
            save.Title = "Export Items";

            if (save.ShowDialog() == DialogResult.OK)
            {
                int[] indices = new int[itemToExportCheckedListBox.CheckedIndices.Count];
                for (int c = 0; c < itemToExportCheckedListBox.CheckedIndices.Count; c++)
                    indices[c] = itemToExportCheckedListBox.CheckedIndices[c];
                Storage.ExportFile(save.FileName, indices);
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
