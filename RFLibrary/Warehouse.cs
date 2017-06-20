using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RF;

namespace RF {
    public static class Warehouse {
        public static List<object> Hardware = new List<object>();        

        public static void Add(Antenna antenna) {
            Hardware.Add((object)antenna);
        }

        public static bool RemoveLast() {
            if (Hardware.Any()) {
                Hardware.Remove(Hardware.Last());
            } else {
                Console.WriteLine("The storage is already empty.");
                Console.ReadKey();
            }
            return (Hardware.Any());
        }

        public static int Count() {
            return Hardware.Count;
        }

        public static string ReadAll() {
            string ids = "";
            foreach (Antenna antenna in Hardware) {
                ids += (antenna.InstallationID + " : " + antenna.ProductID + "\n");
            }
            return ids;
        }

        public static bool UpdateLast() {
            if (Hardware.Any()) {
                Antenna antenna = (Antenna)Hardware.Last();
                UpdateProduct((Antenna) antenna);
                return true;
            } else {
                Console.WriteLine("Warning: No products to be updated.");                
                return false;
            }
       }

        private static void UpdateProduct(Antenna antenna) {
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

        public static bool ValidateAll() {
            List<string> products = new List<string>();
            foreach (Antenna antenna in Hardware) {
                products.Add(antenna.ProductID);
            };
            return (products.Distinct().ToList().Count() == products.Count());
        }
    }
}