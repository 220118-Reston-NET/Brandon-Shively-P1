namespace StarWarsModel{
    public class Customer{
        private string _name;
        public string Name { get; set; }
        private string _address;
        public string Address { get; set; }
        private string _number;
        public string Number { get; set; }
        private string _email;
        public string Email { get; set; }

        public override string ToString(){
            return $"Name: {Name}\nAddress: {Address}\nNumber: {Number}\nEmail: {Email}";
        }
    }
}