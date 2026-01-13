namespace Task6;

class Program
{
    static void Main(string[] args)
    {
        Bird bird = new Bird("Joel");
        Console.WriteLine(bird.ToString());
        bird.fly();

        Penguin penguin = new Penguin("Pingu");
        Console.WriteLine(penguin.ToString());
        penguin.fly();

        Duck duck = new Duck("Ducky", 50, "ugly");
        Console.WriteLine(duck.ToString());
        duck.fly();

    }
}
class Bird
{
    public string Name {get;private set;}  

    public Bird(string name)
    {
        Name = name;
    }

    public virtual void fly()
    {
        Console.WriteLine("Flap, Flap, Flap");
    }

    public override string ToString()
    {
        return $"A bird called {Name}";
    }
     
}

class Penguin : Bird
{
    public Penguin(string name) : base(name)
    {

    }
    public override void fly()
    {
        Console.WriteLine("Penguin can't really fly..");
    }

    public override string ToString()
    {
        return $"A penguin called {Name}";
    }
}

class Duck : Bird
{
    public double Size {get;private set;}
    public string Kind {get;private set;}

    public Duck(string name, double size, string kind)
        : base(name)
    {
        Size = size;
        Kind = kind;
    }

    public override string ToString()
    {
        return $"A duck called {Name} of size {Size} and kind {Kind}";
    }

}
