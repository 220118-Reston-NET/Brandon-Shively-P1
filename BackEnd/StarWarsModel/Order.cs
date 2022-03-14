namespace StarWarsModel{
    public class Order{
        public string _storeName { get; set; }
        public string _productName { get; set; }
        public string _customerName { get; set; }
        public int _quantity { get; set; }
        public int _customerID { get; set; }
        public int _orderID { get; set; }
        public int _lineItemID { get; set; }
        public int _storeID { get; set; }
        public int _totalPrice { get; set; }
        public DateTime _date { get; set; }
    }
}