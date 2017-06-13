using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RF;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RFTest {
    [TestClass]
    public class RegionTest {
        [TestMethod]
        public void Region() {
            var area = new AreaOfRegion();
            Assert.AreEqual(area.Area(), "North");
        }          
    }
}

