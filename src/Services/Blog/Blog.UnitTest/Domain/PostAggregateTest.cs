
namespace Blog.UnitTest.Domain;

public class PostAggregateTest
{

    [Fact]
    public void PostCreate_ImageUrlInvalid_Exception()
    {
        //Arrange
        var name = "testName";
        var content = "someContent";
        var imageUrl = "someUrl";

        //Act 
        var fakeOrder = new Post(name, content, imageUrl);

        //Assert
        Assert.Equal(fakeOrder.ImageURL, imageUrl);
    }

}