using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RFLibrary;
using RF;
using RF.GUI;

namespace RF {
    class Program{        
        static void Main() {
            string output = "\0";
            char keyPressed = '\0';            
            do {
                Console.Clear();
                Console.WriteLine("The RF base business layer started.");
                if (output != "\0") {
                    Console.WriteLine("Status: " + output);
                } else {
                    Console.WriteLine(output);
                }
                var drawMenu = new Menu<Frequency>();
                Console.WriteLine("Information: There are " + Warehouse<Frequency>.Count() + " antennas in the storage.\n");
                Console.WriteLine(Warehouse<Frequency>.ReadAll());
                keyPressed = drawMenu.Select();                

                output = drawMenu.Action(keyPressed);
            } while (true);            
        }
    }
}