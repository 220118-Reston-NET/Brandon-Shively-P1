using StarWarsBL;
using StarWarsModel;

namespace StarWarsUI{
    public class SearchCustomer : AbstractMenu
    {
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
                    return "MainMenu";
                case "1":
                    Console.WriteLine("Please enter a name");
                    string name = Console.ReadLine();
                    List<Customer> listOfCustomers = _customerBL.SearchCustomer(name);
                    foreach (var item in listOfCustomers){
                        Console.WriteLine("==================");
                        Console.WriteLine(item);
                    }
                    Console.WriteLine("Please press Enter to continue");
                    Console.ReadLine();
                    return "MainMenu";
                default:
                    Console.WriteLine("Please input a valid response");
                    Console.WriteLine("Please press Enter to continue");
                    Console.ReadLine();
                    return "SearchCustomer";
            }
        }
    }
}