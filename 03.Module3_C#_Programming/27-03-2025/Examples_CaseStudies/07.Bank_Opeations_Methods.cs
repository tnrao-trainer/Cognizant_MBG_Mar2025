using System;

class Bank
{
    static double balance = 1000;

    static void Deposit(double amount)
    {
        balance += amount;
        Console.WriteLine($"Deposited: {amount}. New Balance: {balance}");
    }

    static void Withdraw(double amount)
    {
        if (amount <= balance)
        {
            balance -= amount;
            Console.WriteLine($"Withdrawn: {amount}. Remaining Balance: {balance}");
        }
        else
        {
            Console.WriteLine("Insufficient Balance!");
        }
    }

    static void Main()
    {
        Deposit(500);
        Withdraw(300);
        Withdraw(1500); // Should trigger insufficient balance
    }
}
