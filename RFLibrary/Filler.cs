using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RF;

namespace RFLibrary {

    public class Filler {

        public Warehouse WarezFiller() {
            Antenna antenna1 = new Antenna();
            antenna1.ProductID = "0001";
            antenna1.InstallationID = "Svi001";
            
            var Warez = new Warehouse();
            Warez.Add(antenna1);
            return Warez;
        }
    }
}
