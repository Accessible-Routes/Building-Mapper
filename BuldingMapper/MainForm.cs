namespace BuldingMapper
{
    public partial class MainForm : Form
    {
        List<Room> rooms = new List<Room>();

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
    }
}