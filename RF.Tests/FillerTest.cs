using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RF;
using RFLibrary;

namespace RF.Test {
    [TestClass]
    public class FillerTest {

        [TestMethod]
        public void GenerateCityCodeTest() {
            var test = new Filler();
            Assert.AreEqual(test.GenerateCityCode("EyJafjallajökull"),"EyJ");
        }

        [TestMethod]
        public void GenerateNumCodeTest() {
            var test = new Filler();
            Assert.AreEqual(test.GenerateNumCode().Length,3);            
        }
    }
}