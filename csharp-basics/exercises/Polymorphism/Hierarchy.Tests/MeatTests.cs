using FluentAssertions;
using Hierarchy.Exceptions;

namespace Hierarchy.Tests;

public class MeatTests
{
    private readonly Food _meat;

    public MeatTests()
    {
        _meat = new Meat(1);
    }

    [Theory]
    [InlineData(0)]
    [InlineData(-1)]
    public void CreateMeat_QuantityIsNegativeOrZero_ThrowsInvalidQuantityException(int quantity)
    {
        // Act & Assert
        FluentActions.Invoking(() => new Meat(quantity))
            .Should().Throw<InvalidQuantityException>()
            .WithMessage("Quantity must be greater than 0.");
    }

    [Fact]
    public void GetQuantity_ReturnsQuantity()
    {
        // Act
        var result = _meat.GetQuantity();
        
        // Assert
        result.Should().Be(1);
    }
    
    [Fact]
    public void ToString_ReturnsObjectInformationInSetFormat()
    {
        // Act & Assert
        _meat.ToString().Should().Be("Meat");
    }
}