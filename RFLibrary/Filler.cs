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

            Antenna antenna2 = new Antenna();
            antenna2.ProductID = "0002";
            antenna2.InstallationID = "Svi002";

            Antenna antenna3 = new Antenna();
            antenna3.ProductID = "0003";
            antenna3.InstallationID = "Svi003";
            var Warez = new Warehouse();
            Warez.Add(antenna1);
            Warez.Add(antenna2);
            Warez.Add(antenna3);
            Warez.Add(antenna3);
            return Warez;
        }
    }
}
