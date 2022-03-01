namespace StarWarsModel{
    public class Storefront{
        public int _storeID { get; set; }
        private string _name;
        public string Name { get; set; }
        private string _address;
        public string Address { get; set; }
        public int ManagerID { get; set; }

        public override string ToString(){
            return $"StoreID: {_storeID}\nName: {Name}\nAddress: {Address}";
        }

    }
}