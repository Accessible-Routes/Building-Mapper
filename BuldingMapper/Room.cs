﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingMapper
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
        public String Name { get; set; }

        public RoomType Type { get; set; }

        public List<String> ConnectedRooms { get; set; }

        public List<AccessibilityTag> AccessibilityTags { get; set; }

        public Room()
        {
            Name = string.Empty;
            ConnectedRooms = new List<String>();
            AccessibilityTags = new List<AccessibilityTag>();
        }
    }
}
