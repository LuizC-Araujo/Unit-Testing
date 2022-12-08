using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Store.Tests.Entities;

[TestClass]
public class OrderItemTests
{

    [TestMethod]
    [TestCategory("Domain")]
    public void Should_Return_Invalid_When_Quantity_Zero()
    {
        Assert.Fail();
    }
}