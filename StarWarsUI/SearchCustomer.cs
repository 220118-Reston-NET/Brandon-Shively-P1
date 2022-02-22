using StarWarsBL;
using StarWarsModel;

namespace StarWarsUI{
    public class SearchCustomer : AbstractMenu
    {
        public static Customer _currentCustomer = new Customer();
        private IStarWarsStoreBL _customerBL;
        public SearchCustomer(IStarWarsStoreBL n_customerBL){
            _customerBL = n_customerBL;
        }
        public void Display()
        {
            Console.WriteLine("Please select how you would like to search for a customer");
            Console.WriteLine("[1] Search by name");
            Console.WriteLine("[0] Go back to Main Menu");
        }
        public string UserChoice()
        {
            string userInput = Console.ReadLine();
            switch (userInput){
                case "0":
                    Log.Information("User has selected to return to the MainMenu.");
                    return "MainMenu";
                case "1":
                    Log.Information("User has selected to search a customer by name.");
                    try{
                        Console.WriteLine("Please enter a name");
                        string name = Console.ReadLine();
                        Log.Information("User is searching for a customer by the name: "+name);
                        List<Customer> listOfCustomers = _customerBL.SearchCustomer(name);
                        foreach (var item in listOfCustomers){
                            Console.WriteLine("==================");
                            Console.WriteLine(item);
                        }
                        _currentCustomer._customerID = listOfCustomers[0]._customerID;
                        _currentCustomer.Name = listOfCustomers[0].Name;
                        _currentCustomer.Address = listOfCustomers[0].Address;
                        _currentCustomer.Number = listOfCustomers[0].Number;
                        _currentCustomer.Email = listOfCustomers[0].Email;
                        Log.Information(_currentCustomer.Name+" successfully found in database.");
                        Console.WriteLine("Please press Enter to continue");
                        Console.ReadLine();
                    }
                    catch (System.Exception){
                        Log.Information("A customer matching the user inputed response was not found; returning user to SearchCustomer Menu.");
                        Console.WriteLine("Customer was not located.");
                        Console.WriteLine("Returning you to the Search Customer Menu.");
                        Console.WriteLine("Please hit Enter to acknowledge this response.");
                        Console.ReadLine();
                        return "SearchCustomer";
                    }
                    return "MainMenu";
                default:
                    Log.Information("User did not input a valid response.");
                    Console.WriteLine("Please input a valid response");
                    Console.WriteLine("Please press Enter to continue");
                    Console.ReadLine();
                    return "SearchCustomer";
            }
        }
    }
}