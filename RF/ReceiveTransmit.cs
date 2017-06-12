using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RF {
    public class ReceiveTransmit : Antenna {
        public string ReceiverID { get; set; }
        public string TransmitterID { get; set; }

        public ReceiveTransmit() {
            ReceiverID = "DefaultReceiver";
            TransmitterID = "DefaultTransmitter";
        }
    }
}
