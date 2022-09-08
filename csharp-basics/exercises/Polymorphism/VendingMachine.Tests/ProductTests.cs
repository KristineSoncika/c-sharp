using FluentAssertions;
using VendingMachine.Exceptions;

namespace VendingMachine.Tests;

public class ProductTests
{
    [Fact]
    public void CreateProduct_ValidProduct_CreatesProduct()
    {
        // Arrange
        var product = new Product("Pepsi", new Money(1, 30), 6);
        
        // Act & Assert
        product.Name.Should().Be("Pepsi");
        product.Price.Should().Be(new Money(1, 30));
        product.Available.Should().Be(6);
    }

    [Theory]
    [InlineData(null)]
    [InlineData("")]
    [InlineData(" ")]
    public void CreateProduct_NameIsNullOrEmpty_ThrowsInvalidNameException(string name)
    {
        // Act & Assert
        FluentActions.Invoking(() => new Product(name, new Money(1, 00), 3))
            .Should().Throw<InvalidNameException>()
            .WithMessage("Name cannot be null or empty.");
    }

    [Theory]
    [InlineData(0)]
    [InlineData(-1)]
    public void CreateProduct_AmountIsNegativeOrZero_ShouldThrowInvalidAmountException(int amount)
    {
        // Act & Assert
        FluentActions.Invoking(() => new Product("pepsi", new Money(2, 00), amount))
            .Should().Throw<InvalidAmountException>()
            .WithMessage($"Amount must be greater than 0: {amount}");
    }
    
    [Fact]
    public void ToString_ReturnsObjectInformationInSetFormat()
    {
        // Arrange
        var product = new Product("Pepsi", new Money(1, 30), 6);
        
        // Act
        var result = product.ToString();
        
        // Asserts
        result.Should().Be("Name: Pepsi | Price: 1.30 | Amount available: 6");
    }
}