using Microsoft.VisualStudio.TestTools.UnitTesting;
using Store.Domain.Entities;

namespace Store.Tests.Entities;

[TestClass]
public class OrderItemTests
{

    [TestMethod]
    [TestCategory("Domain")]
    public void Should_Return_Invalid_When_Quantity_Zero()
    {
        var product = new Product("Produto 1", 25, true);
        var orderItem = new OrderItem(product, 0);
        Assert.AreEqual(false, orderItem.IsValid);
    }
}