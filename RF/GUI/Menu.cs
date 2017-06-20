using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RFLibrary;
using RF;

namespace RF.GUI {
    class Menu {
        private const string menuKeys = "CRUD";
        private char keyPressed = '\0';
        public Menu() {
            Console.WriteLine("\nDo you want to:\n C) Create the product\n R) Read/Validate the products\n U) Update the product\n D) Delete the product?\n");
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
                        var product = new Filler();
                        product.WarezFiller();
                        return "The new product added to the warehouse.";
                    }
                case 'R': {
                        var warez = new Warehouse();
                        if (warez.ValidateAll()) {
                            return ( warez.Count() + " packages were checked.");
                        } else {
                            return ("Error! Warehouse is not in order!");
                        }                        
                    }
                case 'U': {
                        return "Update";
                    }
                case 'D': {
                        var warez = new Warehouse();
                        warez.RemoveLast();
                        return "One package has been removed from the warehouse.";
                    }
                default: {
                        return "Should not be returned";
                    }
            }                        
        }
    }
}
