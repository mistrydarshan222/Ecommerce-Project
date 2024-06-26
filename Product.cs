using System;

public class Product
{
    public int ProductID { get; }
    public string ProductName { get; }
    public decimal Price { get; }
    public int Stock { get; private set; }

    public Product(int productID, string productName, decimal price, int stock)
    {
        if (productID < 6 || productID > 60000)
            throw new ArgumentOutOfRangeException(nameof(productID), "ProductID must be between 6 and 60000.");
        if (string.IsNullOrWhiteSpace(productName))
            throw new ArgumentNullException(nameof(productName), "ProductName cannot be null or empty.");
        if (price < 6 || price > 6000)
            throw new ArgumentOutOfRangeException(nameof(price), "Price must be between $6 and $6000.");
        if (stock < 6 || stock > 600000)
            throw new ArgumentOutOfRangeException(nameof(stock), "Stock must be between 6 and 600000.");

        ProductID = productID;
        ProductName = productName;
        Price = price;
        Stock = stock;
    }

    public void IncreaseStock(int amount)
    {
        if (amount <= 0)
            throw new ArgumentOutOfRangeException(nameof(amount), "Amount to increase must be greater than zero.");
        Stock += amount;
    }

    public void DecreaseStock(int amount)
    {
        if (amount <= 0)
            throw new ArgumentOutOfRangeException(nameof(amount), "Amount to decrease must be greater than zero.");
        if (amount > Stock)
            throw new ArgumentOutOfRangeException(nameof(amount), "Amount to decrease cannot be more than the current stock.");
        Stock -= amount;
    }
}
