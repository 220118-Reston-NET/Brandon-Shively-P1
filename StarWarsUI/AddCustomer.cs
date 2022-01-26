using StarWarsBL;
using StarWarsModel;

namespace StarWarsUI{
    public class AddCustomer : AbstractMenu{
        private List<string> _customers = new List<string>();
        private static Customer _newCustomer = new Customer();
        private IStarWarsStoreBL _customerBL;
        public AddCustomer(IStarWarsStoreBL n_customerBL){
            _customerBL = n_customerBL;
        }
        public void Display()
        {
            Console.WriteLine("Enter Customer information");
            Console.WriteLine("[6] Name - " + _newCustomer.Name);
            Console.WriteLine("[5] Address - " + _newCustomer.Address);
            Console.WriteLine("[4] Phone Number - "+_newCustomer.Number);
            Console.WriteLine("[3] Email - " + _newCustomer.Email);
            // add list of orders once orders is created
            Console.WriteLine("[1] Save");
            Console.WriteLine("[0] Go Back");
        }

        public string UserChoice()
        {
            string _userInput = Console.ReadLine();
            switch (_userInput){
                case "0":
                    return "MainMenu";
                case "1":
                    _customerBL.AddCustomer(_newCustomer);
                    return "MainMenu";
                case "3":
                    Console.WriteLine("Please enter email address");
                    _newCustomer.Email = Console.ReadLine();
                    return "AddCustomer";
                case "4":
                    Console.WriteLine("Please enter a phone number");
                    _newCustomer.Number = Console.ReadLine();
                    return "AddCustomer";
                case "5":
                    Console.WriteLine("Please enter an address");
                    _newCustomer.Address = Console.ReadLine();
                    return "AddCustomer";
                case "6":
                    Console.WriteLine("Please enter a name");
                    _newCustomer.Name = Console.ReadLine();
                    return "AddCustomer";
                default:
                    Console.WriteLine("Please input a valid response");
                    Console.WriteLine("Please press Enter to continue");
                    Console.ReadLine();
                    return "AddCustomer";
            }
            _customers.Add(_userInput);
            Console.WriteLine(_newCustomer.Name+ " has been added.");
            _customerBL.AddCustomer(_newCustomer);
            Console.WriteLine("Press Enter to return to main menu.");
            Console.ReadLine();
            return "MainMenu";
        }
    }
}