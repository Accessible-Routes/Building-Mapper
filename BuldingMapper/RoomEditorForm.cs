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
    public enum ChangeType
    {
        Add,
        Edit,
        Remove
    }

    public struct RoomChange
    {
        public ChangeType ChangeType;
        public string Target;
        public Room? NewRoom;
    }

    public class RoomEditorFormResult : FormResult
    {
        public List<RoomChange> Changes { get; set; }

        public RoomEditorFormResult()
        {
            Changes = new List<RoomChange>();
        }
    }

    public partial class RoomEditorForm : Form
    {
        List<RoomChange> newChanges;
        List<Room> existingRooms;
        Room? RoomBackup;

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

            //Add each Room Name to a list as a string
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

            newChanges = new List<RoomChange>();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateSaveButton();
        }

        public RoomEditorFormResult ShowAddRoomEditor()
        {
            DialogResult dialogResult = ShowDialog();

            RoomEditorFormResult result = GetFormResult(dialogResult, ChangeType.Add);
            
            return result;
        }

        private RoomEditorFormResult GetFormResult(DialogResult dialogResult, ChangeType changeType)
        {
            RoomType type;
            
            if(roomTypeComboBox.SelectedItem == null || !Enum.TryParse<RoomType>(roomTypeComboBox.SelectedItem.ToString(), true, out type))
            {
                type = RoomType.Unspecified;
            }

            //TODO: Parse selected connected rooms

            //TODO: Parse selected accessibility tags

            //Create our new Room object w/ data entered
            Room newRoom = new Room()
            {
                Name = roomNameTextBox.Text,
                Type = type,
            };

            //Create our RoomChange object w/ necessary data
            RoomChange newChange = new RoomChange()
            {
                ChangeType = changeType,
                Target = newRoom.Name,
                NewRoom = newRoom
            };

            newChanges.Add(newChange);

            RoomEditorFormResult formResult = new RoomEditorFormResult()
            {
                DialogResult = dialogResult,
                Changes = newChanges
            };

            return formResult;
        }

        private void roomNameTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateSaveButton();
        }

        private void UpdateSaveButton()
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
            List<Room> combinedRooms = GetCombinedRooms(existingRooms, newChanges);

            RoomEditorForm newForm = new RoomEditorForm(combinedRooms);
            RoomEditorFormResult result = newForm.ShowAddRoomEditor();

            if (result.DialogResult == DialogResult.OK)
            {
                newChanges.AddRange(result.Changes);
            }

            UpdateRoomList();
        }

        private List<Room> GetCombinedRooms(List<Room> rooms, List<RoomChange> changes)
        {
            List<Room> combinedRooms = new List<Room>();
            //We don't want to see any rooms that we've removed, so dont send
            //those to the new form
            //Our rooms list may contain rooms we've edited. If a room was edited,
            //we want to take the updated data from the appropriate RoomChange 
            //object instead.
            //TODO: This is n^2 efficiency... could be better
            foreach (Room room in rooms)
            {
                bool shouldBeAdded = true;
                foreach (RoomChange change in newChanges)
                {
                    if (change.ChangeType == ChangeType.Remove)
                    {
                        if (change.Target == room.Name)
                        {
                            shouldBeAdded = false;
                            break;
                        }
                    }

                    else if (change.ChangeType == ChangeType.Edit)
                    {
                         if (change.Target == room.Name)
                         {
                            shouldBeAdded = false;
                            break;
                         }
                    }
                }

                if (shouldBeAdded)
                {
                    combinedRooms.Add(room);
                }
            }

            //We want to see any new rooms we've created, so we need to 
            //grab them from our change list.
            //We also grab any rooms that may have been edited.
            List<Room> newRooms = new List<Room>();
            foreach (RoomChange change in changes)
            {
                if (change.NewRoom != null && change.ChangeType == ChangeType.Add)
                {
                    newRooms.Add(change.NewRoom);
                }
                else if (change.NewRoom != null && change.ChangeType == ChangeType.Edit)
                {
                    newRooms.Add(change.NewRoom);
                }
            }
            combinedRooms.AddRange(newRooms);

            return combinedRooms;
        }

        private void UpdateRoomList()
        {
            List<Room> combinedRooms = GetCombinedRooms(existingRooms, newChanges);

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

        //private bool IsInList(string roomName)
        //{
        //    foreach (Room r in newRooms)
        //    {
        //        if (r.Name == roomName) return true;
        //    }

        //    return false;
        //}

        private void editButton_Click(object sender, EventArgs e)
        {

        }
    }
}
