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
        List<Room> rooms = new List<Room>();

        public FloorEditor()
        {
            InitializeComponent();
        }

        private void UpdateRoomList()
        {
            roomListBox.Items.Clear();

            foreach (Room room in rooms)
            {
                roomListBox.Items.Add(room.Name);
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            RoomEditorForm newForm = new RoomEditorForm(rooms);
            RoomEditorResult result = newForm.ShowRoomEditor();

            if (result.result == DialogResult.OK)
            {
                rooms.AddRange(result.rooms);
            }

            UpdateRoomList();
        }
    }
}
