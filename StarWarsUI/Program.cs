global using Serilog;
// See https://aka.ms/new-console-template for more information
using Microsoft.Extensions.Configuration;
using StarWarsUI;
using StarWarsBL;
using StarWarsDL;

var configuration = new ConfigurationBuilder()
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json")
    .Build();

string _connectionStrings = configuration.GetConnectionString("Reference2DB");

Log.Logger = new LoggerConfiguration()
    .WriteTo.File("./logs/user.txt")
    .CreateLogger();

bool repeat = true;
AbstractMenu menu = new MainMenu();

while (repeat){
    Console.Clear();
    menu.Display();
    string _ans = menu.UserChoice();
    switch (_ans){
        case "LineItems":
            Log.Information($"Displaying Products avaliable for purchase at the {SearchStore._currentStore.Name}.");
            menu = new lineItems(new StarWarsStoreBL(new SQLRepository(_connectionStrings)));
            break;
        case "ShoppingMenu":
            Log.Information($"Displaying the Menu for shopping at the {SearchStore._currentStore.Name}.");
            menu = new ShoppingMenu();
            break;
        case "SelectStore":
            Log.Information("Displaying the Store Selection Screen.");
            menu = new SearchStore(new StarWarsStoreBL(new SQLRepository(_connectionStrings)));
            break;
        case "MainMenu":
            Log.Information("Displaying the MainMenu to user.");
            menu = new MainMenu();
            break;
        case "AddCustomer":
            Log.Information("Displaying the AddCustomer Menu to user.");
            menu = new AddCustomer(new StarWarsStoreBL(new SQLRepository(_connectionStrings)));
            break;
        case "SearchCustomer":
            Log.Information("Displaying the SearchCustomer Menu to user.");
            menu = new SearchCustomer(new StarWarsStoreBL(new SQLRepository(_connectionStrings)));
            break;
        case "Cart":
            Log.Information($"Displaying the shopping cart for {SearchCustomer._currentCustomer.Name}.");
            menu = new ShoppingCart(new StarWarsStoreBL(new SQLRepository(_connectionStrings)));
            break;
        case "ReplenishInventory":
            Log.Information("Displaying the ReplenishInventory Menu to user.");
            menu = new ReplenishInventory(new StarWarsStoreBL(new SQLRepository(_connectionStrings)));
            break;
        case "Exit":
            Log.Information("Exiting Application.");
            Console.Clear();
            Console.WriteLine("Exited Program!");
            repeat = false;
            break;
        case "OrderHistory":
            Log.Information("Displaying the OrderHistory menu to user.");
            menu = new OrderHistory(new StarWarsStoreBL(new SQLRepository(_connectionStrings)));
            break;
        default:
            Log.Information("User selected an option the returned no page.");
            Console.WriteLine("Page does not exits!");
            break;
    }
}