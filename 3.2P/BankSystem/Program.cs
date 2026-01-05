namespace BankSystem;

class BankSystem
{
    static void Main(string[] args)
    {
        Account JimAccount = new("Jim", 1000);
        JimAccount.Deposit(100);
        JimAccount.Withdraw(150);
        JimAccount.Print();
    }
}


class Account
{
    public decimal Balance {get;private set;}
 
    public string Name {get;init;}

    public string formattedBalance => Balance.ToString("C");

    public Account(string userName, decimal userBalance)
    {
        Name = userName;
        Balance = userBalance;
    }
    public bool Deposit (decimal amount)
    {
        if(amount <= 0)
            return false;

        Balance += amount;
        Console.WriteLine($"{amount:C} deposited, your new balance is {formattedBalance}");
        return true;
    }

    public bool Withdraw(decimal amount)
    {
       if(amount > Balance || amount <= 0)
            return false;

        Balance -= amount;
        Console.WriteLine($"{amount:C} withdrawn, your new balance is {formattedBalance}");
        return true;
    }

    public void Print()
    {
      Console.WriteLine($"The current user is {Name}");
      Console.WriteLine($"The balance is {formattedBalance}");
    }
}