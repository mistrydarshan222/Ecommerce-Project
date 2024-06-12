using System;
using NUnit.Framework;

[TestFixture]
public class ProductTests
{
    // Arrange-Act-Assert pattern and meaningful names for each test

    [Test]
    public void Constructor_ValidPid_SetsPid()
    {
        // Arrange
        var productID = 6;
        var productName = "Laptop";
        var price = 100;
        var stock = 50;

        // Act
        var product = new Product(productID, productName, price, stock);

        // Assert
        Assert.That(product.ProductID, Is.EqualTo(6));
    }

    [Test]
    public void Constructor_PidOutOfRangeLow_ThrowsArgumentOutOfRangeException()
    {
        // Arrange, Act, Assert
        Assert.Throws<ArgumentOutOfRangeException>(() => new Product(5, "Laptop", 100, 50));
    }

    [Test]
    public void Constructor_PidOutOfRangeHigh_ThrowsArgumentOutOfRangeException()
    {
        // Arrange, Act, Assert
        Assert.Throws<ArgumentOutOfRangeException>(() => new Product(60001, "Laptop", 100, 50));
    }

    [Test]
    public void Constructor_ValidProductName_SetsProductName()
    {
        // Arrange
        var productID = 10;
        var productName = "Smartphone";
        var price = 500;
        var stock = 100;

        // Act
        var product = new Product(productID, productName, price, stock);

        // Assert
        Assert.That(product.ProductName, Is.EqualTo(productName));
    }

    [Test]
    public void Constructor_EmptyProductName_ThrowsArgumentNullException()
    {
        // Arrange, Act, Assert
        Assert.Throws<ArgumentNullException>(() => new Product(10, "", 500, 100));
    }

    [Test]
    public void Constructor_NullProductName_ThrowsArgumentNullException()
    {
        // Arrange, Act, Assert
        Assert.Throws<ArgumentNullException>(() => new Product(10, null, 500, 100));
    }

    [Test]
    public void Constructor_ValidPrice_SetsPrice()
    {
        // Arrange
        var productID = 10;
        var productName = "Tablet";
        var price = 300;
        var stock = 75;

        // Act
        var product = new Product(productID, productName, price, stock);

        // Assert
        Assert.That(product.Price, Is.EqualTo(price));
    }

    [Test]
    public void Constructor_PriceOutOfRangeLow_ThrowsArgumentOutOfRangeException()
    {
        // Arrange, Act, Assert
        Assert.Throws<ArgumentOutOfRangeException>(() => new Product(10, "Tablet", 5, 75));
    }

    [Test]
    public void Constructor_PriceOutOfRangeHigh_ThrowsArgumentOutOfRangeException()
    {
        // Arrange, Act, Assert
        Assert.Throws<ArgumentOutOfRangeException>(() => new Product(10, "Tablet", 6001, 75));
    }

    [Test]
    public void Constructor_ValidStock_SetsStock()
    {
        // Arrange
        var productID = 10;
        var productName = "Monitor";
        var price = 200;
        var stock = 100;

        // Act
        var product = new Product(productID, productName, price, stock);

        // Assert
        Assert.That(product.Stock, Is.EqualTo(stock));
    }

    [Test]
    public void Constructor_StockOutOfRangeLow_ThrowsArgumentOutOfRangeException()
    {
        // Arrange, Act, Assert
        Assert.Throws<ArgumentOutOfRangeException>(() => new Product(10, "Monitor", 200, 5));
    }

    [Test]
    public void Constructor_StockOutOfRangeHigh_ThrowsArgumentOutOfRangeException()
    {
        // Arrange, Act, Assert
        Assert.Throws<ArgumentOutOfRangeException>(() => new Product(10, "Monitor", 200, 600001));
    }

    [Test]
    public void IncreaseStock_ValidAmount_IncreasesStock()
    {
        // Arrange
        var product = new Product(10, "Keyboard", 50, 20);

        // Act
        product.IncreaseStock(10);

        // Assert
        Assert.That(product.Stock, Is.EqualTo(30));
    }

    [Test]
    public void IncreaseStock_NegativeAmount_ThrowsArgumentOutOfRangeException()
    {
        // Arrange
        var product = new Product(10, "Keyboard", 50, 20);

        // Act, Assert
        Assert.Throws<ArgumentOutOfRangeException>(() => product.IncreaseStock(-10));
    }

    [Test]
    public void IncreaseStock_ZeroAmount_ThrowsArgumentOutOfRangeException()
    {
        // Arrange
        var product = new Product(10, "Keyboard", 50, 20);

        // Act, Assert
        Assert.Throws<ArgumentOutOfRangeException>(() => product.IncreaseStock(0));
    }

    [Test]
    public void DecreaseStock_ValidAmount_DecreasesStock()
    {
        // Arrange
        var product = new Product(10, "Mouse", 30, 15);

        // Act
        product.DecreaseStock(5);

        // Assert
        Assert.That(product.Stock, Is.EqualTo(10));
    }

    [Test]
    public void DecreaseStock_NegativeAmount_ThrowsArgumentOutOfRangeException()
    {
        // Arrange
        var product = new Product(10, "Mouse", 30, 15);

        // Act, Assert
        Assert.Throws<ArgumentOutOfRangeException>(() => product.DecreaseStock(-5));
    }

    [Test]
    public void DecreaseStock_ZeroAmount_ThrowsArgumentOutOfRangeException()
    {
        // Arrange
        var product = new Product(10, "Mouse", 30, 15);

        // Act, Assert
        Assert.Throws<ArgumentOutOfRangeException>(() => product.DecreaseStock(0));
    }

    [Test]
    public void DecreaseStock_AmountGreaterThanStock_ThrowsArgumentOutOfRangeException()
    {
        // Arrange
        var product = new Product(10, "Mouse", 30, 15);

        // Act, Assert
        Assert.Throws<ArgumentOutOfRangeException>(() => product.DecreaseStock(20));
    }
}
