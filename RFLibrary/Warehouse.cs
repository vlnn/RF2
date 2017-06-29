using System;
using System.Collections.Generic;
using System.Linq;

namespace RF {
    public class Warehouse<T> where T : IProducts {
        public static Queue<T> Hardware = new Queue<T>();

        public static void Push(T antenna) {
            if (Hardware.Count() >= 10) {
                throw new OutOfMemoryException("Hardware queue too long");
            }
            Hardware.Enqueue(antenna);
            if (ValidateAll()) {
                Console.WriteLine(antenna.ProductID + " has been added successfully to the warehouse.");
            } else {
                Console.WriteLine("Error: the new product can not be put in the warehouse.");
            }
        }

        public static T Pull() {
            try {
                return Hardware.Dequeue();
            } catch (InvalidOperationException) {                
                return default(T); // doing nothing, just to try/catch this exception
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