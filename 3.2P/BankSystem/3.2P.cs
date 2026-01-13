using System.Security.Cryptography.X509Certificates;

namespace BankSystem;

class BankSystem
{
    static void Main(string[] args)
    {

        Account JimAccount = new("Jim", 1000);
        bool keepRunning = true;
        while (keepRunning)
        {
            MenuOption choice = ReadUserOptions();  
            switch (choice)
            {
                case MenuOption.Withdraw:
                    DoWithdraw(JimAccount);
                    break;
                case MenuOption.Deposit:
                    DoDeposit(JimAccount);
                    break;
                case MenuOption.Print:
                    JimAccount.Print();
                    break;
                case MenuOption.Quit:
                    Console.WriteLine("Goodbye!");
                    keepRunning = false;
                    break;
                default:
                    Console.WriteLine("Invalid selection");
                    break;
            }  
        }
        Console.WriteLine("Program exited successfuly");
    }

    static void DoDeposit(Account account)
    {
        bool transactionSuccesful = false;
        do
        {
            Console.WriteLine("How much would you like to deposit?: ");
            string? userInput = Console.ReadLine();

            if(decimal.TryParse(userInput, out decimal amount) && amount > 0)
            {
                transactionSuccesful = account.Deposit(amount);
                if (transactionSuccesful)
                {
                    Console.WriteLine("Deposit succesful");
                }
                else
                {
                    Console.WriteLine("Deposit rejected by the system");
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid positive integer");
            }
        }while(!transactionSuccesful);
    }

    static void DoWithdraw(Account account)
    {
        bool transactionSuccesful = false;
        do
        {
            Console.WriteLine("How much would you like to withdraw?: ");
            string? userInput = Console.ReadLine();

            if(decimal.TryParse(userInput, out decimal amount) && amount > 0)
            {   
                transactionSuccesful = account.Withdraw(amount);
                if(!transactionSuccesful)
                {
                    Console.WriteLine("Withdrawal failed. Insufficient funds or invalid value");
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid positive number");
            }
        }while(!transactionSuccesful);

        Console.WriteLine("Withdrawal succesful.");
    }

    static void DoPrint(Account account)
    {
        account.Print();
    }
    static MenuOption ReadUserOptions()
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