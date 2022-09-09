using FluentAssertions;

namespace Hierarchy.Tests;

public class AnimalDataTests
{
    [Theory]
    [InlineData("Mouse M-1 0,134 Europe", "Vegetable 1", "Mouse[M-1, 0.1, Europe, 1]")]
    [InlineData("Zebra Z-1 345,35 Africa", "Vegetable 10", "Zebra[Z-1, 345.4, Africa, 10]")]
    [InlineData("Tiger T-1 134 Asia", "Meat 4", "Tiger[T-1, 134.0, Asia, 4]")]
    [InlineData("Cat C-1 3,0 Europe Street", "Meat 2", "Cat[C-1, 3.0, Europe, Street, 2]")]
    public void CreateAnimal_ValidData_CreatesAnimal(string animal, string food, string expected)
    {
        // Act
        var result = AnimalData.CreateAnimal(animal, food);
        
        // Assert
        result.Should().Be(expected);
    }
}