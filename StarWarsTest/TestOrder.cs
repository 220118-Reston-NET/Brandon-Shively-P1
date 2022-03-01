using System;
using StarWarsModel;
using Xunit;

namespace StarWarsTest;

public class OrderValueTest{
    [Fact]
    public void StoreNameValueTest(){
        Order _tStoreName = new Order();
        string _validName = "Store";

        _tStoreName._storeName = _validName;

        Assert.NotNull(_tStoreName._storeName);
        Assert.Equal(_validName, _tStoreName._storeName);
    }

    [Fact]
    public void ProductNameValueTest(){
        Order _tProductName = new Order();
        string _validName = "Product";

        _tProductName._productName = _validName;

        Assert.NotNull(_tProductName._productName);
        Assert.Equal(_validName, _tProductName._productName);
    }

    [Fact]
    public void CustomerNameValueTest(){
        Order _tCustomerName = new Order();
        string _validName = "Customer";

        _tCustomerName._customerName = _validName;

        Assert.NotNull(_tCustomerName._customerName);
        Assert.Equal(_validName, _tCustomerName._customerName);
    }

    [Fact]
    public void QuantityValueTest(){
        Order _tQuantity = new Order();
        int _validQuantity = 100;

        _tQuantity._quantity = _validQuantity;

        Assert.NotNull(_tQuantity._quantity);
        Assert.Equal(_validQuantity, _tQuantity._quantity);
    }

    [Fact]
    public void CustomerIDValueTest(){
        Order _tCustomerID = new Order();
        int _validCustomerID = 1;

        _tCustomerID._customerID = _validCustomerID;

        Assert.NotNull(_tCustomerID._customerID);
        Assert.Equal(_validCustomerID, _tCustomerID._customerID);
    }

    [Fact]
    public void OrderIDValueTest(){
        Order _tOrderID = new Order();
        int _validOrderID = 1;

        _tOrderID._orderID = _validOrderID;

        Assert.NotNull(_tOrderID._orderID);
        Assert.Equal(_validOrderID, _tOrderID._orderID);
    }

    [Fact]
    public void LineItemIDValueTest(){
        Order _tLineItemID = new Order();
        int _validLineItemID = 1;

        _tLineItemID._lineItemID = _validLineItemID;

        Assert.NotNull(_tLineItemID._lineItemID);
        Assert.Equal(_validLineItemID, _tLineItemID._lineItemID);
    }

    [Fact]
    public void StoreIDValueTest(){
        Order _tStoreID = new Order();
        int _validStoreID = 1;

        _tStoreID._storeID = _validStoreID;

        Assert.NotNull(_tStoreID._storeID);
        Assert.Equal(_validStoreID, _tStoreID._storeID);
    }
    
    [Fact]
    public void TotalPriceValueTest(){
        Order _tTotalPrice = new Order();
        int _validTotalPrice = 100;

        _tTotalPrice._totalPrice = _validTotalPrice;

        Assert.NotNull(_tTotalPrice._totalPrice);
        Assert.Equal(_validTotalPrice, _tTotalPrice._totalPrice);
    }

    [Fact]
    public void DateValueTest(){
        Order _tDate = new Order();
        DateTime _validDate = new DateTime(2022,02,28,15,00,00);

        _tDate._date = _validDate;

        Assert.NotNull(_tDate._date);
        Assert.Equal(_validDate, _tDate._date);
    }
}