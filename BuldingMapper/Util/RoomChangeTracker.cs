using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingMapper.Util
{
    public class RoomChangeTracker
    {
        private List<Room> preexistingRooms;
        private List<Room> addedRooms = new List<Room>();
        private List<Room> editedRooms = new List<Room>();
        private List<Room> removedRooms = new List<Room>();

        private List<string> editedRoomNames = new List<string>();

        public RoomChangeTracker(List<Room> preexistingRooms)
        {
            this.preexistingRooms = preexistingRooms;
        }

        public List<Room> CollectRooms()
        {
            List<Room> rooms = new List<Room>();

            foreach (Room room in preexistingRooms)
            {
                if (!RoomWasEdited(room.Name) && !RoomListContainsRoom(removedRooms, room.Name))
                {
                    System.Diagnostics.Debug.WriteLine(room.Name);
                    rooms.Add(room);
                }
            }

            foreach (Room room in addedRooms)
            {
                rooms.Add(room);
            }

            foreach (Room room in editedRooms)
            {
                rooms.Add(room);
            }

            return rooms;
        }

        public void MergeRoomTracker(RoomChangeTracker toMerge)
        {
            foreach (Room room in toMerge.addedRooms)
            {
                AddRoom(room);
            }

            foreach (Room room in toMerge.editedRooms)
            {
                EditRoom(room, room.Name);
            }

            foreach (Room room in toMerge.removedRooms)
            {
                RemoveRoom(room);
            }
        }

        public bool DoesRoomExist(string roomName)
        {
            return RoomListContainsRoom(preexistingRooms, roomName)
                || RoomListContainsRoom(addedRooms, roomName)
                || RoomListContainsRoom(editedRooms, roomName);
        }

        public void AddRoom(Room addedRoom)
        {
            //If a room with the same name that we're adding already existed but was removed
            if (RoomListContainsRoom(removedRooms, addedRoom.Name))
            {
                //If this room existed before this add, this is technically an edit.
                if (RoomListContainsRoom(preexistingRooms, addedRoom.Name))
                {
                    editedRooms.Add(addedRoom);
                }
                else
                {
                    addedRooms.Add(addedRoom);
                }

                RemoveRoomFromRoomList(addedRoom.Name, removedRooms);
                return;
            }

            //No room exists with the name of this new room
            addedRooms.Add(addedRoom);
        }

        public void EditRoom(Room editedRoom, string oldName)
        {
            //If the room we want to edit has already been edited, it will be in the edited rooms list
            if (RoomListContainsRoom(editedRooms, oldName))
            {
                RemoveRoomFromRoomList(oldName, editedRooms);
                editedRooms.Add(editedRoom);
                editedRoomNames.Add(oldName);
                return;
            }

            //If the room that we want to edit has been added recently, it will be in the added rooms list
            if (RoomListContainsRoom(addedRooms, oldName))
            {
                RemoveRoomFromRoomList(oldName, addedRooms);
                addedRooms.Add(editedRoom);
                editedRoomNames.Add(oldName);
                return;
            }

            //Else, we're just editing a preexisting room
            editedRooms.Add(editedRoom);
            editedRoomNames.Add(oldName);
        }
        public void RemoveRoom(Room removedRoom)
        {
            //If the room was recently added
            if (RoomListContainsRoom(addedRooms, removedRoom.Name))
            {
                RemoveRoomFromRoomList(removedRoom.Name, addedRooms);
            }

            //If the room was edited
            if (RoomListContainsRoom(editedRooms, removedRoom.Name))
            {
                RemoveRoomFromRoomList(removedRoom.Name, editedRooms);
            }

            removedRooms.Add(removedRoom);
        }

        //TODO: Make naming scheme consistent
        private bool RoomListContainsRoom(List<Room> roomList, string room)
        {
            foreach (Room r in roomList)
            {
                if (r.Name.Equals(room)) return true;
            }

            return false;
        }

        private void RemoveRoomFromRoomList(string roomName, List<Room> roomList)
        {
            foreach (Room r in roomList)
            {
                if (r.Name.Equals(roomName))
                {
                    roomList.Remove(r);
                }
            }
        }

        private bool RoomWasEdited(string roomName)
        {
            foreach (string n in editedRoomNames)
            {
                if (n.Equals(roomName))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
