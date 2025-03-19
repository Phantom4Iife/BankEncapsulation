using System;

namespace BankEncapsulation
{
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

    class Program
    {
        static void Main(string[] args)
        {
            BankAccount myAccount = new BankAccount();

            while (true)
            {
                Console.WriteLine("Choose an option: \n1. Deposit \n2. Check Balance \n3. Exit");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter deposit amount: ");
                        if (double.TryParse(Console.ReadLine(), out double amount) && amount > 0)
                        {
                            myAccount.Deposit(amount);
                        }
                        else
                        {
                            Console.WriteLine("Invalid amount. Please enter a valid number.");
                        }
                        break;
                    
                    case "2":
                        Console.WriteLine($"Your current balance is: ${myAccount.GetBalance()}");
                        break;
                    
                    case "3":
                        Console.WriteLine("Exiting application.");
                        return;
                    
                    default:
                        Console.WriteLine("Invalid choice. Please enter 1, 2, or 3.");
                        break;
                }
            }
        }
    }
}

