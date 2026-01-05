using System.Security.Cryptography.X509Certificates;

namespace BankSystem;

class BankSystem
{
    static void Main(string[] args)
    {
        static MenuOption ListOptions()
        {
            do
            {
                Console.WriteLine("----- Please pick from one of these options ----");
                Console.WriteLine($"{(int)MenuOption.Withdraw}: {MenuOption.Withdraw}");
                Console.WriteLine($"{(int)MenuOption.Deposit}: {MenuOption.Deposit}");
                Console.WriteLine($"{(int)MenuOption.Print}: {MenuOption.Print}");
                Console.WriteLine($"{(int)MenuOption.Quit}: {MenuOption.Quit}");
                Console.WriteLine("Enter your choice: ");

                string userChoice = Console.ReadLine();

                if(Enum.TryParse<MenuOption>(userChoice, true, out MenuOption choice))
                {
                    if(Enum.IsDefined(typeof(MenuOption), choice))
                    {
                        return choice;
                    }
                }

                Console.WriteLine("Invalid choice, please try again.");

            }while(true);
        }

        ListOptions();
        Account JimAccount = new("Jim", 1000);
        JimAccount.Deposit(100);
        JimAccount.Withdraw(150);
        JimAccount.Print();
    }
}

public enum MenuOption
{
    Withdraw = 1,
    Deposit = 2,
    Print = 3,
    Quit = 4
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