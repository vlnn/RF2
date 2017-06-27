namespace RF {
    class Partner {
        public static int currentid { get; set; }
        private int partnerID { get; set; }
        private string name { get; set; }
        private string address { get; set; }

        private Partner(string name, string address) {
            currentid++;
            partnerID = currentid;
            this.name = name;
            this.address = address;
        }
    }
}
