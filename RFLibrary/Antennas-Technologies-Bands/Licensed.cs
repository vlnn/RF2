using System;

namespace RF {
    public class Licensed : ReceiveTransmit {
        public string LicenseNo { get; private set; }

        public Licensed(string licenseno) {
            LicenseNo = licenseno;
            Console.WriteLine("License number is: " + LicenseNo);            
        }

        public Licensed(int licenseno) {
            LicenseNo = licenseno.ToString();
            Console.WriteLine("License number is: " + LicenseNo);            
        }
    }
}
