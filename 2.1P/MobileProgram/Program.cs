namespace Problem1;

class MobileProgram
{
    static void Main(string[] args)
    {
      Mobile jimMobile = new Mobile("Monthly", "Samsung Galaxy S6","0771223" );

      Console.WriteLine("Account Type :" + jimMobile.getAccType()
      + "\nMobile Number: " + jimMobile.getNumber() + "\nDevice: " + jimMobile.getDevice()
      + "\nBalance: " + jimMobile.getBalance());

      jimMobile.setAccType("PAYG");
      jimMobile.setDevice("iPhone 6s");
      jimMobile.setNumber("0712345");
      jimMobile.setBalance(15.50);

      Console.WriteLine("Account Type :" + jimMobile.getAccType()
      + "\nMobile Number: " + jimMobile.getNumber() + "\nDevice: " + jimMobile.getDevice()
      + "\nBalance: " + jimMobile.getBalance());

      Console.ReadLine();

    }
}

class Mobile
{
    private string accType, device, number;
    private double balance;

    private const double CALL_COST = 0.5;
    private const double TEXT_COST = 0.01;

    public Mobile(string accType, string device, string number)
    {
        this.accType = accType;
        this.device = device;
        this.number = number;
        this.balance = 0.0;
    }

    //Accessor Methods
    public string getAccType()
    {
        return this.accType;
    }

    public string getDevice()
    {
        return this.device;
    }

    public string getNumber()
    {
        return this.number;
    }

    public string getBalance()
    {
        return this.balance.ToString("C");
    }

    //Mutator Methods
    public void setAccType(string accType)
    {
        this.accType = accType;
    }

    public void setDevice(string device)
    {
        this.device = device;
    }

    public void setNumber(string number)
    {
        this.number = number;
    }

    public void setBalance(double balance)
    {
        this.balance = balance;
    }

    public void addCredit(double amount)
    {
        this.balance += amount;
        Console.WriteLine(amount);
    }

    public void makeCall(int minutes)
    {
        double cost = minutes * CALL_COST;
        this.balance -= cost;
        Console.WriteLine(getBalance());

    }

    public void sendText(int numTexts)
    {
        double cost = numTexts * TEXT_COST;
        this.balance -= cost;
        Console.WriteLine(getBalance());
    }

}