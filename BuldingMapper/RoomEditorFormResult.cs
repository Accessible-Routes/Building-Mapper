﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingMapper
{
    public class RoomEditorFormResult : FormResult
    {
        public List<RoomChange> Changes { get; set; }

        public RoomEditorFormResult()
        {
            Changes = new List<RoomChange>();
        }
    }
}
