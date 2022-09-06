using FluentAssertions;
using Hierarchy.Exceptions;

namespace Hierarchy.Tests;

public class CatTests
{
    private readonly Cat _cat;
    private readonly Food _vegetable;
    private readonly Food _meat;

    public CatTests()
    {
        _cat = new Cat("Cat", "C-1", 4.5, "Europe", "Street");
        _vegetable = new Vegetable(1);
        _meat = new Meat(3);
    }

    [Fact]
    public void CreateCat_ValidCat_createsCat()
    {
        // Act & Assert
        _cat.GetAnimalType().Should().Be("Cat");
        _cat.GetAnimalName().Should().Be("C-1");
        _cat.GetAnimalWeight().Should().Be(4.5);
        _cat.GetRegion().Should().Be("Europe");
        _cat.GetBreed().Should().Be("Street");
    }

    [Theory]
    [InlineData(null)]
    [InlineData("")]
    public void CreateCat_TypeIsNullOrEmpty_ThrowsInvalidTypeException(string type)
    {
        // Act & Assert
        FluentActions.Invoking(() => new Cat(type, "C-1", 4.5, "Europe", "Street"))
            .Should().Throw<InvalidTypeException>()
            .WithMessage("Type cannot be null or empty.");
    }
    
    [Theory]
    [InlineData(null)]
    [InlineData("")]
    public void CreateCat_NameIsNullOrEmpty_ThrowsInvalidNameException(string name)
    {
        // Act & Assert
        FluentActions.Invoking(() => new Cat("Cat", name, 4.5, "Europe", "Street"))
            .Should().Throw<InvalidNameException>()
            .WithMessage("Name cannot be null or empty.");
    }
    
    [Theory]
    [InlineData(null)]
    [InlineData("")]
    public void CreateCat_RegionIsNullOrEmpty_ThrowsInvalidRegionException(string region)
    {
        // Act & Assert
        FluentActions.Invoking(() => new Cat("Cat", "C-1", 4.5, region, "Street"))
            .Should().Throw<InvalidRegionException>()
            .WithMessage("Region cannot be null or empty.");
    }
    
    [Theory]
    [InlineData(null)]
    [InlineData("")]
    public void CreateCat_BreedIsNullOrEmpty_ThrowsInvalidBreedException(string breed)
    {
        // Act & Assert
        FluentActions.Invoking(() => new Cat("Cat", "C-1", 4.5, "Europe", breed))
            .Should().Throw<InvalidBreedException>()
            .WithMessage("Breed cannot be null or empty.");
    }

    [Theory]
    [InlineData(0)]
    [InlineData(-1)]
    public void CreateCat_WeightIsNegativeOrZero_ThrowsInvalidWeightException(double weight)
    {
        // Act & Assert
        FluentActions.Invoking(() => new Cat("Cat", "C-1", weight, "Europe", "Street"))
            .Should().Throw<InvalidWeightException>()
            .WithMessage("Weight must be greater than 0.");
    }

    [Fact]
    public void GetAnimalType_ReturnsType()
    {
        // Act
        var result = _cat.GetAnimalType();
        
        // Assert
        result.Should().Be("Cat");
    }
    
    [Fact]
    public void GetAnimalName_ReturnsName()
    {
        // Act
        var result = _cat.GetAnimalName();
        
        // Assert
        result.Should().Be("C-1");
    }
    
    [Fact]
    public void GetWeight_ReturnsWeight()
    {
        // Act
        var result = _cat.GetAnimalWeight();
        
        // Assert
        result.Should().Be(4.5);
    }
    
    [Fact]
    public void GetRegion_ReturnsRegion()
    {
        // Act
        var result = _cat.GetRegion();
        
        // Assert
        result.Should().Be("Europe");
    }
    
    [Fact]
    public void MakeSound_ReturnsSound()
    {
        // Act
        var result = _cat.MakeSound();
        
        // Assert
        result.Should().Be("Meooow!");
    }
    
    [Fact]
    public void GetFoodEaten_ReturnsFoodEaten()
    {
        // Act
        var result = _cat.GetFoodEaten();
        
        // Assert
        result.Should().Be(0);
    }
    
    [Fact]
    public void Eat_ValidFoodMeat_UpdatesFoodEaten()
    {
        // Act
        _cat.Eat(_meat);
        
        // Assert
        _cat.GetFoodEaten().Should().Be(3);
    }
    
    [Fact]
    public void Eat_ValidFoodVegetable_UpdatesFoodEaten()
    {
        // Act
        _cat.Eat(_vegetable);
        
        // Assert
        _cat.GetFoodEaten().Should().Be(1);
    }
    
    [Fact]
    public void ToString_ReturnsObjectInformationInSetFormat()
    {
        // Act
        _cat.Eat(_vegetable);
        var result = _cat.ToString();

        // Assert
        result.Should().Be("Cat[C-1, 4.5, Europe, Street, 1]");
    }
}