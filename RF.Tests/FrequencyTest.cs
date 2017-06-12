using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RF;

namespace RFTest {
    [TestClass]
    public class FrequencyTest {
        [TestMethod]
        protected void Frequency() {
            var antenna = new  Frequency(13);
            Assert.AreEqual(antenna.ReceiverID, "DefaultReceiver");
            Assert.AreEqual(antenna.TransmitterID, null);
            Assert.AreEqual(antenna.Band, "High");
        }
    }
}