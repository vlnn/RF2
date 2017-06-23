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
        public void ReadAll() {            
            for (int i = 1; i < repeat; i++) {
                test.WarezFiller();
            }
            Assert.AreEqual(repeat*2, Warehouse<Antenna>.ReadAll().Split('\n').Length);
        }

        [TestMethod]
        public void RemoveLast() {
            repeat = Warehouse<Antenna>.Count();
            for (int i = 1; i < repeat; i++) {
                Assert.IsTrue(Warehouse<Antenna>.RemoveLast());
            }
            Assert.IsFalse(Warehouse<Antenna>.RemoveLast());                       
        }

        [TestMethod]
        public void UpdateLast() {
            Assert.IsFalse(Warehouse<Antenna>.UpdateLast());
        }
    }
}