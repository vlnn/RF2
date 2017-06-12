using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RF;

namespace RFTest {
    [TestClass]
    public class ReceiveTransmitTest {
        [TestMethod]
        public void ReceiveTransmit() {
            var antenna = new ReceiveTransmit();
            Assert.AreEqual(antenna.ReceiverID, "DefaultReceiver");
            Assert.AreEqual(antenna.TransmitterID, "DefaultTransmitter");
        }
    }
}