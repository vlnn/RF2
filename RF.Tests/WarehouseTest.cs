using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RF;
using RFLibrary;

namespace RFTest {
    [TestClass]
    public class WarehouseTest {
        Filler<Antenna> test = new Filler<Antenna>();
        int repeat = 999;

        [TestMethod]
        public void ValidateAndCount() {                            
            for (int i = 0; i < repeat; i++) {
                test.WarezFiller();                
            }
            Assert.AreEqual(Warehouse<Antenna>.Count(), repeat);
        }

        [TestMethod]
        public void UpdateLast() {
            Assert.IsFalse(Warehouse<Antenna>.UpdateLast());
        }
    }
}