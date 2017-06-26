using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RFLibrary;
using RF;
using RF.GUI;

namespace RF {

    public class Program {
        public static void Main() {
        string output = string.Empty;
        char keyPressed = '\0';
            LogUsersIn();
            Console.WriteLine("The RF base business layer started.");
            do {
                Console.Clear();
                OutputStatus(output);
                var drawMenu = new Menu<Frequency>();
                OutputMenu(output);
                keyPressed = drawMenu.Select();                
                output = drawMenu.Action(keyPressed);
            } while (true);
        }

        private static void OutputMenu(string output) {
            Users.UserLog.Add(DateTime.Now + ": user " + Users.username + output);
            Console.WriteLine("Information: There are " + Warehouse<Frequency>.Count() + " Freqs in the storage.\n");
            Console.WriteLine(Warehouse<Frequency>.ReadAll());            
        }

        private static void OutputStatus(string output) {            
            if (output != "\0") {
                Console.WriteLine("Status: " + output);
            } else {
                Console.WriteLine(output);
            }
        }

        static void LogUsersIn() {
            string log = null;
            string pas = null;
            do {
                Console.Write("Login: ");
                log = Console.ReadLine();
                Console.Write("Password: ");
                pas = Password.ReadPwd();
                Console.WriteLine();
            } while (Users.Login(log, pas));        
        }
    }
}