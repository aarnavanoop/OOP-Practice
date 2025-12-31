namespace Problem1;

class MobileProgram
{
    static void Main(string[] args)
    {
      Mobile jimMobile = new Mobile("Monthly", "Samsung Galaxy S6","0771223" );

      Console.WriteLine("Account Type :" + jimMobile.getAccType()
      + "\nMobile Number: " + jimMobile.getNumber() + "\nDevice: " + jimMobile.getDevice()
      + "\nBalance: " + jimMobile.getBalance());

    }
}

class Mobile
{
    private string accType, device, number;
    private double balance;

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


}