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
    }
}
