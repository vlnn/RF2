using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RF;
using RFLibrary;

namespace RF {
    public static class Warehouse<T> where T : IProducts {
        public static List<T> Hardware = new List<T>();        

        public static void Add(T antenna) {
            Hardware.Add(antenna);
            if (ValidateAll()) {
                Console.WriteLine("Added successfully.");
            } else {
                Console.WriteLine("Error: the new product can not be put in the warehouse.");
            }
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
            foreach (T antenna in Hardware) {
                ids += (antenna.InstallationID + " : " + antenna.ProductID + "\n");
            }
            return ids;
        }

        public static bool UpdateLast() {
            if (Hardware.Any()) {
                T antenna = Hardware.Last();
                var copy = antenna;                
                                              
                UpdateProduct((T) antenna);
                if (ValidateAll()) {
                    return true;
                } else {
                    Hardware.Add(copy);
                    return false;
                }
            } else {
                Console.WriteLine("Warning: No products to be updated.");                
                return false;
            }
       }

        private static void UpdateProduct(T antenna) {
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
            bool flag = false;
            T updatedProduct = (T) Hardware.Last();
            Hardware.Remove(Hardware.Last());
            foreach (T product in Hardware) {
                flag = flag | ((product.InstallationID == updatedProduct.InstallationID) && (product.ProductID == updatedProduct.ProductID));
            }
            if (!flag) {
                Hardware.Add(updatedProduct);
            }
            return !flag;
        }
    }
}