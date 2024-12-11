using NUnit.Framework;
using TestApp.Product;

namespace TestApp.Tests;

[TestFixture]
public class ProductInventoryTests
{
    private ProductInventory _inventory = null!;
    
    [SetUp]
    public void SetUp()
    {
        this._inventory = new(); // създаване на склад _inventori
    }
    
    [Test]
    public void Test_AddProduct_ProductAddedToInventory()
    {
        // Arrange
        string productName = "Laptop";
        double productPrice = 22.30;
        int productQuantity = 2;
        string expected = $"Product Inventory:{System.Environment.NewLine}" +
                          $"{productName} - Price: ${productPrice:f2} - Quantity: {productQuantity}";


        // Act
        _inventory.AddProduct(productName, productPrice, productQuantity);
        string result = _inventory.DisplayInventory();

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_DisplayInventory_NoProducts_ReturnsEmptyString()
    {
        // Arrange
       
        string expected = "Product Inventory:";

        // Act
        
        string result = _inventory.DisplayInventory();

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_DisplayInventory_WithProducts_ReturnsFormattedInventory()
    {
        // Arrange
        
        _inventory.AddProduct("Laptop", 999.99, 3);
        _inventory.AddProduct("Mouse", 19.99, 10);

        string expected = "Product Inventory:\r\n" +
                          "Laptop - Price: $999.99 - Quantity: 3\r\n" +
                          "Mouse - Price: $19.99 - Quantity: 10";

        // Act
        string actual = _inventory.DisplayInventory();

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
    

    [Test]
    public void Test_CalculateTotalValue_NoProducts_ReturnsZero()
    {
        // Arrange
        
        double expected = 0.0;

        // Act
        double actual = _inventory.CalculateTotalValue();

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_CalculateTotalValue_WithProducts_ReturnsTotalValue()
    {
        // Arrange
        
        _inventory.AddProduct("Laptop", 1000.50, 2);
        _inventory.AddProduct("Mouse", 25.75, 5);
        double expected = (1000.50 * 2) + (25.75 * 5); // Total value calculation

        // Act
        double actual = _inventory.CalculateTotalValue();

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}
