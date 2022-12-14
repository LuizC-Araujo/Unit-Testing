using Microsoft.VisualStudio.TestTools.UnitTesting;
using Store.Domain.Entities;

namespace Store.Tests.Entities;

[TestClass]
public class ProductTests
{
    private readonly Customer _customer = new Customer("Luiz Araujo", "luiz@gmail.com");
    private readonly Product _product = new Product("Produto 1", 10, true);
    private readonly Order _order = new Order(new Customer("Luiz Araujo", "luiz@gmail.com"), 0, null);
    
    [TestMethod]
    [TestCategory("Domain")]
    public void Should_Not_Add_New_Item_When_Product_Less_Or_Equal_Zero()
    {
        _order.AddItem(_product, 0);
        Assert.AreEqual(_order.Items.Count, 0);
    }
    [TestMethod]
    [TestCategory("Domain")]
    public void Should_Return_Invalid_When_Title_Empty()
    {
        var product = new Product("", 15, true);
        Assert.AreEqual(false, product.IsValid);
    }
    
    [TestMethod]
    [TestCategory("Domain")]
    public void Should_Return_Invalid_When_Title_Invalid()
    {
        var product = new Product(null, 20, true);
        Assert.AreEqual(false, product.IsValid);
    }
    
    [TestMethod]
    [TestCategory("Domain")]
    public void Should_Return_Invalid_When_Title_White_Space()
    {
        var product = new Product("   ", 30, true);
        Assert.AreEqual(false, product.IsValid);
    }

    [TestMethod]
    [TestCategory("Domain")]
    public void Should_Return_Invalid_When_Price_Is_Zero()
    {
        var product = new Product("Produto 1", 0, true);
        Assert.AreEqual(false, product.IsValid);
    }

    [TestMethod]
    [TestCategory("Domain")]
    public void Should_Return_Valid_When_Product_Valid()
    {
        var product = new Product("Produto 1", 20, true);
        Assert.AreEqual(true, product.IsValid);
    }
}