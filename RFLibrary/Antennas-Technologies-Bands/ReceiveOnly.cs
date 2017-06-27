namespace RF {
    public class ReceiveOnly : Antenna {
        public string ReceiverID { get; set; }
        public string TransmitterID { get; set; } 
               
        public ReceiveOnly() {
            ReceiverID = "DefaultReceiver";            
        }
    }
}
