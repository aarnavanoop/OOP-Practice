class Program
{
    static void Main(string[] args)
    {
        Rabbit rabbit = new Rabbit();
        rabbit.Flee();

        Hawk hawk = new Hawk();
        hawk.Hunt();

        Fish fish = new Fish();
        fish.Flee();
        fish.Hunt();
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

class Fish : IPredator, IPrey
{
    public void Flee()
    {
        Console.WriteLine("The fish swims away");
    }

    public void Hunt()
    {
        Console.WriteLine("The fish is hunting");
    }
}