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

        }
    }
}