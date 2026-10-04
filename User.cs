using System;

public class User
{
    public string Login { get; set; } = "";
    public string Password { get; set; } = "";
    private decimal balance;

    public decimal Balance
    {
        get { return balance; }
    }

    public void ChangeBalance(decimal amount)
    {
        balance += amount;
    }

    public void PrintInfo()
    {
        Console.WriteLine("Логін: " + Login);
        Console.WriteLine("Баланс: " + balance + " грн");
    }
}
