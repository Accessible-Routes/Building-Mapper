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
    public partial class RoomEditorForm : Form
    {
        RoomChangeTracker roomChangeTracker;
        public RoomEditorForm(RoomChangeTracker roomChangeTracker)
        {
            InitializeComponent();

            this.roomChangeTracker = roomChangeTracker;

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

            List<string> tags = new List<string>();

            //Add each AccesibilityTag enum to a list as a string
            foreach (AccessibilityTag tag in Enum.GetValues(typeof(AccessibilityTag)))
            {
                tags.Add(tag.ToString());
            }

            tags.Sort();

            //Add the sorted AccesibilityTag list into the comboBox
            foreach (string tag in tags)
            {
                tagsListCheckbox.Items.Add(tag);
            }

            List<string> roomNames = new List<string>();

            UpdateRoomList();
        }

        #region Event Functions

        private void addButton_Click(object sender, EventArgs e)
        {
            RoomChangeTracker newRCT = new RoomChangeTracker(roomChangeTracker.CollectRooms());
            RoomEditorForm newForm = new RoomEditorForm(newRCT);
            RoomEditorFormResult result = newForm.ShowAddRoomEditor();

            if (result.DialogResult == DialogResult.OK)
            {
                roomChangeTracker.MergeRoomTracker(newRCT);
            }

            UpdateRoomList();
        }

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

        private void editButton_Click(object sender, EventArgs e)
        {
            List<Room> combinedRooms = roomChangeTracker.CollectRooms();

            Room? selectedRoom = null;

            foreach (Room r in combinedRooms)
            {
                if (connectionsCheckedListBox.SelectedItem.ToString() == r.Name)
                {
                    selectedRoom = r;
                    break;
                }
            }

            if (selectedRoom == null)
            {
                throw new Exception("Selected room not found in list of rooms");
            }

            string oldName = selectedRoom.Name;
            RoomChangeTracker newRCT = new RoomChangeTracker(combinedRooms);
            RoomEditorForm newForm = new RoomEditorForm(newRCT);
            RoomEditorFormResult result = newForm.ShowEditRoomEditor(selectedRoom, oldName);

            if (result.DialogResult == DialogResult.OK)
            {
                roomChangeTracker.MergeRoomTracker(newRCT);
            }

            UpdateRoomList();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            List<Room> combinedRooms = roomChangeTracker.CollectRooms();

            Room? selectedRoom = null;

            foreach (Room r in combinedRooms)
            {
                if (connectionsCheckedListBox.SelectedItem.ToString() == r.Name)
                {
                    selectedRoom = r;
                    break;
                }
            }

            if (selectedRoom == null)
            {
                throw new Exception("Selected room not found in list of rooms");
            }

            roomChangeTracker.RemoveRoom(selectedRoom);

            UpdateRoomList();
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

            roomChangeTracker.AddRoom(GetThisRoom());

            RoomEditorFormResult result = new RoomEditorFormResult() { DialogResult = dialogResult };

            return result;
        }

        public RoomEditorFormResult ShowEditRoomEditor(Room roomToEdit, string oldName)
        {

            roomNameTextBox.Text = roomToEdit.Name;

            roomTypeComboBox.SelectedItem = roomToEdit.Type.ToString();

            //This is here to make sure that the Room List doesnt not contain
            //the room we are working on
            UpdateRoomList();

            DialogResult dialogResult = ShowDialog();

            roomChangeTracker.EditRoom(GetThisRoom(), oldName);

            RoomEditorFormResult result = new RoomEditorFormResult() { DialogResult = dialogResult };

            return result;
        }


        private void UpdateSaveButton()
        {
            saveButton.Enabled = roomNameTextBox.Text != "" && roomTypeComboBox.SelectedItem != null;
        }


        private void UpdateRoomList()
        {
            List<Room> combinedRooms = roomChangeTracker.CollectRooms();

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

            //Add the sorted room names list into the comboBox
            foreach (string name in roomNames)
            {
                connectionsCheckedListBox.Items.Add(name);
            }

            string s = (string)connectionsCheckedListBox.SelectedItem;
        }

        private Room GetThisRoom()
        {
            //TODO: Parse selected connected rooms

            //TODO: Parse selected accessibility tags
            RoomType type;

            if (roomTypeComboBox.SelectedItem == null || !Enum.TryParse<RoomType>(roomTypeComboBox.SelectedItem.ToString(), true, out type))
            {
                type = RoomType.Unspecified;
            }

            Room thisRoom = new Room()
            {
                Name = roomNameTextBox.Text,
                Type = type
            };

            return thisRoom;
        }


    }
}
