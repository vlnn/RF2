using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RF;

namespace RFTest {
    [TestClass]
    public class AntennaTest {
        [TestMethod]
        public void ProductID() {            
            Antenna antenna = new Antenna();
            antenna.ProductID = "firstid";            
            string expectedProductID = "firstid";            
            string actualProductID = antenna.ProductID;                        
            Assert.AreEqual(expectedProductID, actualProductID);            
        }
        [TestMethod]
        public void InstallationID() {
            Antenna antenna = new Antenna();
            antenna.InstallationID = "firstid";
            string expectedInstallationID = "firstid";
            string actualInstallationID = antenna.InstallationID;
            Assert.AreEqual(expectedInstallationID, actualInstallationID);
        }
        [TestMethod]
        public void InstallationType() {            
            Antenna antenna = new Antenna();            
            antenna.InstallationType = (int)installationTypes.Fixed;            
            int expectedInstallationType = (int)installationTypes.Fixed;           
            int actualInstallationType = (int)antenna.InstallationType;           
            Assert.AreEqual(expectedInstallationType, actualInstallationType);   
                     
            antenna.InstallationType = (int)installationTypes.Mobile;
            expectedInstallationType = (int)installationTypes.Mobile;
            actualInstallationType = antenna.InstallationType;
            Assert.AreEqual(expectedInstallationType, actualInstallationType);
        }
        [TestMethod]
        public void Install() {
            Antenna antenna = new Antenna();
            antenna.Install();
            int expectedAction = (int)actions.Install;
            int actualAction = (int)antenna.Action;
            Assert.AreEqual(expectedAction, actualAction);
        }
        [TestMethod]
        public void Remove() {
            Antenna antenna = new Antenna();
            antenna.Remove();
            int expectedAction = (int)actions.Remove;
            int actualAction = (int)antenna.Action;
            Assert.AreEqual(expectedAction, actualAction);
        }
        [TestMethod]
        public void Maintain() {
            Antenna antenna = new Antenna();
            antenna.Maintain();
            int expectedAction = (int)actions.Maintain;
            int actualAction = (int)antenna.Action;
            Assert.AreEqual(expectedAction, actualAction);
        }
    }
}
