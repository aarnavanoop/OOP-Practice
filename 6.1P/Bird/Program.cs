namespace Task6;

class Program
{
    static void Main(string[] args)
    {
        
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
        Console.WriteLine("Bird is flapping");
    }

    public override string ToString()
    {
        return $"{Name}";
    }

     
}
