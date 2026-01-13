class Program
{
    static void Main(string[] args)
    {
        Rabbit rabbit = new Rabbit();
        rabbit.Flee();

        Hawk hawk = new Hawk();
        hawk.Hunt();
    }
}

interface IPrey
{
   void Flee();
}

interface IPredator
{
   void Hunt() ;
}

class Rabbit:IPrey
{
    public void Flee()
    {
        Console.WriteLine("The rabbit runs away");
    }
}

class Hawk: IPredator
{
    public void Hunt()
    {
        Console.WriteLine("The Hawk hunts");
    }
}

class Fish
{
    
}