using Microsoft.VisualStudio.TestTools.UnitTesting;
using RFLibrary;

namespace RF.Test {
    [TestClass]
    public class FillerTest {

        [TestMethod]
        public void GenerateCityCodeTest() {
            var test = new Filler<Antenna>();
            Assert.AreEqual(test.GenerateCityCode("EyJafjallajökull"),"EyJ");
        }

        [TestMethod]
        public void GenerateNumCodeTest() {
            var test = new Filler<Antenna>();
            Assert.AreEqual(test.GenerateNumCode().Length,Filler<Antenna>.codelen);            
        }
    }
}