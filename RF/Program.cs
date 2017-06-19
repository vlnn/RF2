using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RFLibrary;
using RF;
using RF.GUI;

namespace RF {
    class Program {
        static void Main() {
            Console.WriteLine("The RF base business layer started.");

            var filler = new Filler();
            var Warez = filler.WarezFiller();

            Console.WriteLine("There are " + Warez.Count() + " antennas in the storage.");

            var drawMenu = new DrawMenu();
            var keyPressed = drawMenu.Select();

            var output = drawMenu.Action(keyPressed);

            Console.WriteLine(output);
            Console.WriteLine("The RF base business layer stopped.");
            Console.ReadKey();
        }
    }
}