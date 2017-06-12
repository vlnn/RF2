﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RF {    
    public class Antenna {
        public enum installationTypes {
            Mobile,
            Fixed,            
        }

        public enum actions {                    
            Install,
            Remove,
            Maintain,
        }

        public string ProductID { get;  set; }
        public string AntennaID { get; set; }
        public int InstallationType { get;  set; }

        public int Action { get; set; }

        public void Install() {
            if (Action != (int) actions.Install) {
                Action = (int) actions.Install;
            } else {
                Action = (int) actions.Maintain;
            }
        }
        
        public void Remove() {
            if (Action != (int) actions.Remove) {
                Action = (int) actions.Remove;
            } else {
                Action = (int)actions.Maintain;
            }
        }
        public void Maintain() {
            if (Action != (int) actions.Maintain) {
                Action = (int)actions.Remove;
            } else {
                Console.WriteLine(AntennaID + " is already in the maintenance mode.");
            }
        }
    }
    
}
