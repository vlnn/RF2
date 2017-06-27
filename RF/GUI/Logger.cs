using System.IO;
using System.Reflection;
using System;

namespace RF {
    public class Logger {
        private string path = string.Empty;
        public Logger(string logMessage) {
            LogWrite(logMessage);
        }

        public void LogWrite(string logMessage) {
            path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            try {
                using (StreamWriter w = File.AppendText(path + "\\" + "log.txt")) {
                    Log(logMessage, w);
                }
            } catch (Exception ex) {
                Console.WriteLine("Logging is not successfull: "+ ex);
            }
        }

        public void Log(string logMessage, TextWriter txtWriter) {
            try {                
                txtWriter.WriteLine("{0} {1}", DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());                
                txtWriter.WriteLine(logMessage);
                txtWriter.WriteLine("-------------------------------");
            } catch (Exception ex) {
                Console.WriteLine("txtWriter is malfunction:" + ex);
            }
        }
    }
}