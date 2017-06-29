using System;
using System.Linq;

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
            Users.UserLog.Add("user " + Users.username + " " + output);
            new Logger(Users.UserLog.Last());
            Console.WriteLine("Information: There are " + Warehouse<Frequency>.Count() + " Freqs in the storage.\n");
            try {
                output = Warehouse<Frequency>.ReadAll();
                Console.WriteLine(output);
            } catch (NullReferenceException) {
                Console.WriteLine("Nothing to output.");
            }
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
            } while (!Users.Login(log, pas));        
        }
    }
}