public class BankAccount
{
    private double balance = 0;

    public void Deposit(double amount)
    {
        balance += amount;
        Console.WriteLine($"${amount} deposited successfully.");
    }

    public double GetBalance()
    {
        return balance;
    }
}