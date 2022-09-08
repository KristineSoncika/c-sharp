using FluentAssertions;
using VendingMachine.Exceptions;
using VendingMachine.Interfaces;

namespace VendingMachine.Tests;

public class VendingMachineTests
{
    private readonly IVendingMachine _vendingMachine;
    private readonly Money _money;

    public VendingMachineTests()
    {
        _vendingMachine = new VendingMachine("WhoKnows", 35, new List<string> { "0.10", "0.20", "0.50", "1.00", "2.00" });
        _money = new Money(0, 50);
    }

    [Fact]
    public void CreateVendingMachine_ValidVendingMachine_CreatesVendingMachine()
    {
        // Act & Assert
        _vendingMachine.Manufacturer.Should().Be("WhoKnows");
    }
    
    [Theory]
    [InlineData(null)]
    [InlineData("")]
    [InlineData(" ")]
    public void CreateVendingMachine_NameIsNullOrEmpty_ThrowsInvalidNameException(string name)
    {
        // Act & Assert
        FluentActions.Invoking(() => new VendingMachine(name, 35, new List<string> { "0.10", "0.20", "0.50", "1.00", "2.00" }))
            .Should().Throw<InvalidNameException>()
            .WithMessage("Name cannot be null or empty.");
    }
    
    [Theory]
    [InlineData(0)]
    [InlineData(-1)]
    public void CreateVendingMachine_CapacityIsNegativeOrZero_ShouldThrowInvalidAmountException(int capacity)
    {
        // Act & Assert
        FluentActions.Invoking(() => new VendingMachine("WhoKnows", capacity, new List<string> { "0.10", "0.20", "0.50", "1.00", "2.00" }))
            .Should().Throw<InvalidAmountException>()
            .WithMessage($"Amount must be greater than 0: {capacity}");
    }

    [Fact]
    public void CreateVendingMachine_ValidCoinsListIsEmpty_ThrowsValidCoinsListCannotBeEmptyException()
    {
        // Act & Assert
        FluentActions.Invoking(() => new VendingMachine("WhoKnows", 35, new List<string>()))
            .Should().Throw<ValidCoinsListCannotBeEmptyException>()
            .WithMessage($"The list cannot be empty.");
    }

    [Fact]
    public void InsertCoin_ValidCoins_ReturnsInsertedAmount()
    {
        // Act 
        _vendingMachine.InsertCoin(new Money(0, 50));
        _vendingMachine.InsertCoin(new Money(0, 50));
        _vendingMachine.InsertCoin(new Money(2, 00));

        // Assert
        _vendingMachine.Amount.Should().Be(new Money(3, 00));
    }

    [Theory]
    [InlineData(1, 50)]
    [InlineData(0, 70)]
    [InlineData(5, 00)]
    public void InsertCoin_InvalidCoins_ThrowsInvalidCoinException(int euros, int cents)
    {
        // Arrange
        var money = new Money(euros, cents);

        // Act & Assert
        FluentActions.Invoking(() => _vendingMachine.InsertCoin(money))
            .Should().Throw<InvalidCoinException>()
            .WithMessage($"This coin is not accepted: {money.ToString()}");
    }

    [Fact]
    public void ReturnMoney_IsChangeToReturn_ReturnsChange()
    {
        // Arrange
        _vendingMachine.InsertCoin(_money);
        
        // Act
        var result = _vendingMachine.ReturnMoney();

        // Assert
        result.Should().Be(_money);
        _vendingMachine.Amount.Should().Be(new Money(0, 0));
    }

    [Fact]
    public void ReturnMoney_NoChangeToReturn_ThrowsNoChangeException()
    {
        _vendingMachine.Invoking(machine => machine.ReturnMoney())
            .Should().Throw<NoChangeException>()
            .WithMessage("There is no change to return.");
    }

    [Fact]
    public void AddProduct_ValidProduct_AddsProduct()
    {
        // Arrange
        var product = new Product("Pepsi", _money, 6);

        // Act & Assert
        _vendingMachine.AddProduct("Pepsi", _money, 6).Should().BeTrue();
        _vendingMachine.Products.Should().Contain(product);
    }
    
    [Theory]
    [InlineData(null)]
    [InlineData("")]
    [InlineData(" ")]
    public void AddProduct_NameIsNullOrEmpty_ThrowsInvalidNameException(string name)
    {
        // Act & Assert
        _vendingMachine.Invoking(machine => machine.AddProduct(name, _money, 6))
            .Should().Throw<InvalidNameException>()
            .WithMessage("Name cannot be null or empty.");
    }
    
    [Theory]
    [InlineData(0)]
    [InlineData(-1)]
    public void AddProduct_AmountIsNegativeOrZero_ShouldThrowInvalidAmountException(int amount)
    {
        // Act & Assert
        _vendingMachine.Invoking(machine => machine.AddProduct("Pepsi", _money, amount))
            .Should().Throw<InvalidAmountException>()
            .WithMessage($"Amount must be greater than 0: {amount}");
    }

