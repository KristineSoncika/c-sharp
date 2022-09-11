using FluentAssertions;
using Hierarchy.Exceptions;

namespace Hierarchy.Tests;

public class MouseTests
{
    private readonly Mammal _mouse;
    private readonly Food _vegetable;
    private readonly Food _meat;

    public MouseTests()
    {
        _mouse = new Mouse("Mouse", "M-1", 0.67, "Europe");
        _vegetable = new Vegetable(2);
        _meat = new Meat(3);
    }

    [Fact]
    public void CreateMouse_ValidMouse_createsMouse()
    {
        // Act & Assert
        _mouse.GetAnimalType().Should().Be("Mouse");
        _mouse.GetAnimalName().Should().Be("M-1");
        _mouse.GetAnimalWeight().Should().Be(0.67);
        _mouse.GetRegion().Should().Be("Europe");
    }

    [Theory]
    [InlineData(null)]
    [InlineData("")]
    public void CreateMouse_TypeIsNullOrEmpty_ThrowsInvalidTypeException(string type)
    {
        // Act & Assert
        FluentActions.Invoking(() => new Mouse(type, "M-1", 0.67, "Europe"))
            .Should().Throw<InvalidTypeException>()
            .WithMessage("Type cannot be null or empty.");
    }
    
    [Theory]
    [InlineData(null)]
    [InlineData("")]
    public void CreateMouse_NameIsNullOrEmpty_ThrowsInvalidNameException(string name)
    {
        // Act & Assert
        FluentActions.Invoking(() => new Mouse("Mouse", name, 0.67, "Europe"))
            .Should().Throw<InvalidNameException>()
            .WithMessage("Name cannot be null or empty.");
    }
    
    [Theory]
    [InlineData(null)]
    [InlineData("")]
    public void CreateMouse_RegionIsNullOrEmpty_ThrowsInvalidRegionException(string region)
    {
        // Act & Assert
        FluentActions.Invoking(() => new Mouse("Mouse", "M-1", 0.67, region))
            .Should().Throw<InvalidRegionException>()
            .WithMessage("Region cannot be null or empty.");
    }

    [Theory]
    [InlineData(0)]
    [InlineData(-1)]
    public void CreateMouse_WeightIsNegativeOrZero_ThrowsInvalidWeightException(double weight)
    {
        // Act & Assert
        FluentActions.Invoking(() => new Mouse("Mouse", "M-1", weight, "Europe"))
            .Should().Throw<InvalidWeightException>()
            .WithMessage("Weight must be greater than 0.");
    }

    [Fact]
    public void GetAnimalType_ReturnsType()
    {
        // Act
        var result = _mouse.GetAnimalType();
        
        // Assert
        result.Should().Be("Mouse");
    }
    
    [Fact]
    public void GetAnimalName_ReturnsName()
    {
        // Act
        var result = _mouse.GetAnimalName();
        
        // Assert
        result.Should().Be("M-1");
    }
    
    [Fact]
    public void GetWeight_ReturnsWeight()
    {
        // Act
        var result = _mouse.GetAnimalWeight();
        
        // Assert
        result.Should().Be(0.67);
    }
    
    [Fact]
    public void GetRegion_ReturnsRegion()
    {
        // Act
        var result = _mouse.GetRegion();
        
        // Assert
        result.Should().Be("Europe");
    }
    
    [Fact]
    public void MakeSound_ReturnsSound()
    {
        // Act
        var result = _mouse.MakeSound();
        
        // Assert
        result.Should().Be("Piep-piep..!!");
    }
    
    [Fact]
    public void GetFoodEaten_ReturnsFoodEaten()
    {
        // Act
        var result = _mouse.GetFoodEaten();
        
        // Assert
        result.Should().Be(0);
    }
    
    [Fact]
    public void Eat_ValidFood_UpdatesFoodEaten()
    {
        // Act
        _mouse.Eat(_vegetable);
        
        // Assert
        _mouse.GetFoodEaten().Should().Be(2);
    }
    
    [Fact]
    public void Eat_InvalidFood_ThrowsInvalidFootException()
    {
        // Act & Assert
        _mouse.Invoking(mouse => mouse.Eat(_meat))
            .Should().Throw<InvalidFoodException>()
            .WithMessage("Mouse does not eat that type of food!.");
    }
    
    [Fact]
    public void ToString_ReturnsObjectInformationInSetFormat()
    {
        // Act
        _mouse.Eat(_vegetable);
        var result = _mouse.ToString();

        // Assert
        result.Should().Be("Mouse[M-1, 0.7, Europe, 2]");
    }
}