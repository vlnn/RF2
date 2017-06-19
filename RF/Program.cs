using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RFLibrary;

namespace RF {
    class Program {
        static void Main() {
            Console.WriteLine("The RF base business layer started.");
            var antenna1 = new Antenna();
            antenna1.ProductID = "0001";
            antenna1.InstallationID = "Svi001";

            var antenna2 = new Antenna();
            antenna1.ProductID = "0002";
            antenna1.InstallationID = "Svi002";

            var antenna3 = new Antenna();
            antenna1.ProductID = "0003";
            antenna1.InstallationID = "Svi003";

            var Warez = new Warehouse();
            Warez.Add(antenna1);
            Warez.Add(antenna2);
            Warez.RemoveLast();
            Warez.Add(antenna3);

            antenna1.Install();
            antenna1.Maintain();
            antenna1.Remove();
            Console.WriteLine("There are " + Warez.Count() + " antennas in the storage.");
            Console.WriteLine("The RF base business layer stopped.");
            Console.ReadKey();
        }
    }
}
