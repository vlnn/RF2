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
        public Partner(string _name, string _address) {
            currentid++;
            partnerID = currentid;
            name = _name;
            address = _address;
        }
    }
}
