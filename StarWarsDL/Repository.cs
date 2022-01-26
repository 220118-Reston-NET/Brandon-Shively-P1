using System.Text.Json;
using StarWarsModel;

namespace StarWarsDL{
    public class Repository : IRepository{
        private string _filepath = "../StarWarsDL/Database/";
        private string _jsonString;
        public Customer AddCustomer(Customer n_customer){
            string path = _filepath + "Customer.json";
            List<Customer> ListOfCustomers = GetAllCustomers();
            ListOfCustomers.Add(n_customer);
            _jsonString = JsonSerializer.Serialize(ListOfCustomers, new JsonSerializerOptions {WriteIndented = true});
            File.WriteAllText(path , _jsonString);
            return n_customer;
        }

        public List<Customer> GetAllCustomers()
        {
            _jsonString = File.ReadAllText(_filepath+"Customer.json");
            return JsonSerializer.Deserialize<List<Customer>>(_jsonString);
        }
    }
}