using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RF {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("The RF base business layer started.");
            var antenna1 = new Antenna();
            antenna1.ProductID = "0001";
            antenna1.InstallationID = "Svi001";
            antenna1.Install();
            antenna1.Maintain();
            antenna1.Remove();
            Console.WriteLine("The RF base business layer stopped.");
        }
    }
}
