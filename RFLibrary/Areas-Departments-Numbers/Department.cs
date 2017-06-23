using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RF {
    public enum Cities {
        Kyiv,
        Kharkiv,
        Dnipro,
        Lviv,
        Odesa
    }

    public class Department : Region {

        public override string Area() {
            return("Main Dept");
        }
    }
}
