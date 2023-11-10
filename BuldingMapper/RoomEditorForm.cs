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
    public struct RoomEditorFormResult
    {
        public RoomEditorFormResult(DialogResult result, List<Room> rooms)
        {
            this.result = result;
            this.rooms = rooms;
        }

        public DialogResult result { get; }

        public List<Room> rooms { get; }
    }

    public partial class RoomEditorForm : Form
    {
        List<Room> newRooms;
        List<Room> existingRooms;

        public RoomEditorForm(List<Room> existingRooms)
        {
            InitializeComponent();

            this.existingRooms = existingRooms;

            List<string> types = new List<string>();

            //Add each RoomValue enum to a list as a string
            foreach (RoomType type in Enum.GetValues(typeof(RoomType)))
            {
                types.Add(type.ToString());
            }

            types.Sort();

            //Add the sorted RoomValue list into the comboBox
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

            //Add each AccesibilityTag enum to a list as a string
            foreach (Room r in existingRooms)
            {
                roomNames.Add(r.Name);
            }

            roomNames.Sort();

            //Add the sorted AccesibilityTag list into the comboBox
            foreach (string name in roomNames)
            {
                connectionsCheckedListBox.Items.Add(name);
            }

            newRooms = new List<Room>();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateControls();
        }

        public RoomEditorFormResult ShowRoomEditor()
        {
            DialogResult dialogResult = ShowDialog();
            RoomEditorFormResult result;

            if (dialogResult == DialogResult.OK)
            {
                Room room = new Room(roomNameTextBox.Text);
                RoomType type = RoomType.Unspecified;
                Enum.TryParse<RoomType>(roomTypeComboBox.SelectedItem.ToString(), true, out type);
                room.Type = type;
                newRooms.Add(room);
                result = new RoomEditorFormResult(dialogResult, newRooms);
            }
            else
            {
                result = new RoomEditorFormResult(dialogResult, new List<Room>());
            }

            return result;
        }

        private void roomNameTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateControls();
        }

        private void UpdateControls()
        {
            saveButton.Enabled = roomNameTextBox.Text != "" && roomTypeComboBox.SelectedItem != null;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            List<Room> combinedRooms = new List<Room>();
            combinedRooms.AddRange(existingRooms);
            combinedRooms.AddRange(newRooms);

            RoomEditorForm newForm = new RoomEditorForm(combinedRooms);
            RoomEditorFormResult result = newForm.ShowRoomEditor();

            if (result.result == DialogResult.OK)
            {
                newRooms.AddRange(result.rooms);
            }

            UpdateRoomList();
        }

        private void UpdateRoomList()
        {
            List<Room> combinedRooms = new List<Room>();
            combinedRooms.AddRange(existingRooms);
            combinedRooms.AddRange(newRooms);

            connectionsCheckedListBox.Items.Clear();

            List<string> roomNames = new List<string>();

            //Add each AccesibilityTag enum to a list as a string
            foreach (Room r in combinedRooms)
            {
                roomNames.Add(r.Name);
            }

            roomNames.Sort();

            //Add the sorted AccesibilityTag list into the comboBox
            foreach (string name in roomNames)
            {
                connectionsCheckedListBox.Items.Add(name);
            }

            string s = (string)connectionsCheckedListBox.SelectedItem;
        }

        private bool isInList(string roomName)
        {
            foreach (Room r in newRooms)
            {
                if (r.Name == roomName) return true;
            }

            return false;
        }

        private void editButton_Click(object sender, EventArgs e)
        {

        }
    }
}
