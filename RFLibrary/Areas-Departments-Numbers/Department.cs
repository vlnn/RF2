using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RF {
    public class Department : Region {

        public enum Cities {
            Kyiv,
            Kharkiv,
            Dnipro,
            Lviv,
            Odesa
        }

        public override string Area() {
            return("Main Dept");
        }
    }
}
