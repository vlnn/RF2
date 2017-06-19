using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RF.GUI {
    class DrawMenu {
        private const string menuKeys = "CRUD";
        private char keyPressed = '\0';
        public DrawMenu() {
            Console.WriteLine("Do you want to:\n C) Create the product\n R) Read the product\n U) Update the product\n D) Delete the product?\n");
        }
        public char Select() {
            do {
                keyPressed = Char.ToUpper(Console.ReadKey(true).KeyChar);                
            } while (! menuKeys.Contains(keyPressed));                        
            return keyPressed;
        }
        public string Action(char menu) {
            switch (menu) {
                case 'C': {
                        var created = new Antenna();
                        return "Create";
                    }
                case 'R': {
                        return "Read";
                    }
                case 'U': {
                        return "Update";
                    }
                case 'D': {
                        return "Delete";
                    }
                default: {
                        return "Should not be returned";
                    }
            }                        
        }
    }
}
