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
            string output = "\0";
            Console.WriteLine("The RF base business layer started.");
            var filler = new Filler();
            var Warez = filler.WarezFiller();            
            do {
                Console.Clear();
                if (output != "\0") {
                    Console.WriteLine("Ready: " + output);
                } else {
                    Console.WriteLine(output);
                }
                var drawMenu = new Menu();
                Console.WriteLine("State: There are " + Warez.Count() + " antennas in the storage.\n");
                Console.WriteLine(Warez.ReadAll());
                var keyPressed = drawMenu.Select();
                output = drawMenu.Action(keyPressed);                
            } while (true);
            Console.WriteLine("The RF base business layer stopped.");
        }
    }
}