using FluentAssertions;
using Hierarchy.Exceptions;

namespace Hierarchy.Tests;

public class TigerTests
{
    private readonly Feline _tiger;
    private readonly Food _vegetable;
    private readonly Food _meat;

    public TigerTests()
    {
        _tiger = new Tiger("Tiger", "T-1", 342.7, "Asia");
        _vegetable = new Vegetable(1);
        _meat = new Meat(6);
    }

    [Fact]
    public void CreateTiger_ValidTiger_createsTiger()
    {
        // Act & Assert
        _tiger.GetAnimalType().Should().Be("Tiger");
        _tiger.GetAnimalName().Should().Be("T-1");
        _tiger.GetAnimalWeight().Should().Be(342.7);
        _tiger.GetRegion().Should().Be("Asia");
    }

    [Theory]
    [InlineData(null)]
    [InlineData("")]
    public void CreateTiger_TypeIsNullOrEmpty_ThrowsInvalidTypeException(string type)
    {
        // Act & Assert
        FluentActions.Invoking(() => new Tiger(type, "T-1", 342.7, "Asia"))
            .Should().Throw<InvalidTypeException>()
            .WithMessage("Type cannot be null or empty.");
    }
    
    [Theory]
    [InlineData(null)]
    [InlineData("")]
    public void CreateTiger_NameIsNullOrEmpty_ThrowsInvalidNameException(string name)
    {
        // Act & Assert
        FluentActions.Invoking(() => new Tiger("Tiger", name, 342.7, "Asia"))
            .Should().Throw<InvalidNameException>()
            .WithMessage("Name cannot be null or empty.");
    }
    
    [Theory]
    [InlineData(null)]
    [InlineData("")]
    public void CreateTiger_RegionIsNullOrEmpty_ThrowsInvalidRegionException(string region)
    {
        // Act & Assert
        FluentActions.Invoking(() => new Tiger("Tiger", "T-1", 342.7, region))
            .Should().Throw<InvalidRegionException>()
            .WithMessage("Region cannot be null or empty.");
    }

    [Theory]
    [InlineData(0)]
    [InlineData(-1)]
    public void CreateTiger_WeightIsNegativeOrZero_ThrowsInvalidWeightException(double weight)
    {
        // Act & Assert
        FluentActions.Invoking(() => new Tiger("Tiger", "T-1", weight, "Asia"))
            .Should().Throw<InvalidWeightException>()
            .WithMessage("Weight must be greater than 0.");
    }

    [Fact]
    public void GetAnimalType_ReturnsType()
    {
        // Act
        var result = _tiger.GetAnimalType();
        
        // Assert
        result.Should().Be("Tiger");
    }
    
    [Fact]
    public void GetAnimalName_ReturnsName()
    {
        // Act
        var result = _tiger.GetAnimalName();
        
        // Assert
        result.Should().Be("T-1");
    }
    
    [Fact]
    public void GetWeight_ReturnsWeight()
    {
        // Act
        var result = _tiger.GetAnimalWeight();
        
        // Assert
        result.Should().Be(342.7);
    }
    
    [Fact]
    public void GetRegion_ReturnsRegion()
    {
        // Act
        var result = _tiger.GetRegion();
        
        // Assert
        result.Should().Be("Asia");
    }
    
    [Fact]
    public void MakeSound_ReturnsSound()
    {
        // Act
        var result = _tiger.MakeSound();
        
        // Assert
        result.Should().Be("Grrrrr..!");
    }
    
    [Fact]
    public void GetFoodEaten_ReturnsFoodEaten()
    {
        // Act
        var result = _tiger.GetFoodEaten();
        
        // Assert
        result.Should().Be(0);
    }
    
    [Fact]
    public void Eat_ValidFood_UpdatesFoodEaten()
    {
        // Act
        _tiger.Eat(_meat);
        
        // Assert
        _tiger.GetFoodEaten().Should().Be(6);
    }
    
    [Fact]
    public void Eat_InvalidFood_ThrowsInvalidFootException()
    {
        // Act & Assert
        _tiger.Invoking(tiger => tiger.Eat(_vegetable))
            .Should().Throw<InvalidFoodException>()
            .WithMessage("Tiger does not eat that type of food!.");
    }
    
    [Fact]
    public void ToString_ReturnsObjectInformationInSetFormat()
    {
        // Act
        _tiger.Eat(_meat);
        var result = _tiger.ToString();

        // Assert
        result.Should().Be("Tiger[T-1, 342.7, Asia, 6]");
    }
}