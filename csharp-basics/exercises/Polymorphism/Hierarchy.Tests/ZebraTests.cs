using FluentAssertions;
using Hierarchy.Exceptions;

namespace Hierarchy.Tests;

public class ZebraTests
{
    private readonly Mammal _zebra;
    private readonly Food _vegetable;
    private readonly Food _meat;

    public ZebraTests()
    {
        _zebra = new Zebra("Zebra", "Z-1", 568.26, "Africa");
        _vegetable = new Vegetable(10);
        _meat = new Meat(3);
    }

    [Fact]
    public void CreateZebra_ValidZebra_createsZebra()
    {
        // Act & Assert
        _zebra.GetAnimalType().Should().Be("Zebra");
        _zebra.GetAnimalName().Should().Be("Z-1");
        _zebra.GetAnimalWeight().Should().Be(568.26);
        _zebra.GetRegion().Should().Be("Africa");
    }

    [Theory]
    [InlineData(null)]
    [InlineData("")]
    public void CreateZebra_TypeIsNullOrEmpty_ThrowsInvalidTypeException(string type)
    {
        // Act & Assert
        FluentActions.Invoking(() => new Zebra(type, "Z-1", 568.26, "Africa"))
            .Should().Throw<InvalidTypeException>()
            .WithMessage("Type cannot be null or empty.");
    }
    
    [Theory]
    [InlineData(null)]
    [InlineData("")]
    public void CreateZebra_NameIsNullOrEmpty_ThrowsInvalidNameException(string name)
    {
        // Act & Assert
        FluentActions.Invoking(() => new Zebra("Zebra", name, 568.26, "Africa"))
            .Should().Throw<InvalidNameException>()
            .WithMessage("Name cannot be null or empty.");
    }
    
    [Theory]
    [InlineData(null)]
    [InlineData("")]
    public void CreateZebra_RegionIsNullOrEmpty_ThrowsInvalidRegionException(string region)
    {
        // Act & Assert
        FluentActions.Invoking(() => new Zebra("Zebra", "Z-1", 568.26, region))
            .Should().Throw<InvalidRegionException>()
            .WithMessage("Region cannot be null or empty.");
    }

    [Theory]
    [InlineData(0)]
    [InlineData(-1)]
    public void CreateZebra_WeightIsNegativeOrZero_ThrowsInvalidWeightException(double weight)
    {
        // Act & Assert
        FluentActions.Invoking(() => new Zebra("Zebra", "Z-1", weight, "Africa"))
            .Should().Throw<InvalidWeightException>()
            .WithMessage("Weight must be greater than 0.");
    }

    [Fact]
    public void GetAnimalType_ReturnsType()
    {
        // Act
        var result = _zebra.GetAnimalType();
        
        // Assert
        result.Should().Be("Zebra");
    }
    
    [Fact]
    public void GetAnimalName_ReturnsName()
    {
        // Act
        var result = _zebra.GetAnimalName();
        
        // Assert
        result.Should().Be("Z-1");
    }
    
    [Fact]
    public void GetWeight_ReturnsWeight()
    {
        // Act
        var result = _zebra.GetAnimalWeight();
        
        // Assert
        result.Should().Be(568.26);
    }
    
    [Fact]
    public void GetRegion_ReturnsRegion()
    {
        // Act
        var result = _zebra.GetRegion();
        
        // Assert
        result.Should().Be("Africa");
    }
    
    [Fact]
    public void MakeSound_ReturnsSound()
    {
        // Act
        var result = _zebra.MakeSound();
        
        // Assert
        result.Should().Be("Neigh..!");
    }
    
    [Fact]
    public void GetFoodEaten_ReturnsFoodEaten()
    {
        // Act
        var result = _zebra.GetFoodEaten();
        
        // Assert
        result.Should().Be(0);
    }
    
    [Fact]
    public void Eat_ValidFood_UpdatesFoodEaten()
    {
        // Act
        _zebra.Eat(_vegetable);
        
        // Assert
        _zebra.GetFoodEaten().Should().Be(10);
    }
    
    [Fact]
    public void Eat_InvalidFood_ThrowsInvalidFootException()
    {
        // Act & Assert
        _zebra.Invoking(zebra => zebra.Eat(_meat))
            .Should().Throw<InvalidFoodException>()
            .WithMessage("Zebra does not eat that type of food!.");
    }
    
    [Fact]
    public void ToString_ReturnsObjectInformationInSetFormat()
    {
        // Act
        _zebra.Eat(_vegetable);
        var result = _zebra.ToString();

        // Assert
        result.Should().Be("Zebra[Z-1, 568.3, Africa, 10]");
    }
}