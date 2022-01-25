using StarWarsBL;
using StarWarsModel;

namespace StarWarsUI{
    public class AddCustomer : AbstractMenu{
        private List<string> _customers = new List<string>();
        private static Customer _newCustomer = new Customer();
        private IStarWarsStoreBL _customerBL;
        public AddCustomer(IStarWarsStoreBL p_customerBL){
            _customerBL = p_customerBL;
        }
        public void Display()
        {
            Console.WriteLine("Please type the customer's name");
        }

        public string UserChoice()
        {
            string _userInput = Console.ReadLine();
            _customers.Add(_userInput);
            Console.WriteLine(_userInput+ " has been added.");
            _customerBL.AddCustomer(_newCustomer);
            Console.WriteLine("Press Enter to return to main menu.");
            Console.ReadLine();
            return "MainMenu";
        }
    }
}