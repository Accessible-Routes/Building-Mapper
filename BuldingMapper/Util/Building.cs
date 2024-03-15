using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingMapper.Util
{
    public sealed class Building
    {
        //Singleton instance code
        private Building() 
        {
            Name = string.Empty;
        }

        private static Building instance = null;

        public static Building Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Building();
                }
                return instance;
            }
        }

        public string Name { get; set; }
        public bool BuildingSaved = true;

        private List<Floor> floorList = new List<Floor>();

        public void NewBuilding(string name)
        {
            Name = name;
            floorList = new List<Floor>();
            BuildingSaved = false;
        }
        public void AddFloor(string name)
        {
            floorList.Add(new Floor(name));
            BuildingSaved = false;
        }
        public void RemoveFloor(string name)
        {
            BuildingSaved = false;
        }

        public void AddRoom(string floor, Room room) 
        {
            BuildingSaved = false;

            Floor floorObject = GetFloorObject(floor);
            
            floorObject.Rooms.Add(room);
        }

        public void EditRoom(string floor, string oldRoom, Room newRoom) 
        {
            BuildingSaved = false;

            Floor floorObject = GetFloorObject(floor);
            foreach (Room r in floorObject.Rooms)
            {
                System.Diagnostics.Debug.WriteLine(r.Name);
                if (r.Name == oldRoom)
                {
                    floorObject.Rooms.Remove(r);
                    AddRoom(floor, newRoom);
                    return;
                }
            }

            throw new ArgumentException($"Given room name \"{oldRoom}\" not found in floor {floor}");
        }

        public void RemoveRoom(string floor, string room) 
        {
            BuildingSaved = false;

            Floor floorObject = GetFloorObject(floor);
            foreach (Room r in floorObject.Rooms)
            {
                if (r.Name == room)
                {
                    floorObject.Rooms.Remove(r);
                    return;
                }
            }

            throw new ArgumentException($"Given room name \"{room}\" not found in floor {floor}");
        }

        public List<Room> GetRooms(string floor)
        {
            foreach (Floor f in floorList)
            {
                if (f.Name == floor) 
                {
                    return f.Rooms;
                }
            }

            throw new ArgumentException($"Given floor name \"{floor}\" not found in building {Name}");
        }

        public List<Floor> GetFloors()
        {
            return floorList;
        }


        private Floor GetFloorObject(string floorName)
        {
            foreach (Floor floor in floorList)
            {
                if (floor.Name == floorName)
                {
                    return floor;
                }
            }

            throw new ArgumentException($"Given floor name \"{floorName}\" not found in building {Name}");
        }
    }
}
