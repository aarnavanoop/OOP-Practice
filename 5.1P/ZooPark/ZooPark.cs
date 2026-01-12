
using System.Text.Json;
namespace Part1NoInheritance;


class ZooPark
{
    static void Main(string[] args)
    {
        Wolf williamWolf = new Wolf("William the Wolf", "Meat", "Dog Village",
        50.6,9, "Grey");

        Tiger tonyTiger = new Tiger("Tony the Tiger", "Meat", "Cat Land", 110, 6, "Orange and White", "Bengal", "Orange");
        
        Eagle edgarEagle = new Eagle("Edgar the Eagle", "Fish", "Bird Mania",20,15,"Black", "American", 150);

        tonyTiger.MakeNoise();
        tonyTiger.Eat();
        williamWolf.Eat();
        edgarEagle.Eat();
    }
}

class Animal
{
   public string Name {get; private set;}  
   public string Diet {get;private set;}
   public string Location{get;private set;}
   public double Weight{get;private set;}
   public int Age{get;private set;}
   public string Color {get;private set;}

   public Animal(string name, string diet, string location,
   double weight, int age,string color)
    {
        Name = name;
        Diet = diet;
        Location = location;
        Weight = weight;
        Age = age;
        Color = color;
    }

    public virtual void Eat()
    {
        Console.WriteLine($"{Name} is eating");
    }

    public void Sleep()
    {
        Console.WriteLine($"{Name} is sleeping");
    }

    public virtual void MakeNoise()
    {
        Console.WriteLine($"{Name} is making a noise");
    }

    public void EatMeat()
    {
        Console.WriteLine("Animal is eating meat");
    }

    public void EatBerries()
    {
        Console.WriteLine("Animal is eating berries now");
    }
    
}

class Feline : Animal
{
    public string Species{get;private set;}
    public Feline(string name, string diet, string location, double weight, int age, string color, string species)
        : base(name, diet, location, weight, age, color)
    {
        Species = species;
    }

}
class Tiger : Feline
{
    public string ColorStripes{get;private set;}
    public Tiger(string name, string diet, string location, double weight, int age, string color, string species, string colorStripes)
        : base(name, diet, location, weight, age, color,species)
    {
        ColorStripes = colorStripes;
    }

    public override void MakeNoise()
    {
        Console.WriteLine("ROAAAAR");
    }

    public override void Eat()
    {
        Console.WriteLine("I can eat over 20lbs of meat! ");
    }
}


class Eagle : Animal
{
    public string Species{get;private set;}
    public double WingSpan{get;private set;}

    public Eagle(string name, string diet, string location, double weight, int age, string color, string species, double wingSpan)
        : base(name, diet, location, weight, age, color)
    {
        Species = species;
        WingSpan = wingSpan;
    }

    public void LayEgg()
    {
        Console.WriteLine("Eagle is laying egg");
    }

    public void Fly()
    {
        Console.WriteLine("Eagle is flying");
    }

    public override void MakeNoise()
    {
        Console.WriteLine("Eagle whistles");
    }

    public override void Eat()
    {
        Console.WriteLine("Eagle eats 1 pound of meat");
    }
}

class Wolf : Animal
{
    public Wolf(string name, string diet, string location, double weight, int age, string color)
        : base(name, diet, location, weight, age, color)
    {
        
    }

    public override void MakeNoise()
    {
        Console.WriteLine("Wolf howls");
    }

    public override void Eat()
    {
        Console.WriteLine("Wolf eats 5 pounds of meat");
    }
}