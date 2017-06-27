namespace RF {
    public class ReceiveTransmit : Antenna {
        public string ReceiverID { get; set; }
        public string TransmitterID { get; set; }

        public ReceiveTransmit() {
            ReceiverID = "DefaultReceiver";
            TransmitterID = "DefaultTransmitter";
        }
    }
}
