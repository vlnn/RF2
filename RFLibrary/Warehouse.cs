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
        public void RemoveLast() {
            Hardware.Remove(Hardware.Last());
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
        public bool ValidateAll() {            
            List<string> products = new List<string>();
            foreach (Antenna antenna in Hardware) {                
                products.Add(antenna.ProductID);
            };
            return (products.Distinct().ToList().Count() == products.Count());
        }
    }
}    