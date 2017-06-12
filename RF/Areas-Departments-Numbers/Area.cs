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
        public string Region { get; private set; }
        
        private void SetArea() {
            Region = Areas.North.ToString();
        }
    }
}
