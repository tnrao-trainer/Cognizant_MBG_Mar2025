using System;

class Bank
{
    static double balance = 1000;

    public static void Deposit(double amount)
    {
        balance += amount;
        Console.WriteLine($"Deposited: {amount}. New Balance: {balance}");
    }

    public static void Withdraw(double amount)
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
}

public class Program
{
    public static void Main()
    {
        Bank.Deposit(500);
        Bank.Withdraw(300);
        Bank.Withdraw(1500); // Should trigger insufficient balance
    }
}
