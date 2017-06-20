using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RF;
using RFLibrary;

namespace RFTest {
    [TestClass]
    public class WarehouseTest {
        Filler test = new Filler();
        int repeat = 999;

        [TestMethod]
        public void ValidateAndCount() {                            
            for (int i = 0; i < repeat; i++) {
                test.WarezFiller();                
            }
            Assert.AreEqual(Warehouse.Count(), repeat);
        }

        [TestMethod]
        public void ReadAll() {            
            for (int i = 1; i < repeat; i++) {
                test.WarezFiller();
            }
            Assert.AreEqual(repeat*2, Warehouse.ReadAll().Split('\n').Length);
        }

        [TestMethod]
        public void RemoveLast() {
            repeat = Warehouse.Count();
            for (int i = 1; i < repeat; i++) {
                Assert.IsTrue(Warehouse.RemoveLast());
            }
            Assert.IsFalse(Warehouse.RemoveLast());                       
        }

        [TestMethod]
        public void UpdateLast() {
            Assert.IsFalse(Warehouse.UpdateLast());
        }
    }
}