using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BuildingMapper.FormResults;
using BuildingMapper.Util;

namespace BuildingMapper
{
    public partial class FloorEditor : UserControl
    {
        public string FloorName { get; set; }

        public FloorEditor(string floorName)
        {
            InitializeComponent();
            FloorName = floorName;
        }

        private void UpdateRoomList()
        {
            roomListBox.Items.Clear();

            foreach (Room room in Building.Instance.GetRooms(FloorName))
            {
                roomListBox.Items.Add(room.Name);
            }

            UpdateEditButton();
        }

        private void UpdateEditButton()
        {
            if (roomListBox.SelectedItems.Count > 0)
            {
                editButton.Enabled = true;
            }
            else
            {
                editButton.Enabled = false;
            }
        }

        public void UpdateImage(Image image)
        {
            this.roomEditorPanel1.Image = image;
            this.roomEditorPanel1.Initialize();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            RoomEditorForm newForm = new RoomEditorForm(FloorName);
            RoomEditorFormResult result = newForm.ShowAddRoomEditor();

            if (result.DialogResult == DialogResult.OK)
            {
                Building.Instance.AddRoom(FloorName, result.Room);
            }

            UpdateRoomList();
        }






        private void resetZoomButton_Click(object sender, EventArgs e)
        {
            roomEditorPanel1.ZoomToFit();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            Room? selectedRoom = null;

            foreach (Room r in Building.Instance.GetRooms(FloorName))
            {
                if (roomListBox.SelectedItem.ToString() == r.Name)
                {
                    selectedRoom = r;
                    break;
                }
            }

            if (selectedRoom == null)
            {
                throw new Exception("Selected room not found in list of rooms");
            }

            string oldname = selectedRoom.Name;
            RoomEditorForm newForm = new RoomEditorForm(FloorName);
            RoomEditorFormResult result = newForm.ShowEditRoomEditor(selectedRoom, oldname);

            if (result.DialogResult == DialogResult.OK)
            {
                Building.Instance.EditRoom(FloorName, oldname, result.Room);
            }

            UpdateRoomList();
        }

        private void roomListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateEditButton();
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            Room? selectedRoom = null;

            foreach (Room r in Building.Instance.GetRooms(FloorName))
            {
                if (roomListBox.SelectedItem.ToString() == r.Name)
                {
                    selectedRoom = r;
                    break;
                }
            }

            if (selectedRoom == null)
            {
                throw new Exception("Selected room not found in list of rooms");
            }

            Building.Instance.RemoveRoom(FloorName, selectedRoom.Name);

            UpdateRoomList();
        }
    }
}
