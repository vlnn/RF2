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
            test.WarezFiller();
            test.WarezFiller();
            test.WarezFiller();            
            Assert.AreEqual(Warehouse.Count(), 3);
        }
    }
}
