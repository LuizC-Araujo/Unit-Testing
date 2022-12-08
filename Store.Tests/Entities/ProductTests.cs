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
        Assert.Fail();
    }
    
    [TestMethod]
    [TestCategory("Domain")]
    public void Should_Return_Invalid_When_Price_Invalid()
    {
        Assert.Fail();
    }
    
    [TestMethod]
    [TestCategory("Domain")]
    public void Should_Return_Invalid_When_Price_Is_Zero()
    {
        Assert.Fail();
    }
    
    [TestMethod]
    [TestCategory("Domain")]
    public void Should_Return_Invalid_When_Active_Invalid()
    {
        Assert.Fail();
    }
    
    [TestMethod]
    [TestCategory("Domain")]
    public void Should_Return_Valid_When_Prodcut_Valid()
    {
        Assert.Fail();
    }
    
    [TestMethod]
    [TestCategory("Domain")]
    public void Should_Not_Add_New_Item_When_No_Product()
    {
        _order.AddItem(null, 10);
        Assert.AreEqual(0, _order.Items.Count);
    }
}