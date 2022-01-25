namespace StarWarsUI{
    public class MainMenu : AbstractMenu{
        public void Display()
        {
            //print the menu
            Console.WriteLine("[6] - Add new customer");
            Console.WriteLine("[5] - Search for customer");
            Console.WriteLine("[4] - View Products");
            Console.WriteLine("[3] - Place Order");
            Console.WriteLine("[2] - Order History");
            Console.WriteLine("[1] - Replenish Inventory");
            Console.WriteLine("[0] - Exit");
        }

        public string UserChoice(){
            string _userInput = Console.ReadLine();
            switch (_userInput){
                case "0":
                    return "Exit";
                case "1":
                    return "ReplenishInventory";
                case "2":
                    return "OrderHistory";
                case "3":
                    return "PlaceOrder";
                case "4":
                    return "ViewProducts";
                case "5":
                    return "SearchCustomer";
                case "6":
                    return "AddCustomer";
                default:
                    Console.WriteLine("Please input a valid response");
                    Console.WriteLine("Please press Enter to continue");
                    Console.ReadLine();
                    return "MainMenu";
            }
        }
    }
}