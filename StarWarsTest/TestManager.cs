using StarWarsModel;
using Xunit;

namespace StarWarsTest;

public class ManagerValueTest{
    [Fact]
    public void ManagerIDValueTest(){
        Manager _tID = new Manager();
        int _validID = 1;

        _tID._ID = _validID;

        Assert.NotNull(_tID._ID);
        Assert.Equal(_validID, _tID._ID);
    }
    [Fact]
    public void ManagerNameValueTest(){
        Manager _tName = new Manager();
        string _validName = "Hosea";

        _tName.Name = _validName;

        Assert.NotNull(_tName.Name);
        Assert.Equal(_validName, _tName.Name);
    }

    [Fact]
    public void ManagerNumberValueTest(){
        Manager _tNumber = new Manager();
        string _validNumber = "111-111-1111";

        _tNumber.Number = _validNumber;

        Assert.NotNull(_tNumber);
        Assert.Equal(_validNumber, _tNumber.Number);
    }

    [Fact]
    public void ManagerEmailValueTest(){
        Manager _tEmail = new Manager();
        string _validEmail = "asdf@gmail.com";

        _tEmail.Email = _validEmail;

        Assert.NotNull(_tEmail);
        Assert.Equal(_validEmail, _tEmail.Email);
    }

    [Fact]
    public void ManagerUsernameValueTest(){
        Manager _tUsername = new Manager();
        string _validUsername = "username";

        _tUsername.UserName = _validUsername;

        Assert.NotNull(_tUsername);
        Assert.Equal(_validUsername, _tUsername.UserName);
    }

    [Fact]
    public void ManagerPasswordValueTest(){
        Manager _tPassword = new Manager();
        string _validPassword = "password";

        _tPassword.Password = _validPassword;

        Assert.NotNull(_tPassword.Password);
        Assert.Equal(_validPassword, _tPassword.Password);
    }

    [Fact]
    public void ManagerStoreValueTest(){
        Manager _tStoreID = new Manager();
        int _validStoreID = 1;

        _tStoreID._storeID = _validStoreID;

        Assert.NotNull(_tStoreID._storeID);
        Assert.Equal(_validStoreID, _tStoreID._storeID);
    }
}
