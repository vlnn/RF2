using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RF;

namespace RF {
    enum Areas {
        North,
        East,
        South,
        West
    }

    public class AreaOfRegion : Region {    

        public override string Area() {
            return Areas.North.ToString();
        }
    }
}
