using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RF;

namespace RFTest {
    [TestClass]
    public class LicensedTest {
        [TestMethod]
        public void Licensed() {
            var integerLicense = new Licensed(23);
            var stringLicense = new Licensed("23");
            Assert.AreEqual(integerLicense.LicenseNo, stringLicense.LicenseNo,"23");            
        }
    }
}
