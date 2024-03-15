using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using BuildingMapper.FormResults;
using BuildingMapper.Forms;
using BuildingMapper.Util;

namespace BuildingMapper
{
    public partial class MainForm : Form
    {
        string? buildingName = null;

        //State data
        private string saveFile = string.Empty;

        public MainForm()
        {
            InitializeComponent();
        }


        #region Event Functions

        private void newBuildingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewBuildingForm newBuildingForm = new NewBuildingForm();
            NewBuildingFormResult result = newBuildingForm.ShowNewBuilding();

            if (result.DialogResult == DialogResult.OK)
            {
                //Make sure the user wanted to do this without saving
                if (!Building.Instance.BuildingSaved)
                {
                    SaveWarningForm newSaveWarning = new SaveWarningForm();
                    SaveWarningFormResult warningResult = newSaveWarning.ShowDialog(Building.Instance.Name);

                    if (warningResult.DialogResult != DialogResult.OK)
                    {
                        return;
                    }
                }

                //Remove other tabs
                floorTabControl.TabPages.Clear();

                Building.Instance.BuildingSaved = false;

                //Save building name and change window text
                buildingName = result.BuildingName;
                this.Text = "Building Editor (" + buildingName + ")";

                //Load selected image
                Image floorPlanImage = Image.FromFile(result.Filepath);

                //Create tab for floor selected in new building form
                TabPage tabPage = new TabPage(result.FloorName);
                floorTabControl.TabPages.Add(tabPage);

                //Create floor editor for new floor
                FloorEditor floorEditor = new FloorEditor(buildingName);
                floorEditor.Dock = DockStyle.Fill;

                tabPage.Controls.Add(floorEditor);
                Building.Instance.AddFloor(result.FloorName);

                floorEditor.UpdateImage(floorPlanImage);


            }
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveBuildingAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = saveBuildingDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                saveBuildingDialog.FileName = buildingName;
                List<Floor> _data = Building.Instance.GetFloors();
                System.Diagnostics.Debug.WriteLine(_data.Count);
                var options = new JsonSerializerOptions { WriteIndented = true };
                string jsonString = JsonSerializer.Serialize(_data, options);
                saveFile = saveBuildingDialog.FileName;
                File.WriteAllText(saveFile, jsonString);

                Building.Instance.BuildingSaved = true;
            }
        }

        private void saveBuildingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //If we don't have an established save file, this should act like a save as
            if (saveFile == string.Empty)
            {
                saveBuildingAsToolStripMenuItem_Click(sender, e);
            }
            else
            {
                List<Floor> _data = Building.Instance.GetFloors();
                var options = new JsonSerializerOptions { WriteIndented = true };
                string jsonString = JsonSerializer.Serialize(_data, options);
                File.WriteAllText(saveFile, jsonString);
            }

            Building.Instance.BuildingSaved = true;
        }

        #endregion
    }
}