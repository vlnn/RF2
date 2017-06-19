using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RFLibrary;
using RF;

namespace RF {
    class Program {
        static void Main() {
            Console.WriteLine("The RF base business layer started.");

            var filler = new Filler();
            Warehouse Warez = filler.WarezFiller();
           
            Console.WriteLine("There are " + Warez.Count() + " antennas in the storage.");
            Console.WriteLine("The RF base business layer stopped.");
            Console.ReadKey();
        }
    }
}