    [Fact]
    public void AddProduct_ProductAlreadyAdded_ThrowsProductAlreadyAddedException()
    {
        // Arrange
        _vendingMachine.AddProduct("Pepsi", _money, 8);
        
        // Act & Assert
        _vendingMachine.Invoking(machine => machine.AddProduct("Pepsi", _money, 7))
            .Should().Throw<ProductAlreadyAddedException>()
            .WithMessage("This product has already been added: Pepsi. Update the product instead!");
    }
    
    [Fact]
    public void AddProduct_NotEnoughEmptySpots_ThrowsNotEnoughEmptySpotsException()
    {
        // Arrange
        _vendingMachine.AddProduct("Pepsi", _money, 33);
        
        // Act & Assert
        _vendingMachine.Invoking(machine => machine.AddProduct("Fanta", _money, 7))
            .Should().Throw<NotEnoughEmptySpotsException>()
            .WithMessage("There are 2 spots left. Reduce the amount.");
    }

    [Fact]
    public void UpdateProduct_ValidProduct_UpdatesProduct()
    {
        // Arrange
        _vendingMachine.AddProduct("Pepsi", _money, 8);

        // Act & Assert
        _vendingMachine.UpdateProduct(1, "Pepsi-Cola", _money, 3).Should().BeTrue();
        var product = _vendingMachine.Products[0];
        product.Name.Should().Be("Pepsi-Cola");
        product.Price.Should().Be(_money);
        product.Available.Should().Be(3);
    }

    [Fact]
    public void UpdateProduct_MachineIsEmpty_ThrowsMachineIsEmptyException()
    {
        // Act & Assert
        _vendingMachine.Invoking(machine => machine.UpdateProduct(1,"Pepsi", _money, 6))
            .Should().Throw<MachineIsEmptyException>()
            .WithMessage("This vending machine is empty. Add a product first.");
    }
    
    [Theory]
    [InlineData(null)]
    [InlineData("")]
    [InlineData(" ")]
    public void UpdateProduct_NameIsNullOrEmpty_ThrowsInvalidNameException(string name)
    {
        // Arrange
        _vendingMachine.AddProduct("Pepsi", _money, 8);
        
        // Act & Assert
        _vendingMachine.Invoking(machine => machine.UpdateProduct(1, name, _money, 6))
            .Should().Throw<InvalidNameException>()
            .WithMessage("Name cannot be null or empty.");
    }
    
    [Theory]
    [InlineData(0)]
    [InlineData(-1)]
    public void UpdateProduct_AmountIsNegativeOrZero_ShouldThrowInvalidAmountException(int amount)
    {
        // Arrange
        _vendingMachine.AddProduct("Pepsi", _money, 8);
        
        // Act & Assert
        _vendingMachine.Invoking(machine => machine.UpdateProduct(1, "Pepsi-Cola", _money, amount))
            .Should().Throw<InvalidAmountException>()
            .WithMessage($"Amount must be greater than 0: {amount}");
    }

    [Fact]
    public void UpdateProduct_InvalidProductNumber_ThrowsInvalidProductNumberException()
    {
        // Arrange
        _vendingMachine.AddProduct("Pepsi", _money, 8); 
        
        // Act & Assert
        _vendingMachine.Invoking(machine => machine.UpdateProduct(3, "Pepsi-Cola", _money, 4))
            .Should().Throw<InvalidProductNumberException>()
            .WithMessage("Invalid product number: 3.");
    }
    
    [Fact]
    public void UpdateProduct_ProductNotFound_ThrowsProductNotFoundException()
    {
        // Arrange
        _vendingMachine.AddProduct("Pepsi", _money, 8);
        _vendingMachine.AddProduct("Fanta", _money, 4);
        
        // Act & Assert
        _vendingMachine.Invoking(machine => machine.UpdateProduct(1, "Fanta", _money, 9))
            .Should().Throw<ProductWithThisNameAlreadyExistsException>()
            .WithMessage($"Product with name Fanta already exists. Update existing product instead.");
    }
    
    [Fact]
    public void UpdateProduct_NotEnoughEmptySpots_ThrowsNotEnoughEmptySpotsException()
    {
        // Arrange
        _vendingMachine.AddProduct("Pepsi", _money, 28);
        _vendingMachine.AddProduct("Fanta", _money, 4);
        
        // Act & Assert
        _vendingMachine.Invoking(machine => machine.UpdateProduct(1, "Pepsi-Cola", _money, 34))
            .Should().Throw<NotEnoughEmptySpotsException>()
            .WithMessage("There are 3 spots left. Reduce the amount.");
    }
}