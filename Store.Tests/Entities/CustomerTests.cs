using Microsoft.VisualStudio.TestTools.UnitTesting;
using Store.Domain.Entities;

namespace Store.Tests.Entities;

[TestClass]
public class CustomerTests
{
    private readonly Product _product = new Product("Produto 1", 10, true);
    private readonly Discount _discount = new Discount(10, DateTime.Now.AddDays(4));
    private readonly Customer _customer = new Customer("Luiz Araujo", "luiz@gmail.com");
    
    [TestMethod]
    [TestCategory("Domain")]
    public void Should_Return_Invalid_When_Customer_Invalid_Name()
    {
        var customer = new Customer(null, "luiz@gmail.com");
        Assert.AreEqual(false, customer.IsValid);
    }
    
    [TestMethod]
    [TestCategory("Domain")]
    public void Should_Return_Invalid_When_Customer_Invalid_Email()
    {
        var customer = new Customer("Luiz", null);
        Assert.AreEqual(false, customer.IsValid);
    }
    
    [TestMethod]
    [TestCategory("Domain")]
    public void Should_Return_Valid_When_Customer_Valid_Name_And_Email()
    {
        Assert.AreEqual(true, _customer.IsValid);
    }

    [TestMethod]
    [TestCategory("Domain")]
    public void Should_Return_Invalid_When_No_Customer()
    {
        var order = new Order(null, 10, _discount);
        order.AddItem(_product, 5);
        Assert.IsFalse(order.IsValid);
    }
}