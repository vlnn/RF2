using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFLibrary {
    public static class Users {
        private static Dictionary<string, string> passwd = new Dictionary<string, string>
{
    { "vlnn", "password1" },
    { "elp",  "password2" }
};
        public static bool Login(string login, string password) {
            return !passwd.TryGetValue(login, out password);
        }
    }
}
