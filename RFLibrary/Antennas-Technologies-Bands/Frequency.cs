using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RF {
    public class Frequency : ReceiveOnly {
        public string Band { get; set; }

        public Frequency(int frequency) {
            if (frequency < 12) {
                Band = "Low" ;
            } else {
                Band = "High";
            }            
        }
    }
}