using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingMapper.Util
{
    public enum RoomType
    {
        Unspecified,
        Classroom,
        Office,
        Hallway,
        Bathroom
    }

    public enum AccessibilityTag
    {
        Stairs,
        Steep,
        AccessibilityButton
    }

    public class Room
    {
        public string Name { get; set; }

        public RoomType Type { get; set; }

        public List<string> ConnectedRooms { get; set; }

        public List<string> AccessibilityTags { get; set; }

        public Room()
        {
            Name = string.Empty;
            ConnectedRooms = new List<string>();
            AccessibilityTags = new List<string>();
        }
    }
}
