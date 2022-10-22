namespace CSharp.Version11;

public class BankAccount
{
    public required string Name { get; init; }
    public required string Number { get; init; }
}

public static class RequiredMembersSample
{
    public static void Run()
    {
        // Error, as required properties are not initialized
        //var account1 = new BankAccount();
        //var account2 = new BankAccount { Name = "Test account" };

        var account = new BankAccount { Name = "Test account", Number = "123456" };
        Console.WriteLine($"    All required properties are initialized for {account.Name}");
    }
}
