using StarWarsModel;
using Xunit;

namespace StarWarsTest;

public class ProductValueTest{
    [Fact]
    public void ProductIDValueTest(){
        Products _tID = new Products();
        int _validID = 1;

        _tID._productID = _validID;

        Assert.NotNull(_tID._productID);
        Assert.Equal(_validID, _tID._productID);


    }

    [Fact]
    public void LineItemIDValueTest(){
        Products _tLineID = new Products();
        int _validID = 1;

        _tLineID._lineItemID = _validID;

        Assert.NotNull(_tLineID._lineItemID);
        Assert.Equal(_validID, _tLineID._lineItemID);
    }

    [Fact]
    public void ProductNameValueTest(){
        Products _tName = new Products();
        string _validName = "Product";

        _tName._productName = _validName;

        Assert.NotNull(_tName._productName);
        Assert.Equal(_validName, _tName._productName);
    }

    [Fact]
    public void PriceValueTest(){
        Products _tPrice = new Products();
        int _validPrice = 100;

        _tPrice._price = _validPrice;

        Assert.NotNull(_tPrice._price);
        Assert.Equal(_validPrice, _tPrice._price);
    }

    [Fact]
    public void DescriptionValueTest(){
        Products _tDesc = new Products();
        string _validDesc = "Description";

        _tDesc._description = _validDesc;

        Assert.NotNull(_tDesc._description);
        Assert.Equal(_validDesc, _tDesc._description);
    }

    [Fact]
    public void CategoryValueTest(){
        Products _tCat = new Products();
        string _validCat = "Category";

        _tCat._category = _validCat;

        Assert.NotNull(_tCat._category);
        Assert.Equal(_validCat, _tCat._category);
    }
}