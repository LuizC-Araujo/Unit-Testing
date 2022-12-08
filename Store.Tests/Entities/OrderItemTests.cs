using Microsoft.VisualStudio.TestTools.UnitTesting;
using Store.Domain.Entities;

namespace Store.Tests.Entities;

[TestClass]
public class OrderItemTests
{
    private readonly Product _product = new Product("Produto 1", 25, true);

    [TestMethod]
    [TestCategory("Domain")]
    public void Should_Return_Invalid_When_Quantity_Zero()
    {
        var orderItem = new OrderItem(_product, 0);
        Assert.AreEqual(false, orderItem.IsValid);
    }

    [TestMethod]
    [TestCategory("Domain")]
    public void Should_Return_Valid_When_Order_Item_Valid()
    {
        var orderItem = new OrderItem(_product, 15);
        Assert.AreEqual(true, orderItem.IsValid);
    }
}