using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RF;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RFTest {
    [TestClass]
    public class DepartmentTest {
        [TestMethod]
        public void Department() {
            var dept = new Department();
            Assert.AreEqual(dept.Area(), "Main Dept");
        }
    }
}