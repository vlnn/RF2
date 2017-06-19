using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RF;
using RFLibrary;

namespace RFLibrary {

    public class Filler {
        const int codelen = 3;
        public Warehouse WarezFiller() {

            var cities = Enum.GetValues(typeof(Department.Cities));
            var random = new Random();
            string city = cities.GetValue(random.Next(cities.Length)).ToString();
            string citycode = city.Substring(0, codelen);
            random = new Random();
            const string chars = "0123456789";
            string numcode = new string(Enumerable.Repeat(chars, codelen).Select(s => s[random.Next(s.Length)]).ToArray());

            var antenna = new Antenna();
            antenna.ProductID = citycode + numcode;
            antenna.InstallationID = city; 

            var Warez = new Warehouse();
            Warez.Add(antenna);
            return Warez;
        }
    }
}
