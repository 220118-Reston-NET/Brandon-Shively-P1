using StarWarsModel;
using Xunit;

namespace StarWarsTest;

public class LineItemsValueTest{
    [Fact]
    public void ProductIDValueTest(){
        LineItems _tProductID = new LineItems();
        int _validProductID = 1;

        _tProductID._productID = _validProductID;

        Assert.NotNull(_tProductID._productID);
        Assert.Equal(_validProductID, _tProductID._productID);
    }
    [Fact]
    public void ProductNameValueTest(){
        LineItems _tProductName = new LineItems();
        string _validName = "Product";

        _tProductName._productName = _validName;

        Assert.NotNull(_tProductName._productName);
        Assert.Equal(_validName, _tProductName._productName);
    }

    [Fact]
    public void ProductPriceValueTest(){
        LineItems _tProductPrice = new LineItems();
        float _validPrice = 1.23F;

        _tProductPrice._productPrice = _validPrice;

        Assert.NotNull(_tProductPrice._productPrice);
        Assert.Equal(_validPrice, _tProductPrice._productPrice);
    }

    [Fact]
    public void LineItemIDValueTest(){
        LineItems _tLineItemID = new LineItems();
        int _validLineItemID = 1;

        _tLineItemID._lineItemID = _validLineItemID;

        Assert.NotNull(_tLineItemID._lineItemID);
        Assert.Equal(_validLineItemID, _tLineItemID._lineItemID);
    }

    [Fact]
    public void OrderIDValueTest(){
        LineItems _tOrderID = new LineItems();
        int _validOrderID = 1;

        _tOrderID._orderID = _validOrderID;

        Assert.NotNull(_tOrderID._orderID);
        Assert.Equal(_validOrderID, _tOrderID._orderID);
    }

    [Fact]
    public void StoreIDValueTest(){
        LineItems _tStoreID = new LineItems();
        int _validStoreID = 1;

        _tStoreID._storeID = _validStoreID;

        Assert.NotNull(_tStoreID._storeID);
        Assert.Equal(_validStoreID, _tStoreID._storeID);
    }

    [Fact]
    public void QuantityValueTest(){
        LineItems _tQuantity = new LineItems();
        int _validQuantity = 100;

        _tQuantity._quantity = _validQuantity;

        Assert.NotNull(_tQuantity._quantity);
        Assert.Equal(_validQuantity, _tQuantity._quantity);
    }
}
