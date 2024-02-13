using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingMapper.FormResults
{
    public class NewBuildingFormResult : FormResult
    {
        public NewBuildingFormResult()
        {
            BuildingName = string.Empty;
            FloorName = string.Empty;
            Filepath = string.Empty;
        }


        public DialogResult Result { get; set; }

        public string BuildingName { get; set; }

        public string FloorName { get; set; }

        public string Filepath { get; set; }
    }
}
