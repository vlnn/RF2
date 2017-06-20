using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RF;
using RFLibrary;

namespace RFLibrary {

    public class Filler {
        
        public const int codelen = 3;
        public Random random = new Random();
    
        public Warehouse WarezFiller() {
            Array cities = Enum.GetValues(typeof(Department.Cities));
            string city = cities.GetValue(random.Next(cities.Length)).ToString();
            string citycode = GenerateCityCode(city);
            string numcode = GenerateNumCode();
            var antenna = new Antenna();
            antenna.ProductID = (citycode + numcode).ToUpper();
            antenna.InstallationID = city;
            var warez = new Warehouse();            
            warez.Add(antenna);
            return warez;
        }

        public string GenerateCityCode(string city) {
            return (city.Substring(0, codelen));
        }

        public string GenerateNumCode() {
            const string chars = "0123456789";
            return (new string(Enumerable.Repeat(chars, codelen).Select(s => s[random.Next(s.Length)]).ToArray()));
        }
    }
}
