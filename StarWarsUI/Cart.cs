using StarWarsBL;
using StarWarsModel;

namespace StarWarsUI{
    public class ShoppingCart : AbstractMenu
    {
        private IStarWarsStoreBL _orderBL;
        public ShoppingCart(IStarWarsStoreBL n_orderBL){
            _orderBL = n_orderBL;
        }
        public float _price;
        public void Display(){
            Console.WriteLine("Welcome: "+SearchCustomer._currentCustomer.Name);
            Console.WriteLine("Your shopping cart is currently:");
            for (int i = 0; i < lineItems._currentCart.Count; i++)
            {
                Console.WriteLine("==============================");
                Console.WriteLine(lineItems._currentCart[i]);
                Console.WriteLine(lineItems._currentCartName[i]);
                Console.WriteLine("You have ordered: "+lineItems._currentCartQuantity[i]);
                _price = _price + (lineItems._currentCartPrice[i]*lineItems._currentCartQuantity[i]);
            }
            Console.WriteLine("Your cart comes to a total cost of: "+_price);
            Console.WriteLine("Please choose an option from the following");
            Console.WriteLine("[3] - Adjust Order");
            Console.WriteLine("[2] - Cancel Order");
            Console.WriteLine("[1] - Return to shopping menu");
            Console.WriteLine("[0] - Place Order");
            Console.WriteLine();
        }

        public string UserChoice()
        {
            string _userChoice = Console.ReadLine();
            switch (_userChoice)
            {
                case "3":
                Log.Information("User has selected to adjust their order.");
                Console.WriteLine("Type the ID of the Item you would like to adjust.");
                int _userChange = Convert.ToInt16(Console.ReadLine());
                for (int i = 0; i < lineItems._currentCart.Count; i++)
                {
                    if (_userChange == lineItems._currentCart[i])
                    {
                        Console.WriteLine("How many of "+lineItems._currentCartName[i]+" would you like to order?");
                        int _userQuantity = Convert.ToInt16(Console.ReadLine());
                        lineItems._currentCartQuantity[i] = _userQuantity;
                        Log.Information("User has selected to update the order for "+lineItems._currentCartName[i]+"to"+lineItems._currentCartQuantity[i]);
                    }
                }
                return "Cart";
                case "2":
                Log.Information("User has selected to completely clear their shopping cart.");
                Console.WriteLine("Your shopping cart is now empty!");
                lineItems._currentCart.Clear();
                Console.WriteLine("Press Enter to return to the Main Menu.");
                Console.ReadLine();
                return "MainMenu";
                case "1":
                Log.Information("User has selected to return to the shopping menu.");
                Console.WriteLine("Returning to the Shopping Menu");
                Console.WriteLine("Press Enter to continue");
                Console.ReadLine();
                return "ShoppingMenu";
                default: 
                Log.Information("User did not input an appropriate answer.");
                Console.WriteLine("Please input an appropriate answer");
                Console.WriteLine("Please hit enter to continue.");
                Console.ReadLine();
                return "Cart";
                case "0":
                Log.Information("User has placed an order.");
                Console.WriteLine("Your order has been placed!");
                for (int i = 0; i < lineItems._currentCart.Count; i++)
                {
                    List<StarWarsModel.ShoppingCart> _placeOrder = _orderBL.PlaceOrder(lineItems._currentCart[i], _price, lineItems._currentCartQuantity[i], SearchStore._currentStore._storeID, SearchCustomer._currentCustomer._customerID);
                }
                Log.Information("Order succesfully placed!");
                return "MainMenu";
            }
        }
    }
}