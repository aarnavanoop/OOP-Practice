// Explanation of the compile time errors
// 1. We Cant call sum as the method is protected, only the class itself and any classes that inherit from it can call it, so program cant as its not the same class/has any inheritance relationship.
// 2. ClassB cant use the variable 'i' either as it is private, so only the class in which i is declared can use it.
class Overloading
{
    static void Main(string[] args)
    {
        methodToBeOverloaded("Peter");
        ClassA a = new ClassA();
        ClassB b = new ClassB();
        Console.WriteLine("Sum by class A: {0}", a.Sum(3));
        Console.WriteLine("Product by class A: {0}", a.Product(3));
        Console.WriteLine("Division by class A: {0}", a.Division(3));
        Console.WriteLine("Sum by class B: {0}", b.Sum(3));
        Console.WriteLine("Product by class B: {0}", b.Product(3));
        Console.WriteLine("Division by class B: {0}", b.Division(3));
        b.PrintResults(3);
    }

    public static void methodToBeOverloaded(string name)
    {
        Console.WriteLine("Name: " + name);
    }

    public static void methodToBeOverloaded(string name, int age)
    {
        Console.WriteLine($"Name: {name} \nAge: {age}");
    }
}

public class ClassA
{
  private int i = 10;
  protected int Sum(int j)
  {
  return i + j;
  }
  public int Product(int j)
  {
  return i * j;
  }
  public virtual double Division(int j)
  {
  return i / j;
  }
}

public class ClassB : ClassA
{
  public override double Division(int j)
  {
  return (double)i / j;
  }
  public void PrintResults(int j)
  {
  Console.WriteLine("i: {0}", i);
  Console.WriteLine("Sum(j): {0}", Sum(j));
  Console.WriteLine("Product(j): {0}", Product(j));
  Console.WriteLine("Division(j): {0}", Division(j));
  }
  }