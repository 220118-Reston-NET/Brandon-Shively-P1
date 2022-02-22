using System.Collections.Generic;
using Moq;
using StarWarsBL;
using StarWarsDL;
using StarWarsModel;
using Xunit;

namespace StarWarsTest;

public class TestStarWarsStoreBL{
    [Fact]
    public void Should_Get_All_Customers(){
        //Arrange
        int customerID = 1;
        string customerName = "TestCustomer";
        string customerNumber = "TestNumber";
        string customerAddress = "TestAddress";
        string customerEmail = "TestEmail";
        Customer testCustomer = new Customer(){
            _customerID = customerID,
            Name = customerName,
            Address = customerAddress,
            Number = customerNumber,
            Email = customerEmail,
        };

        List<Customer> expectedListOfCustomer = new List<Customer>();
        expectedListOfCustomer.Add(testCustomer);

        Mock<IRepository> mockRepo = new Mock<IRepository>();
        mockRepo.Setup(repo => repo.GetAllCustomers()).Returns(expectedListOfCustomer);

        IStarWarsStoreBL starWarsBL = new StarWarsStoreBL(mockRepo.Object);
        //Act
        List<Customer> actualListOfCustomers = starWarsBL.GetAllCustomer();
        //Assert
        Assert.Same(expectedListOfCustomer, actualListOfCustomers);
        Assert.Equal(customerName, actualListOfCustomers[0].Name);
        Assert.Equal(customerAddress, actualListOfCustomers[0].Address);
        Assert.Equal(customerEmail, actualListOfCustomers[0].Email);
        Assert.Equal(customerNumber, actualListOfCustomers[0].Number);
        Assert.Equal(customerID, actualListOfCustomers[0]._customerID);
    }

    [Fact]
    public void Should_Get_All_LineItems(){
        int productID = 1;
        string productName = "TestLineItem";
        float productPrice = 10;
        int lineItemID = 1;
        int orderID = 2;
        int storeID = 3;
        int quantity = 20;
        LineItems testLineItem = new LineItems(){
            _productID = productID,
            _productName = productName,
            _productPrice = productPrice,
            _lineItemID = lineItemID,
            _orderID = orderID,
            _storeID = storeID,
            _quantity = quantity,
        };
        List<LineItems> expectedListOfLineItems = new List<LineItems>();
        expectedListOfLineItems.Add(testLineItem);
        Mock<IRepository> mockRepo = new Mock<IRepository>();
        mockRepo.Setup(repo => repo.GetAllLineItems(1)).Returns(expectedListOfLineItems);
        IStarWarsStoreBL starWarsBL = new StarWarsStoreBL(mockRepo.Object);

        List<LineItems> actualListOfLineItems = starWarsBL.GetAllLineItems(1);

        Assert.Equal(productID, actualListOfLineItems[0]._productID);
        Assert.Equal(productName, actualListOfLineItems[0]._productName);
        Assert.Equal(productPrice, actualListOfLineItems[0]._productPrice);
        Assert.Equal(lineItemID, actualListOfLineItems[0]._lineItemID);
        Assert.Equal(orderID, actualListOfLineItems[0]._orderID);
        Assert.Equal(storeID, actualListOfLineItems[0]._storeID);
        Assert.Equal(quantity, actualListOfLineItems[0]._quantity);
    }

    [Fact]
    public void Should_Get_All_StoreItems(){
        int lineItemID = 1;
        string productName = "TestProduct";
        int quantity = 100;
        LineItems testLineItem = new LineItems(){
            _lineItemID = lineItemID,
            _productName = productName,
            _quantity = quantity,
        };
        List<LineItems> expectedListOfLineItems = new List<LineItems>();
        expectedListOfLineItems.Add(testLineItem);
        Mock<IRepository> mockRepo = new Mock<IRepository>();
        mockRepo.Setup(repo => repo.GetAllStoreItems(1)).Returns(expectedListOfLineItems);
        IStarWarsStoreBL starWarsBL = new StarWarsStoreBL(mockRepo.Object);

        List<LineItems> actualListOfLineItems = starWarsBL.GetAllStoreItems(1);

        Assert.Equal(lineItemID, actualListOfLineItems[0]._lineItemID);
        Assert.Equal(productName, actualListOfLineItems[0]._productName);
        Assert.Equal(quantity, actualListOfLineItems[0]._quantity);
    }

    [Fact]
    public void Should_ReplenishInventory(){
        int lineItemID = 1;
        int quantity = 20;
        int addedQuantity = 10;
        LineItems testReplenishInventory = new LineItems(){
            _lineItemID = lineItemID,
            _quantity = quantity+addedQuantity,
        };
        List<LineItems> expectedNewInventory = new List<LineItems>();
        expectedNewInventory.Add(testReplenishInventory);
        Mock<IRepository> mockRepo = new Mock<IRepository>();
        mockRepo.Setup(repo => repo.ReplenishInventory(1, 10, 1)).Returns(expectedNewInventory);
        IStarWarsStoreBL starWarsBL = new StarWarsStoreBL(mockRepo.Object);

        List<LineItems> actualNewInventory = starWarsBL.ReplenishInventory(1,10,1);

        Assert.Equal(lineItemID, actualNewInventory[0]._lineItemID);
        Assert.Equal(quantity+addedQuantity, actualNewInventory[0]._quantity);
    }

    [Fact]
    public void Should_SearchCustomer(){
        int customerID = 1;
        string customerName = "TestCustomer";
        string customerNumber = "TestNumber";
        string customerEmail = "TestEmail";
        string customerAddress = "TestAddress";
        Customer testCustomer = new Customer(){
            _customerID = customerID,
            Name = customerName,
            Address = customerAddress,
            Number = customerNumber,
            Email = customerEmail,
        };
        List<Customer> expectedSearchedCustomer = new List<Customer>();
        expectedSearchedCustomer.Add(testCustomer);
        Mock<IRepository> mockRepo = new Mock<IRepository>();
        mockRepo.Setup(repo => repo.GetAllCustomers()).Returns(expectedSearchedCustomer);
        IStarWarsStoreBL starWarsBL = new StarWarsStoreBL(mockRepo.Object);

        List<Customer> actualSearchedCustomer = starWarsBL.SearchCustomer("TestCustomer");

        Assert.Equal(customerName, actualSearchedCustomer[0].Name);
        Assert.Equal(customerAddress, actualSearchedCustomer[0].Address);
        Assert.Equal(customerNumber, actualSearchedCustomer[0].Number);
        Assert.Equal(customerEmail, actualSearchedCustomer[0].Email);
    }

    [Fact]
    public void Should_SearchStore(){
        int storeID = 1;
        string storeName = "TestStore";
        string storeAddress = "TestAddress";
        Storefront testStore = new Storefront(){
            _storeID = storeID,
            Name = storeName,
            Address = storeAddress,
        };
        List<Storefront> expectedSearchedStore = new List<Storefront>();
        expectedSearchedStore.Add(testStore);
        Mock<IRepository> mockRepo = new Mock<IRepository>();
        mockRepo.Setup(repo => repo.GetAllStores()).Returns(expectedSearchedStore);
        IStarWarsStoreBL starWarsBL = new StarWarsStoreBL(mockRepo.Object);

        List<Storefront> actualSearchedStore = starWarsBL.SearchStoreFront("TestStore");

        Assert.Equal(storeID, actualSearchedStore[0]._storeID);
        Assert.Equal(storeName, actualSearchedStore[0].Name);
        Assert.Equal(storeAddress, actualSearchedStore[0].Address);

    }
}
