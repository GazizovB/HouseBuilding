using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseBuilding
{
    public class Door : IPart
    {
        public string Name { get; set; }
        public DateTime? StartWork { get; set; } = null;
        public DateTime? EndWork { get; set; } = null;
        public int Priority { get; set; }
        //public bool IsStart { get; set; } = false;
        public string Color { get; set; }
    }
}
