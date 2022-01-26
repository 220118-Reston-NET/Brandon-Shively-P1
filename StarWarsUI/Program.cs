// See https://aka.ms/new-console-template for more information
using StarWarsUI;
using StarWarsBL;
using StarWarsDL;

bool repeat = true;
AbstractMenu menu = new MainMenu();

while (repeat){
    Console.Clear();
    menu.Display();
    string _ans = menu.UserChoice();
    switch (_ans){
        case "MainMenu":
            menu = new MainMenu();
            break;
        case "AddCustomer":
            menu = new AddCustomer(new StarWarsStoreBL(new Repository()));
            break;
        case "SearchCustomer":
            break;
        case "Exit":
            Console.Clear();
            Console.WriteLine("Exited Program!");
            repeat = false;
            break;
        default:
            Console.WriteLine("Page does not exits!");
            break;
    }
}