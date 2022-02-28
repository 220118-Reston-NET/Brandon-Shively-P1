using StarWarsModel;
using StarWarsBL;
namespace StarWarsUI{
    public class lineItems : AbstractMenu{
        public LineItems _addItem = new LineItems();
        public static List<int> _currentCart = new List<int>();
        public static List<string> _currentCartName = new List<string>();
        public static List<int> _currentCartQuantity = new List<int>();
        public static List<float> _currentCartPrice = new List<float>();
        public int _storeID = SearchStore._currentStore._storeID;
        private IStarWarsStoreBL _lineItemsBL;
        public lineItems(IStarWarsStoreBL n_lineItemsBL){
            _lineItemsBL = n_lineItemsBL;
        }
        public void Display(){
            Console.WriteLine("You are shopping at"+SearchStore._currentStore);
            List<LineItems> listOfProducts = _lineItemsBL.GetAllLineItems(_storeID);
            for (int i = 1; i <= listOfProducts.Count; i++){
                Console.WriteLine("===================");
                Console.WriteLine($"iD: {listOfProducts[i-1]._lineItemID}");
                Console.WriteLine($"Name: {listOfProducts[i-1]._productName}");
                Console.WriteLine($"Price: {listOfProducts[i-1]._productPrice}");
                Console.WriteLine($"Quantity: {listOfProducts[i-1]._quantity}");
            }
            Console.WriteLine("Please type in the ID of the item you are interested in.");
            Console.WriteLine($"[0] - Return to Store Menu");
        }

        public string UserChoice(){
            List<LineItems> listOfProducts = _lineItemsBL.GetAllLineItems(_storeID);
            int j = Convert.ToInt16(Console.ReadLine());
            for (int i = 0; i < listOfProducts.Count; i++){
                if (j == listOfProducts[i]._lineItemID){
                    Console.WriteLine($"How many {listOfProducts[i]._productName} would you like to order?");
                    int _quantityChoice = Convert.ToInt32(Console.ReadLine());
                    if(_quantityChoice <= listOfProducts[i]._quantity){
                        Console.WriteLine($"{_quantityChoice} {listOfProducts[i]._productName} have been added to your cart.");
                        Log.Information($"User has successfully added {_quantityChoice} {listOfProducts[i]._productName} to their shopping cart.");
                        _addItem._lineItemID = listOfProducts[i]._lineItemID;
                        _currentCart.Add(_addItem._lineItemID);
                        _currentCartName.Add(listOfProducts[i]._productName);
                        _currentCartQuantity.Add(_quantityChoice);
                        _currentCartPrice.Add(listOfProducts[i]._productPrice);
                        Console.WriteLine("Press Enter to continue");
                        Console.ReadLine();
                        return "ListItems";
                    }
                    else{
                        Console.WriteLine("We currently do not have that many in stock, returning to the store menu.");
                        Console.ReadLine();
                        return "ListItems";
                    }
                }
                else if(j == 0){
                    Log.Information("User has opted to return to the shopping menu without adding anything to their shopping cart.");
                    Console.WriteLine("Returning to the store Menu");
                    return "ShoppingMenu";
                }
            }
            Log.Information("User did not select an appropriate response.");
            Console.WriteLine("Please type an appropriate response.");
            Console.WriteLine("Press Enter to continue");
            Console.ReadLine();
            return "ListItems";
        }
    }
}