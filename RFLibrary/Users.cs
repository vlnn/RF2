using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFLibrary {
    public static class Users {        
        public static string username { get; private set; }
        public static List<string> UserLog = new List<string>();
        private static Dictionary<string, string> passwd = new Dictionary<string, string>()
{
    { "vlnn", "password1" },
    { "elp",  "password2" }
};
        public static bool Login(string login, string password) {
            username = login;
            return !passwd.TryGetValue(login, out password);
        }
    }
}
