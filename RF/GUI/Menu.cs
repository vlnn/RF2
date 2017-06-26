using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RFLibrary;
using RF;

namespace RF.GUI {
    public class Menu<T>:ISearch where T : IProducts, new() {
        private const string menuKeys = "CRUDS";
        private char keyPressed = '\0';

        public Menu() {
            Console.WriteLine("\nDo you want to:\n C) Create the product\n R) Read/Validate the products\n U) Update the product\n D) Delete the product\n S) Search by city?\n");
        }

        public char Select() {
            do {
                keyPressed = Char.ToUpper(Console.ReadKey(true).KeyChar);
            } while (!menuKeys.Contains(keyPressed));
            return keyPressed;
        }

        public string Action(char menu) {
            switch (menu) {
                case 'C': {
                        var product = new Filler<T>();
                        product.WarezFiller();
                        return "The new product added to the warehouse.";
                    }
                case 'R': {
                        if (Warehouse<T>.ValidateAll()) {
                            return (Warehouse<T>.Count() + " packages were checked.");
                        } else {
                            return ("Error! Warehouse is not in order!");
                        };
                    }
                case 'U': {
                        if (Warehouse<T>.UpdateLast()) {
                            return "Update successfull.";
                        } else {
                            return "Update unsuccessfull.";
                        };
                    }
                case 'S': {
                        CitySearch();
                        return "OK";
                    }
                case 'D': {
                        if (Warehouse<T>.Count() != 0) {
                            var waste = Warehouse<T>.Pull();
                            return "One package has been removed from the warehouse.";
                        } else {
                            return "Deletion is not possible, warehouse is already empty.";
                        }
                    }
                default: {
                        return "Should not be returned";
                    }
            }
        }

        public List<string> Search(string city) {
            var result = new List<string>();
            foreach (T product in Warehouse<T>.Hardware) {
                if (product.InstallationID.Equals(city)) {
                    result.Add(product.ProductID);
                }
            }
            return result;
        }

        public void CitySearch() {
            Console.WriteLine("Please enter the city name:");
            string city = Console.ReadLine();
            var productIDs = Search(city);
            if (productIDs.Count != 0) {
                foreach (var product in productIDs) {
                    Console.WriteLine(product);
                }
                Console.ReadKey();
            }
            
        }


    }
}
