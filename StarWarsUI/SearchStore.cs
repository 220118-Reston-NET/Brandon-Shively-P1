using StarWarsBL;
using StarWarsModel;

namespace StarWarsUI{
    public class SearchStore : AbstractMenu
    {
        public static Storefront _currentStore = new Storefront();
    private IStarWarsStoreBL _storeFrontBL;
        public SearchStore(IStarWarsStoreBL n_storeFrontBL){
            _storeFrontBL = n_storeFrontBL;
        }
        public void Display(){
            Console.WriteLine("You are shooping at the: "+_currentStore.Name);
            Console.WriteLine("Choose to select a different store or proceed to shopping.");
            Console.WriteLine("[1] Search by Name");
            Console.WriteLine("[0] Proceed to shopping at this store");
        }
        public string UserChoice(){
            string userInput = Console.ReadLine();
            switch (userInput){
                case "1":
                    Log.Information("User has selected to search a store by store name.");
                    try{
                        Console.WriteLine("Please enter a name");
                        string _name = Console.ReadLine();
                        Log.Information("User is searching for a store by the name: "+_name);
                        List<Storefront> listOfStoresName = _storeFrontBL.SearchStoreFront(_name);
                        _currentStore.Name = listOfStoresName[0].Name;
                        _currentStore._storeID = listOfStoresName[0]._storeID;
                        _currentStore.Address = listOfStoresName[0].Address;
                        Console.WriteLine(listOfStoresName[0]);
                        Console.WriteLine("Please press Enter to continue");
                        Console.ReadLine();
                    }
                    catch(System.Exception){
                        Log.Information($"A store that matched the user inputed name was not found; returning user to search for a store.");
                        Console.WriteLine("A store with that name was not found.");
                        Console.WriteLine("Returning you to Search for a new store.");
                        Console.WriteLine("Please hit Enter to acknowldge this response.");
                        Console.ReadLine();
                        return "SearchStore";
                    }
                    return "ShoppingMenu";
                case "0":
                    Log.Information("User has selected to shop at the "+_currentStore.Name);
                    return "ShoppingMenu";
                default:
                    Log.Information("User did not input an appropriate response.");
                    Console.WriteLine("Please input a valid response");
                    Console.WriteLine("Please press Enter to continue");
                    Console.ReadLine();
                    return "SearchStore";
            }
        }
    }
}