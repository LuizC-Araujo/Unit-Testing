using Microsoft.VisualStudio.TestTools.UnitTesting;
using Store.Domain.Entities;
using Store.Domain.Queries;

namespace Store.Tests.Queries;

[TestClass]
public class ProductQueriesTests
{
    private IList<Product> _products;

    public ProductQueriesTests()
    {
        _products = new List<Product>();
        _products.Add(new Product("Produto 01", 10, true));
        _products.Add(new Product("Produto 02", 20, true));
        _products.Add(new Product("Produto 03", 30, true));
        _products.Add(new Product("Produto 04", 10, true));
        _products.Add(new Product("Produto 05", 50, true));
        _products.Add(new Product("Produto 06", 60, false));
        _products.Add(new Product("Produto 07", 70, false));
        _products.Add(new Product("Produto 08", 80, false));
        _products.Add(new Product("Produto 09", 90, false));
    }
    
    [TestMethod]
    [TestCategory("Queries")]
    public void Should_Return_Five_When_Get_Active_Products()
    {
        var result = _products.AsQueryable().Where(ProductQueries.GetActiveProducts());
        Assert.AreEqual(5, result.Count());
    }

    [TestMethod]
    [TestCategory("Queries")]
    public void Should_Return_Four_When_Get_Inactive_Products()
    {
        var result = _products.AsQueryable().Where(ProductQueries.GetInactiveProducts());
        Assert.AreEqual(4, result.Count());
    }
}