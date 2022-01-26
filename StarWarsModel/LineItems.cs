namespace StarWarsModel{
    public class LineItem{
        private string _name;
        public string Name { get; set; }
        private string _price;
        public string Price { get; set; }
        public List<string[]> LineItems = new List<string[]>();
    }
}