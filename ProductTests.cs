using System;
using Xunit;

public class ProductTests
{
    
    [Fact]
    public void Pid_Valid_Creation_SetsPid()
    {
        var product = new Product(6, "Laptop", 100, 50);
        int productID = product.ProductID;
        Assert.Equal(6, productID);
    }

    [Fact]
    public void Pid_OutOfRangeLow_Creation_Throws()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => new Product(5, "Laptop", 100, 50));
    }

    [Fact]
    public void Pid_OutOfRangeHigh_Creation_Throws()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => new Product(60001, "Laptop", 100, 50));
    }

    
    [Fact]
    public void PName_Valid_Creation_SetsPName()
    {
        var product = new Product(10, "Smartphone", 500, 100);
        string productName = product.ProductName;
        Assert.Equal("Smartphone", productName);
    }

    [Fact]
    public void PName_Empty_Creation_Throws()
    {
        Assert.Throws<ArgumentNullException>(() => new Product(10, "", 500, 100));
    }

    [Fact]
    public void PName_Null_Creation_Throws()
    {
        Assert.Throws<ArgumentNullException>(() => new Product(10, null, 500, 100));
    }

    
    [Fact]
    public void Price_Valid_Creation_SetsPrice()
    {
        var product = new Product(10, "Tablet", 300, 75);
        decimal price = product.Price;
        Assert.Equal(300, price);
    }

    [Fact]
    public void Price_OutOfRangeLow_Creation_Throws()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => new Product(10, "Tablet", 5, 75));
    }

    [Fact]
    public void Price_OutOfRangeHigh_Creation_Throws()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => new Product(10, "Tablet", 6001, 75));
    }

    [Fact]
    public void Stock_Valid_Creation_SetsStock()
    {
        var product = new Product(10, "Monitor", 200, 100);
        int stock = product.Stock;
        Assert.Equal(100, stock);
    }

    [Fact]
    public void Stock_OutOfRangeLow_Creation_Throws()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => new Product(10, "Monitor", 200, 5));
    }

    [Fact]
    public void Stock_OutOfRangeHigh_Creation_Throws()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => new Product(10, "Monitor", 200, 600001));
    }

    [Fact]
    public void IncStock_Valid_IncreasesStock()
    {
        var product = new Product(10, "Keyboard", 50, 20);
        product.IncreaseStock(10);
        Assert.Equal(30, product.Stock);
    }

    [Fact]
    public void IncStock_Negative_Throws()
    {
        var product = new Product(10, "Keyboard", 50, 20);
        Assert.Throws<ArgumentOutOfRangeException>(() => product.IncreaseStock(-10));
    }

    [Fact]
    public void IncStock_Zero_Throws()
    {
        var product = new Product(10, "Keyboard", 50, 20);
        Assert.Throws<ArgumentOutOfRangeException>(() => product.IncreaseStock(0));
    }

    
    [Fact]
    public void DecStock_Valid_DecreasesStock()
    {
        var product = new Product(10, "Mouse", 30, 15);
        product.DecreaseStock(5);
        Assert.Equal(10, product.Stock);
    }

    [Fact]
    public void DecStock_Negative_Throws()
    {
        var product = new Product(10, "Mouse", 30, 15);
        Assert.Throws<ArgumentOutOfRangeException>(() => product.DecreaseStock(-5));
    }

    [Fact]
    public void DecStock_Zero_Throws()
    {
        var product = new Product(10, "Mouse", 30, 15);
        Assert.Throws<ArgumentOutOfRangeException>(() => product.DecreaseStock(0));
    }   
}
