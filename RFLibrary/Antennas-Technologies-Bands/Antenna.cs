using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace RF {
    public enum installationTypes {
        Mobile,
        Fixed,
    }

    public enum actions {
        None,
        Install,
        Remove,
        Maintain,
    }

    [Serializable()]
    public class Antenna : IProducts {

        public string ProductID { get; set; }
        public string InstallationID { get; set; }
        public int InstallationType { get; set; }
        public int Action { get; set; }

        public void Install() {
            if (Action != (int)actions.Install) {
                Action = (int)actions.Install;
            } else {
                Action = (int)actions.Maintain;
            }
        }

        public void Remove() {
            if (Action != (int)actions.Remove) {
                Action = (int)actions.Remove;
            } else {
                Action = (int)actions.Maintain;
            }
        }

        public static Antenna Copy<Antenna>(Antenna other) {
            using (MemoryStream ms = new MemoryStream()) {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(ms, other);
                ms.Position = 0;
                return (Antenna) formatter.Deserialize(ms);
            }
        }

        public void Maintain() {
            if (Action == (int)actions.Maintain) {
                Console.WriteLine(InstallationID + " is already in the maintenance mode.");
                Action = (int)actions.Remove;
            } else {
                Action = (int)actions.Maintain;
            }
        }
    }
}
