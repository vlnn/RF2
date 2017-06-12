using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RF;

namespace RFTest {
    [TestClass]
    public class ReceiveOnlyTest {
        [TestMethod]
        public void ReceiveOnly() {
            var antenna = new ReceiveOnly();
            Assert.AreEqual(antenna.ReceiverID, "DefaultReceiver");
            Assert.AreEqual(antenna.TransmitterID, null);
        }
    }
}
