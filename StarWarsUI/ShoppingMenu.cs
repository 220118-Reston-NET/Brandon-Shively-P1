using StarWarsModel;
namespace StarWarsUI{

    public class ShoppingMenu : AbstractMenu{

        public void Display()
        {
            Console.WriteLine("Welcome "+ SearchCustomer._currentCustomer.Name);
            Console.WriteLine("You are shopping at: "+ SearchStore._currentStore.Name);
            Console.WriteLine();
            Console.WriteLine("[2] - View Products");
            Console.WriteLine("[1] - View Cart");
            Console.WriteLine("[0] - Quit shopping");
        }

        public string UserChoice(){
            string userInput = Console.ReadLine();
            switch (userInput){
                case "2":
                    Log.Information("User has selected to view the products avaliable at the "+SearchStore._currentStore.Name);
                    return "LineItems";
                case "1":
                    Log.Information("User has selected to view their shopping cart.");
                    return "Cart";
                case "0":
                    Log.Information("User has selected to return to the MainMenu.");
                    return "MainMenu";
                default:
                    Log.Information("User did not input an appropriate response.");
                    Console.WriteLine("Please input a valid response");
                    Console.WriteLine("Please press Enter to continue");
                    Console.ReadLine();
                    return "ShoppingMenu";
            }
        }
    }
}