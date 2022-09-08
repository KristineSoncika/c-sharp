namespace VendingMachine.Exceptions;

public class MachineIsEmptyException : Exception
{
    public MachineIsEmptyException() :
        base("This vending machine is empty. Add a product first.") { }
}