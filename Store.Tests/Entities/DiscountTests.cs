using Microsoft.VisualStudio.TestTools.UnitTesting;
using Store.Domain.Entities;

namespace Store.Tests.Entities;

[TestClass]
public class DiscountTests
{
    private readonly Customer _customer = new Customer("Luiz Araujo", "luiz@gmail.com");
    private readonly Discount _expiredDiscount = new Discount(10, DateTime.Now.AddDays(-1));
    private readonly Discount _discount = new Discount(10, DateTime.Now.AddDays(4));
    private readonly Product _product = new Product("Produto 1", 10, true);
    
    [TestMethod]
    [TestCategory("Domain")]
    public void Should_Total_Be_60_When_Expired_Discount()
    {
        var order = new Order(_customer, 10, _expiredDiscount);
        order.AddItem(_product, 5);
        Assert.AreEqual(60, order.Total());
    }
    
    [TestMethod]
    [TestCategory("Domain")]
    public void Should_Total_Be_60_When_Invalid_Discount()
    {
        var order = new Order(_customer, 10, null);
        order.AddItem(_product, 5);
        Assert.AreEqual(60, order.Total());
    }
    
    [TestMethod]
    [TestCategory("Domain")]
    public void Should_Total_Be_50_When_Discount_10()
    {
        var order = new Order(_customer, 10, _discount);
        order.AddItem(_product, 5);
        Assert.AreEqual(50, order.Total());
    }
}