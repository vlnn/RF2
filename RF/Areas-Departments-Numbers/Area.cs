using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RF;

namespace RF {
    public class Area {
        enum Areas {
            North,
            East,
            South,
            West
        }
        public int Region { get; private set; }
        
        public void Area(Areas area) {
            Area = Area.area;
        }
    }
}
