using FluentAssertions;
using VendingMachine.Exceptions;

namespace VendingMachine.Tests;

public class MoneyTests
{
    [Fact]
    public void CreateMoney_ValidMoney_CreatesMoney()
    {
        // Arrange
        var money = new Money(0, 50);
        
        // Act & Assert
        money.Euros.Should().Be(0);
        money.Cents.Should().Be(50);
    }
    
    [Fact]
    public void CreateMoney_InvalidEuros_ThrowsInvalidEurosException()
    {
        // Act & Assert
        FluentActions.Invoking(() => new Money(-1, 50))
            .Should().Throw<InvalidEurosException>()
            .WithMessage("Euros cannot be negative: -1.");
    }

    [Theory]
    [InlineData(1, -50)]
    [InlineData(1, 100)]
    public void CreateMoney_InvalidCents_ThrowsInvalidCentsException(int euros, int cents)
    {
        // Act & Assert
        FluentActions.Invoking(() => new Money(euros, cents))
            .Should().Throw<InvalidCentsException>()
            .WithMessage($"Cents must be between 0 and 99: {cents}.");
    }

    [Theory]
    [InlineData(0, 50, 0.50)]
    [InlineData(2, 20, 2.20)]
    [InlineData(1, 0, 1.00)]
    public void GetValue_ReturnsNumericValue(int euros, int cents, double expected)
    {
        // Arrange
        var money = new Money(euros, cents);
        
        // Act
        var result = money.GetValue();
        
        // Assert
        result.Should().Be(expected);
    }

    [Fact]
    public void ToString_ReturnsObjectInformationInSetFormat()
    {
        // Arrange
        var money = new Money(0, 50);
        
        // Act
        var result = money.ToString();
        
        // Asserts
        result.Should().Be("0.50");
    }
}