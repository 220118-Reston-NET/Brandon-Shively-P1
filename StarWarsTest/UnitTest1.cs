using StarWarsModel;
using Xunit;

namespace StarWarsTest;

public class CustomerValueTest{
    [Fact]
    public void CustomerNameValueTest(){
        Customer tname = new Customer();
        string validname = "Hosea";

        tname.Name = validname;

        Assert.NotNull(tname.Name);
        Assert.Equal(validname, tname.Name);
    }
}
