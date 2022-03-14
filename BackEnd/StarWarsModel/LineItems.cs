namespace StarWarsModel{
    public class LineItems{
        public int _productID { get; set; }
        public string _productName { get; set; }
        public float _productPrice { get; set; }
        public int _lineItemID { get; set; }
        public int _orderID { get; set; }
        public int _storeID { get; set; }
        public int _quantity { get; set; }

        public override string ToString(){
            return $"ID: {_productID}\nName: {_productName}\nPrice: ${_productPrice}\nQuantity: {_quantity}";
        }
    }
}