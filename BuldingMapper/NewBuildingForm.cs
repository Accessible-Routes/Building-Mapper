using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuildingMapper
{
    public partial class NewBuildingForm : Form
    {
        string? filepath = null;
        public NewBuildingForm()
        {
            InitializeComponent();
        }

        private void UpdateSaveButton()
        {
            saveButton.Enabled = !string.IsNullOrEmpty(filepath) &&
                !string.IsNullOrEmpty(buildingNameLabel.Text);
        }

        private void chooseFileButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            filepath = openFileDialog1.FileName;
            selectedFileLabel.Text = openFileDialog1.FileName;

            UpdateSaveButton();

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buildingNameTextbox_TextChanged(object sender, EventArgs e)
        {
            UpdateSaveButton();
        }
    }
}
