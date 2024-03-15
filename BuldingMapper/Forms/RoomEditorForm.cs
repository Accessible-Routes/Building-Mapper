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
    public partial class RoomEditorForm : Form
    {
        private string floorName;

        public RoomEditorForm(string floorName)
        {
            InitializeComponent();

            this.floorName = floorName;

            List<string> types = new List<string>();

            //Add each RoomType enum to a list as a string
            foreach (RoomType type in Enum.GetValues(typeof(RoomType)))
            {
                types.Add(type.ToString());
            }

            types.Sort();

            //Add the sorted types list into the comboBox
            foreach (string type in types)
            {
                roomTypeComboBox.Items.Add(type);
            }

            UpdateTagList(GetThisRoom());

            UpdateRoomList(GetThisRoom());
        }

        #region Event Functions

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateSaveButton();
        }

        private void connectionsCheckedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void roomNameTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateSaveButton();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }


        #endregion

        public RoomEditorFormResult ShowAddRoomEditor()
        {
            DialogResult dialogResult = ShowDialog();

            RoomEditorFormResult result = new RoomEditorFormResult()
            {
                DialogResult = dialogResult,
                Room = GetThisRoom()
            };

            return result;
        }

        public RoomEditorFormResult ShowEditRoomEditor(Room roomToEdit, string oldName)
        {
            roomNameTextBox.Text = roomToEdit.Name;

            roomTypeComboBox.SelectedItem = roomToEdit.Type.ToString();


            UpdateTagList(roomToEdit);
            UpdateRoomList(roomToEdit);

            DialogResult dialogResult = ShowDialog();

            RoomEditorFormResult result = new RoomEditorFormResult()
            {
                DialogResult = dialogResult,
                Room = GetThisRoom()
            };

            return result;
        }


        private void UpdateSaveButton()
        {
            saveButton.Enabled = roomNameTextBox.Text != "" && roomTypeComboBox.SelectedItem != null;
        }

        private void UpdateRoomList(Room currentRoom)
        {
            List<Room> combinedRooms = Building.Instance.GetRooms(floorName);

            //We don't want to see the room we're working on in this list
            foreach (Room room in combinedRooms)
            {
                if (room.Name == GetThisRoom().Name)
                {
                    combinedRooms.Remove(room);
                    break;
                }
            }

            connectionsCheckedListBox.Items.Clear();

            List<string> roomNames = new List<string>();

            //Add each room name to a list as a string
            foreach (Room r in combinedRooms)
            {
                roomNames.Add(r.Name);
            }

            roomNames.Sort();

            //Add the sorted room names list into the list box
            int index = 0;
            foreach (string name in roomNames)
            {
                connectionsCheckedListBox.Items.Add(name);

                //Mark our checkbox if the room is connected
                if (currentRoom.ConnectedRooms.Contains(name))
                {
                    connectionsCheckedListBox.SetItemChecked(index, true);
                }

                index++;
            }

            string s = (string)connectionsCheckedListBox.SelectedItem;
        }

        private void UpdateTagList(Room currentRoom)
        {
            tagsListCheckbox.Items.Clear();

            List<string> tags = new List<string>();

            //Add each AccesibilityTag enum to a list as a string
            foreach (AccessibilityTag tag in Enum.GetValues(typeof(AccessibilityTag)))
            {
                tags.Add(tag.ToString());
            }

            tags.Sort();

            //Add the sorted AccesibilityTag list into the list box
            int index = 0;
            foreach (string tag in tags)
            {
                tagsListCheckbox.Items.Add(tag);

                //Check the tag if it's been selected
                if (currentRoom.AccessibilityTags.Contains(tag))
                {
                    tagsListCheckbox.SetItemChecked(index, true);
                }

                index++;
            }
        }

        private Room GetThisRoom()
        {
            //Get selected connected rooms
            List<string> selectedConnections = new List<string>();

            foreach (string r in connectionsCheckedListBox.CheckedItems)
            {
                selectedConnections.Add(r);
            }


            //Get selected accessibility tags
            List<string> selectedTags = new List<string>();

            foreach (string r in tagsListCheckbox.CheckedItems)
            {
                selectedTags.Add(r);
            }

            RoomType type;

            if (roomTypeComboBox.SelectedItem == null || !Enum.TryParse<RoomType>(roomTypeComboBox.SelectedItem.ToString(), true, out type))
            {
                type = RoomType.Unspecified;
            }

            Room thisRoom = new Room()
            {
                Name = roomNameTextBox.Text,
                ConnectedRooms = selectedConnections,
                AccessibilityTags = selectedTags,
                Type = type
            };

            return thisRoom;
        }


    }
}
