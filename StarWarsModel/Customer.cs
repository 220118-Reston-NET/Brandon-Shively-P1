namespace StarWarsModel{
    public class Customer
    {
        private string _name;
        public string Name { get; set; }
        private string _address;
        public string Address { get; set; }
        private string _number;
        public string Number { get; set; }
        public Customer(){
            Name = "Brandon";
            Address = "Dolphin Way";
            Number = "888-888-8888";
        }
    }
}