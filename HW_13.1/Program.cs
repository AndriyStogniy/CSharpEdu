using HW_13._1;

class Program
{
    static void Main()
    {
        Account PumbAccount = new Account("My Pumb account", 100.00);
        Account MonoAccount = new Account("My Mono account", 1000000.00);

        PumbAccount.Withdrawal(20);
        Console.WriteLine($"The balance on {PumbAccount.AccountName} is now: {PumbAccount.Balance}");

        MonoAccount.Deposit(200);
        Console.WriteLine($"The balance on {MonoAccount.AccountName} is now: {MonoAccount.Balance}");
    }
}