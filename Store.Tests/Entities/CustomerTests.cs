using Microsoft.VisualStudio.TestTools.UnitTesting;
using Store.Domain.Entities;

namespace Store.Tests.Entities;

[TestClass]
public class CustomerTests
{
    private readonly Product _product = new Product("Produto 1", 10, true);
    private readonly Discount _discount = new Discount(10, DateTime.Now.AddDays(4));
    
    [TestMethod]
    [TestCategory("Domain")]
    public void Should_Return_Invalid_When_No_Customer()
    {
        var order = new Order(null, 10, _discount);
        order.AddItem(_product, 5);
        Assert.IsFalse(order.IsValid);
    }
}