using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RF {
    class Partner {
        private static int currentid { get; set; }
        private int partnerID { get; set; }
        private string name { get; set; }
        private string address { get; set; }

        private Partner(string name, string address) {
            currentid++;
            partnerID = currentid;
            this.name = name;
            this.address = address;
        }
    }
}
