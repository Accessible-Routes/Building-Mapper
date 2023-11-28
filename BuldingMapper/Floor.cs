using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingMapper
{
    public class Floor
    {
        public string Name { get; set; }
        public List<Room> Rooms { get; set; }

        public Floor(string name) 
        { 
            Name = name;
            Rooms = new List<Room>();
        }

        public Floor(string name, List<Room> rooms) : this(name)
        {
            this.Rooms = rooms;
        }

        public static List<Floor> ConvertToFloorObjects(List<FloorEditor> floorEditors)
        {
            List<Floor> result = new List<Floor>();

            foreach(FloorEditor f in floorEditors)
            {
                result.Add(new Floor(f.FloorName, f.Rooms));
            }

            return result;
        }
    }
}
