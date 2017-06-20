using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RF;
using RFLibrary;

namespace RFTest {
    [TestClass]
    public class WarehouseTest {

        [TestMethod]
        public void Count() {
            Filler test = new Filler();
            Warehouse wares = new Warehouse();
            test.WarezFiller();
            test.WarezFiller();
            test.WarezFiller();            
            Assert.AreEqual(wares.Count(), 3);
        }
    }
}
