using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RF;

namespace RF {
    public class Warehouse {
        public static List<string> Hardware = new List<string>();        
        public Warehouse() {            
        }        
        public void Add(Antenna antenna){
            Hardware.Add((string) antenna.ProductID);
        }
        public void RemoveLast() {
            Hardware.Remove(Hardware.Last());
        }
        public int Count() {
            return Hardware.Count;
        }
    }
}
