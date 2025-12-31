namespace Problem1;

class MobileProgram
{
    static void Main(string[] args)
    {
        
    }
}

class Mobile
{
    private string acctype, device, number;
    private double balance;

    public Mobile(string acctype, string device, string number)
    {
        this.acctype = acctype;
        this.device = device;
        this.number = number;
        this.balance = 0.0;
    }
}