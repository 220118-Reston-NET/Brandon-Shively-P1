namespace StarWarsModel{
    public class Storefront{
        private string _name;
        public string Name { get; set; }
        private string _address;
        public string Address { get; set; }

        public Storefront(){
            Name = "Star Wars Store";
            Address = "This is storefront street";

        }
    }
}