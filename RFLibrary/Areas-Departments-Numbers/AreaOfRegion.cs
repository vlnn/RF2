using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RF;

namespace RF {
    public class AreaOfRegion : Region {
        enum Areas {
            North,
            East,
            South,
            West
        }        

        public override string Area() {
            return Areas.North.ToString();
        }
    }
}
