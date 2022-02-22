using StarWarsModel;
using StarWarsBL;

namespace StarWarsUI{
    public class OrderHistory : AbstractMenu
    {
        private IStarWarsStoreBL _orderHistoryBL;
        public OrderHistory(IStarWarsStoreBL n_orderHistoryBL){
            _orderHistoryBL = n_orderHistoryBL;
        }
        public void Display()
        {
            Console.WriteLine("Please select from the following menu.");
            Console.WriteLine("[2] - Search a customer order history.");
            Console.WriteLine("[1] - Search a store order history.");
            Console.WriteLine("[0] - Return to the Main Menu.");
        }

        public string UserChoice()
        {
            string _userInput = Console.ReadLine();
            switch (_userInput)
            {
                case "1":
                    Log.Information("User has selected to view the store order history for "+SearchStore._currentStore.Name);
                    List<Order> _storeOrder = _orderHistoryBL.StoreOrder(SearchStore._currentStore._storeID);
                    foreach (var item in _storeOrder)
                    {
                        Console.WriteLine("=======================");
                        Console.WriteLine($"The Order ID is: {item._orderID}");
                        Console.WriteLine($"The Customer who ordered this is: {item._customerName}");
                        Console.WriteLine($"The Product ordered was: {item._productName}");
                        Console.WriteLine($"The line item ID of the product is: {item._lineItemID}");
                        Console.WriteLine($"The total quantity order was: {item._quantity}");
                        Console.WriteLine($"The total price of the order is: {item._totalPrice}");
                    }
                    Console.ReadLine();
                    return "OrderHistory";
                case "2":
                    Log.Information("User has selected to view a customer's order history.  The customer choosen is: "+SearchCustomer._currentCustomer.Name);
                    List<StarWarsModel.Order> _customerOrder = _orderHistoryBL.CustomerOrder(SearchCustomer._currentCustomer._customerID);
                    foreach (var item in _customerOrder)
                    {
                        Console.WriteLine("=========================");
                        Console.WriteLine($"The Order ID is: {item._orderID}");
                        Console.WriteLine($"The Store the order was placed at is: {item._storeName}");
                        Console.WriteLine($"The Product ordered was: {item._productName}");
                        Console.WriteLine($"The Total Quantity of this product ordered was: {item._quantity}");
                        Console.WriteLine($"The Total cost of this order is: {item._totalPrice}");
                    }
                    Console.ReadLine();
                    return "OrderHistory";
                case "0":
                    Log.Information("User has selected to return to the MainMenu.");
                    Console.WriteLine("Returning to the Main Menu.");
                    Console.WriteLine("Hit Enter to continue.");
                    Console.ReadLine();
                    return "MainMenu";
                default:
                    Log.Information("User did not input a valid response.");
                    Console.WriteLine("Please input a valid response.");
                    Console.WriteLine("Hit Enter to continue.");
                    Console.ReadLine();
                    return "OrderHistory";
            }
        }
    }
}