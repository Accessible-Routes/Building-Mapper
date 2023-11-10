namespace BuildingMapper
{
    public partial class MainForm : Form
    {
        string? buildingName = null;
        List<FloorEditor> floors = new List<FloorEditor>();



        public MainForm()
        {
            InitializeComponent();
        }



        private void saveBuildingToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveFloorAsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void newBuildingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewBuildingForm newBuildingForm = new NewBuildingForm();
            NewBuildingFormResult result = newBuildingForm.ShowNewBuilding();

            if (result.result == DialogResult.OK)
            {
                buildingName = result.buildingName;
                this.Text = "Room Editor (" + buildingName + ")";
                Image floorPlanImage = Image.FromFile(result.filepath);

                TabPage tabPage = new TabPage(result.floorName);
                floorTabControl.TabPages.Add(tabPage);

                FloorEditor floorEditor = new FloorEditor();
                floorEditor.Dock = DockStyle.Fill;

                tabPage.Controls.Add(floorEditor);
                floors.Add(floorEditor);

                floorEditor.UpdateImage(floorPlanImage);

                floorTabControl.TabPages.RemoveByKey("welcomeTab");
            }
        }
    }
}