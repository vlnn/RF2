using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RF;

namespace RF {
    public class Warehouse {
        public static List<object> Hardware = new List<object>();
        public Warehouse() {
        }

        public void Add(Antenna antenna) {
            Hardware.Add((object)antenna);
        }

        public bool RemoveLast() {
            if (Hardware.Any()) {
                Hardware.Remove(Hardware.Last());
            } else {
                Console.WriteLine("The storage is already empty.");
                Console.ReadKey();
            }
            return (Hardware.Any());
        }

        public int Count() {
            return Hardware.Count;
        }

        public string ReadAll() {
            string ids = "";
            foreach (Antenna antenna in Hardware) {
                ids += (antenna.InstallationID + " : " + antenna.ProductID + "\n");
            }
            return ids;
        }

        public bool UpdateLast() {
            if (Hardware.Any()) {
                Antenna antenna = (Antenna)Hardware.Last();
                UpdateProduct((Antenna) antenna);
            } else {
                Console.WriteLine("Warning: No products to be updated.");
                Console.ReadKey();
                return false;
            }
            if (ValidateAll()) {
                return true;
            } else {
                RemoveLast();
                Console.WriteLine("Data is not unique, last record can not be saved and has been removed.");
                Console.ReadKey();
                return false;
            }
        }

        private void UpdateProduct(Antenna antenna) {
            Console.WriteLine("Update Installation ID (Empty string to leave as is):");
            string line = Console.ReadLine();

            if (line != String.Empty) {
                antenna.InstallationID = line;
            };
            Console.WriteLine("Update Product ID (Empty string to leave as is):");

            line = Console.ReadLine();
            if (line != String.Empty) {
                antenna.ProductID = line;
            };
        }

        public bool ValidateAll() {
            List<string> products = new List<string>();
            foreach (Antenna antenna in Hardware) {
                products.Add(antenna.ProductID);
            };
            return (products.Distinct().ToList().Count() == products.Count());
        }
    }
}