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
    public struct NewBuildingFormResult
    {
        public NewBuildingFormResult(DialogResult result, string buildingName, string floorName, string filepath)
        {
            this.result = result;
            this.buildingName = buildingName;
            this.filepath = filepath;
            this.floorName = floorName;
        }

        public DialogResult result { get; }

        public string buildingName { get; }

        public string floorName { get; }

        public string filepath { get; }
    }

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
                !string.IsNullOrEmpty(buildingNameLabel.Text) &&
                !string.IsNullOrEmpty(floorNameLabel.Text);
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
            DialogResult = DialogResult.OK;
            Close();
        }

        private void buildingNameTextbox_TextChanged(object sender, EventArgs e)
        {
            UpdateSaveButton();
        }

        public NewBuildingFormResult ShowNewBuilding()
        {
            DialogResult dialogResult = ShowDialog();
            NewBuildingFormResult result;

            if (dialogResult == DialogResult.OK)
            {
                result = new NewBuildingFormResult(dialogResult, buildingNameTextbox.Text, floorNameTextbox.Text, filepath);
            }
            else
            {
                result = new NewBuildingFormResult(dialogResult, "", "", "");
            }

            return result;
        }
    }
}
