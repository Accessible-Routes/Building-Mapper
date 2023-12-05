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
            RoomEditorForm newForm = new RoomEditorForm(Rooms);
            RoomEditorFormResult result = newForm.ShowAddRoomEditor();

            if (result.DialogResult == DialogResult.OK)
            {
                ProcessChanges(result.Changes);
            }

            UpdateRoomList();
        }


        private void ProcessChanges(List<RoomChange> changes)
        {
            foreach (RoomChange change in changes)
            {
                switch (change.ChangeType)
                {
                    case ChangeType.Add:
                        if (change.NewRoom != null)
                        {
                            Rooms.Add(change.NewRoom);
                        }
                        else
                        {
                            throw new NullReferenceException();
                        }
                        break;

                    case ChangeType.Edit:
                        if (change.NewRoom != null)
                        {
                            foreach (Room room in Rooms)
                            {
                                if (room.Name == change.Target)
                                {
                                    Rooms.Remove(room);
                                    Rooms.Add(change.NewRoom);
                                    break;
                                }
                            }
                        }
                        else
                        {
                            throw new NullReferenceException();
                        }
                        break;

                    case ChangeType.Remove:
                        foreach (Room room in Rooms)
                        {
                            if (room.Name == change.Target)
                            {
                                Rooms.Remove(room);
                                break;
                            }
                        }
                        break;

                    default:
                        throw new InvalidEnumArgumentException();
                }
            }
        }


        private void resetZoomButton_Click(object sender, EventArgs e)
        {
            roomEditorPanel1.ZoomToFit();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            Room? selectedRoom = null;
            
            foreach (Room r in Rooms)
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

            RoomEditorForm newForm = new RoomEditorForm(Rooms);
            RoomEditorFormResult result = newForm.ShowEditRoomEditor(selectedRoom);

            if (result.DialogResult == DialogResult.OK)
            {
                ProcessChanges(result.Changes);
            }

            UpdateRoomList();
        }

        private void roomListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateEditButton();
        }
    }
}
