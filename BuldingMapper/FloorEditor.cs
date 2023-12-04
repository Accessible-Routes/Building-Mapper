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
            RoomEditorFormResult result = newForm.ShowAddRoomEditor();

            if (result.DialogResult == DialogResult.OK)
            {
                foreach (RoomChange change in result.Changes)
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

            UpdateRoomList();
        }

        private void resetZoomButton_Click(object sender, EventArgs e)
        {
            roomEditorPanel1.ZoomToFit();
        }
    }
}
