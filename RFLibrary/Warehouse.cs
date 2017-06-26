using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RF;
using RFLibrary;

namespace RF {
    public class Warehouse<T> where T : IProducts {
        public static Queue<T> Hardware = new Queue<T>();        

        public static void Push(T antenna) {            
            Hardware.Enqueue(antenna);
            if (ValidateAll()) {
                Console.WriteLine("Added successfully.");
            } else {
                Console.WriteLine("Error: the new product can not be put in the warehouse.");
            }
        }

        public static T Pull() {
            if (Hardware.Any()) {
                return Hardware.Dequeue();
            } else {
                Console.WriteLine("The storage is already empty.");                
                return default(T);
            }            
        }

        public static int Count() {
            return Hardware.Count;
        }

        public static string ReadAll() {
            string ids = string.Empty;
            foreach (T antenna in Hardware) {
                ids += (antenna.InstallationID + " : " + antenna.ProductID + "\n");
            }
            return ids;
        }

        public static bool UpdateLast() {
            if (Hardware.Any()) {
                var copy = Pull();                                                            
                UpdateProduct(copy);
                if (ValidateAll()) {
                    Push(copy);
                    return true;
                } else {
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
            return Hardware.Distinct().Count() == Hardware.Count();
        }
    }
}