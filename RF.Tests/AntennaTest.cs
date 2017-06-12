using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RF;

namespace RFTest {
    [TestClass]
    public class AntennaTest {
        [TestMethod]
        public void ProductIDTest() {            
            Antenna antenna = new Antenna();
            antenna.ProductID = "firstid";            
            string expectedProductID = "firstid";            
            string actualProductID = antenna.ProductID;                        
            Assert.AreEqual(expectedProductID, actualProductID);            
        }
        [TestMethod]
        public void InstallationTypeTest() {            
            Antenna antenna = new Antenna();            
            antenna.InstallationType = (int)Antenna.installationTypes.Fixed;            
            int expectedInstallationType = (int)Antenna.installationTypes.Fixed;           
            int actualInstallationType = antenna.InstallationType;           
            Assert.AreEqual(expectedInstallationType, actualInstallationType);   
                     
            antenna.InstallationType = (int)Antenna.installationTypes.Mobile;
            expectedInstallationType = (int)Antenna.installationTypes.Mobile;
            actualInstallationType = antenna.InstallationType;
            Assert.AreEqual(expectedInstallationType, actualInstallationType);
        }
        [TestMethod]
        public void InstallTest() {
            Antenna antenna = new Antenna();
            antenna.Install();
            int expectedAction = (int)Antenna.actions.Install;
            int actualAction = (int)antenna.Action;
            Assert.AreEqual(expectedAction, actualAction);
        }
        [TestMethod]
        public void RemoveTest() {
            Antenna antenna = new Antenna();
            antenna.Remove();
            int expectedAction = (int)Antenna.actions.Remove;
            int actualAction = (int)antenna.Action;
            Assert.AreEqual(expectedAction, actualAction);
        }
        [TestMethod]
        public void MaintainTest() {
            Antenna antenna = new Antenna();
            antenna.Maintain();
            int expectedAction = (int)Antenna.actions.Maintain;
            int actualAction = (int)antenna.Action;
            Assert.AreEqual(expectedAction, actualAction);
        }
    }
}
