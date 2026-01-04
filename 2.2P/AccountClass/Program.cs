class Account
{
    public decimal Balance {get;private set;}
 
    public string Name {get;private set;}

    public Account(string userName, decimal userBalance)
    {
        Name = userName;
        Balance = userBalance;
    }

    public void Deposit (decimal amount)
    {
        Balance += amount;
    }

    public void Withdraw(decimal amount)
    {
        Balance -= amount;
    }

    public void Print()
    {
      Console.WriteLine($"The current user is {Name}");
      Console.WriteLine($"The balance is {Balance}");
    }
}