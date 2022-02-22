using StarWarsModel;
using Xunit;

namespace StarWarsTest;

public class CustomerValueTest{
    [Fact]
    public void CustomerNameValueTest(){
        Customer _tName = new Customer();
        string _validName = "Hosea";

        _tName.Name = _validName;

        Assert.NotNull(_tName.Name);
        Assert.Equal(_validName, _tName.Name);
    }

    [Fact]
    public void CustomerAddressValueTest(){
        Customer _tAddress = new Customer();
        string _validAddress = "24 Wayward Dr";

        _tAddress.Address = _validAddress;

        Assert.NotNull(_tAddress);
        Assert.Equal(_validAddress, _tAddress.Address);
    }

    [Fact]
    public void CustomerNumberValueTest(){
        Customer _tNumber = new Customer();
        string _validNumber = "888-888-8888";

        _tNumber.Number = _validNumber;

        Assert.NotNull(_tNumber);
        Assert.Equal(_validNumber, _tNumber.Number);
    }

    [Fact]
    public void CustomerEmailValueTest(){
        Customer _tEmail = new Customer();
        string _validEmail = "absdfl@gmail.com";

        _tEmail.Email = _validEmail;

        Assert.NotNull(_tEmail);
        Assert.Equal(_validEmail, _tEmail.Email);
    }
}
