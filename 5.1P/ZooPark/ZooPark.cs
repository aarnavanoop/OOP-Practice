
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

        tonyTiger.EatMeat();
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

    public void Eat()
    {
        Console.WriteLine($"{Name} is eating");
    }

    public void Sleep()
    {
        Console.WriteLine($"{Name} is sleeping");
    }

    public void MakeNoise()
    {
        Console.WriteLine($"{Name} is making a noise");
    }

    public void MakeLionNoise()
    {
        Console.WriteLine("A lion noise is made");
    }

    public void MakeEagleNoise()
    {
        Console.WriteLine("An eagle noise is made");
    }

    public void MakeWolfNoise()
    {
        Console.WriteLine("A wolf noise is made");
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

class Tiger : Animal
{
    public string Species {get;private set;}
    public string ColorStripes{get;private set;}
    public Tiger(string name, string diet, string location, double weight, int age, string color, string species, string colorStripes)
        : base(name, diet, location, weight, age, color)
    {
        Species = species;
        ColorStripes = colorStripes;
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
}

class Wolf : Animal
{
    public Wolf(string name, string diet, string location, double weight, int age, string color)
        : base(name, diet, location, weight, age, color)
    {
        
    }
}