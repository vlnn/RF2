using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RF;

namespace RF.GUI {
    class Password {
        private static List<char> pwd = new List<char>();
        public static string ReadPwd() {
            pwd.Clear();
            while (true) {
                ConsoleKeyInfo i = Console.ReadKey(true);
                if (i.Key == ConsoleKey.Enter) {
                    break;
                } else if ((i.Key == ConsoleKey.Backspace) && (pwd.Count != 0)) {
                    pwd.RemoveAt(pwd.Count - 1);
                    Console.Write("\b \b");
                } else {
                    pwd.Add(i.KeyChar);
                    Console.Write("*");
                }
            }
            return string.Join("", pwd.ToArray()); // RRR but list of char is not easy to convert
        }
    }
}
