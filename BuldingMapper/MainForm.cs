namespace BuldingMapper
{
    public partial class MainForm : Form
    {
        List<Room> rooms = new List<Room>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RoomEditorForm newForm = new RoomEditorForm(rooms);
            RoomEditorResult result = newForm.ShowRoomEditor();

            if (result.result == DialogResult.OK)
            {
                rooms.AddRange(result.rooms);
            }

            UpdateRoomList();
        }

        private void UpdateRoomList()
        {
            roomListBox.Items.Clear();

            foreach (Room room in rooms)
            {
                roomListBox.Items.Add(room.Name);
            }
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