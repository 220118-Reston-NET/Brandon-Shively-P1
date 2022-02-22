using StarWarsModel;
using StarWarsBL;

namespace StarWarsUI{
    public class ReplenishInventory : AbstractMenu{
        public LineItems _replenishingItem = new LineItems();
        private IStarWarsStoreBL _lineItemsBL;
        public ReplenishInventory(IStarWarsStoreBL n_lineItemsBL){
            _lineItemsBL = n_lineItemsBL;
        }
        public void Display(){
            Console.WriteLine("Currently you are seeing the inventory of: "+ SearchStore._currentStore._storeID);
            Console.WriteLine("[2] - Select Approrpiate Store");
            Console.WriteLine($"[1] - Replenish {SearchStore._currentStore.Name} Inventory");
            Console.WriteLine("[0] - Return to Main Menu");
        }

        public string UserChoice(){
            string _userInput = Console.ReadLine();
            switch (_userInput){
                case "0":
                    Log.Information("User has selected to return to the Main Menu.");
                    return "MainMenu";
                case "1":
                    Log.Information("User has selected to replenish store inventory for "+SearchStore._currentStore.Name);
                    List<LineItems> listOfProducts = _lineItemsBL.GetAllStoreItems(SearchStore._currentStore._storeID);
                     for (int i = 1; i <= listOfProducts.Count; i++){
                        Console.WriteLine("===================");
                        Console.WriteLine($"{listOfProducts[i-1]}");
                    }
                    Console.WriteLine("Type the ID number of the Item you would like to restock");
                    Console.WriteLine("Then press Enter");
                    int _lineItemID = Convert.ToInt16(Console.ReadLine());
                    for (int i = 0; i < listOfProducts.Count; i++){
                        if (_lineItemID == listOfProducts[i]._lineItemID){
                            Console.WriteLine($"How many {listOfProducts[i]._productName} would you like to replenish?");
                            int _quantityChoice = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine($"{_quantityChoice} {listOfProducts[i]._productName} have been replenished.");
                            Log.Information($"User has selected to replenish {_quantityChoice} {listOfProducts[i]._productName} to {SearchStore._currentStore.Name}");
                            _replenishingItem._productID = listOfProducts[i]._productID;
                            _replenishingItem._productName = listOfProducts[i]._productName;
                            _replenishingItem._quantity = _quantityChoice;
                            List<LineItems> newListOfProducts = _lineItemsBL.ReplenishInventory(SearchStore._currentStore._storeID, _quantityChoice, _lineItemID);
                            for (int j = 1; j <= newListOfProducts.Count; j++){
                                Console.WriteLine("===================");
                                Console.WriteLine($"{newListOfProducts[j-1]}");
                            }
                            Console.WriteLine("Press Enter to continue");
                            Console.ReadLine();
                        }
                    }
                    
                    return "ReplenishInventory";
                case "2":
                    Log.Information("User has choosen to select a store to replenish the inventory for.");
                    Console.WriteLine("Please enter a store name");
                    string _name = Console.ReadLine();
                    List<Storefront> listOfStoresName = _lineItemsBL.SearchStoreFront(_name);
                    SearchStore._currentStore.Name = listOfStoresName[0].Name;
                    SearchStore._currentStore._storeID = listOfStoresName[0]._storeID;
                    SearchStore._currentStore.Address = listOfStoresName[0].Address;
                    Console.WriteLine(listOfStoresName[0]);
                    Log.Information("The store selected is the "+SearchStore._currentStore.Name);
                    Console.WriteLine("Please press Enter to continue");
                    Console.ReadLine();
                    Console.WriteLine("Return to Replenish Inventory Menu by pressing Enter");
                    Console.ReadLine();
                    return "ReplenishInventory";
                default:
                    Log.Information("User did not select an appropriate response.");
                    Console.WriteLine("Please input a valid response");
                    Console.WriteLine("Please press Enter to continue");
                    Console.ReadLine();
                    return "ReplenishInventory";
            }
        }
    }
}