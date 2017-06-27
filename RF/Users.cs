using System;
using System.Collections.Generic;
using RF;
using RF.GUI;
using RFLibrary;


namespace RF.GUI {
    public static class Users {        
        public static string username { get; private set; }
        public static List<string> UserLog = new List<string>();
        private static Dictionary<string, string> passwd = new Dictionary<string, string>()
{
    { "vlnn", "password1" },
    { "elp",  "password2" }
};
        public static bool Login(string login, string password) {
            string testPassword = string.Empty;
            username = login;
            bool loggedin = (passwd.TryGetValue(login, out testPassword))&&((testPassword.Equals(password)));
            if (!loggedin){
                string output = "Not authorized: tried " + login + " : " + password;
                new Logger(output);
                Console.WriteLine(output);
            }
            return loggedin;
        }
    }
}