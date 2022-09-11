using FluentAssertions;
using Hierarchy.Exceptions;

namespace Hierarchy.Tests;

public class VegetableTests
{
    private readonly Food _vegetable;

    public VegetableTests()
    {
        _vegetable = new Vegetable(3);
    }

    [Theory]
    [InlineData(0)]
    [InlineData(-1)]
    public void CreateVegetable_QuantityIsNegativeOrZero_ThrowsInvalidQuantityException(int quantity)
    {
        // Act & Assert
        FluentActions.Invoking(() => new Vegetable(quantity))
            .Should().Throw<InvalidQuantityException>()
            .WithMessage("Quantity must be greater than 0.");
    }

    [Fact]
    public void GetQuantity_ReturnsQuantity()
    {
        // Act
        var result = _vegetable.GetQuantity();
        
        // Assert
        result.Should().Be(3);
    }
    
    [Fact]
    public void ToString_ReturnsObjectInformationInSetFormat()
    {
        // Assert
        _vegetable.ToString().Should().Be("Vegetable");
    }
}