using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RF;
using RFLibrary;

namespace RFLibrary {

    public class Filler<T> where T : IProducts, new() {
        
        public const int codelen = 3;
        private Random random = new Random(Guid.NewGuid().GetHashCode());

        public void WarezFiller() {
            Array cities = Enum.GetValues(typeof(Cities));            
            string city = cities.GetValue(random.Next(cities.Length)).ToString();
            string citycode = GenerateCityCode(city);
            string numcode = GenerateNumCode();
            var antenna = new T();
            antenna.ProductID = (citycode + numcode).ToUpper();
            antenna.InstallationID = city;            
            Warehouse<T>.Push(antenna);            
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
