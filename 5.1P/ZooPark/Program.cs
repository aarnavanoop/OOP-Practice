namespace Part1NoInheritance;

class ZooPark
{
    Animal williamWolf = new Animal("William the Wolf", "Meat", "Dog Village",
    50.6,9, "Grey");

    Animal tonyTiger = new Animal("Tony the Tiger", "Meat", "Cat Land", 110, 6, "Orange and White");

    Animal edgarEagle = new Animal("Edgar the Eagle", "Fish", "Bird Mania",20,15,"Black");
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