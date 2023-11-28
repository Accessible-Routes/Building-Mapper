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
    public partial class FloorEditor : UserControl
    {
        public List<Room> Rooms = new List<Room>();

        public string FloorName { get; set; }

        public FloorEditor(string floorName)
        {
            InitializeComponent();
            FloorName = floorName;
        }

        private void UpdateRoomList()
        {
            roomListBox.Items.Clear();

            foreach (Room room in Rooms)
            {
                roomListBox.Items.Add(room.Name);
            }
        }

        public void UpdateImage(Image image)
        {
            this.roomEditorPanel1.Image = image;
            this.roomEditorPanel1.Initialize();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            RoomEditorForm newForm = new RoomEditorForm(Rooms);
            RoomEditorFormResult result = newForm.ShowRoomEditor();

            if (result.result == DialogResult.OK)
            {
                Rooms.AddRange(result.rooms);
            }

            UpdateRoomList();
        }

        private void resetZoomButton_Click(object sender, EventArgs e)
        {
            roomEditorPanel1.ZoomToFit();
        }
    }
}
