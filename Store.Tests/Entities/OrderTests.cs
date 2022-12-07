using Microsoft.VisualStudio.TestTools.UnitTesting;
using Store.Domain.Entities;
using Store.Domain.Enums;

namespace Store.Tests.Entities;

[TestClass]
public class OrderTests
{
    private readonly Customer _customer = new Customer("Luiz Araujo", "luiz@gmail.com");
    private readonly Product _product = new Product("Produto 1", 10, true);
    private readonly Discount _discount = new Discount(10, DateTime.Now.AddDays(5));
    private readonly Order _order = new Order(new Customer("Luiz Araujo", "luiz@gmail.com"), 0, null);
    
    [TestMethod]
    [TestCategory("Domain")]
    public void Should_Generate_Number_With_8_Characters_When_Valid_Order()
    {
        Assert.AreEqual(8, _order.Number.Length);
    }

    [TestMethod]
    [TestCategory("Domain")]
    public void Should_Change_Status_To_Waiting_Payment_When_New_Order()
    {
        Assert.AreEqual(EOrderStatus.WaitingPayment, _order.Status);
    }

    [TestMethod]
    [TestCategory("Domain")]
    public void Should_Change_Status_To_Waiting_Delivery_When_Order_Payment_Done()
    {
        _order.AddItem(_product, 1);
        _order.Pay(_order.Total());
        Assert.AreEqual(EOrderStatus.WaitingDelivery, _order.Status);
    }

    [TestMethod]
    [TestCategory("Domain")]
    public void Should_Change_Status_To_Cancelled_When_Cancelled_Order()
    {
        _order.Cancel();
        Assert.AreEqual(EOrderStatus.Canceled, _order.Status);
    }

    [TestMethod]
    [TestCategory("Domain")]
    public void Should_Not_Add_New_Item_When_No_Product()
    {
        _order.AddItem(null, 10);
        Assert.AreEqual(0, _order.Items.Count);
    }
    
    [TestMethod]
    [TestCategory("Domain")]
    public void Should_Not_Add_New_Item_When_Product_Less_Or_Equal_Zero()
    {
        Assert.Fail();
    }
    
    [TestMethod]
    [TestCategory("Domain")]
    public void Should_Total_Be_50_When_New_Order_Valid()
    {
        Assert.Fail();
    }
    
    [TestMethod]
    [TestCategory("Domain")]
    public void Should_Total_Be_60_When_Expired_Discount()
    {
        Assert.Fail();
    }
    
    [TestMethod]
    [TestCategory("Domain")]
    public void Should_Total_Be_60_When_Invalid_Discount()
    {
        Assert.Fail();
    }
    
    [TestMethod]
    [TestCategory("Domain")]
    public void Should_Total_Be_50_When_Discount_10()
    {
        Assert.Fail();
    }
    
    [TestMethod]
    [TestCategory("Domain")]
    public void Should_Total_Be_60_When_Delivery_Fee_10()
    {
        Assert.Fail();
    }
    
    [TestMethod]
    [TestCategory("Domain")]
    public void Should_Return_Invalid_When_No_Customer()
    {
        Assert.Fail();
    }
}