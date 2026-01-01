class Program
{
static void Main(string[] args)
    {
        Employee jim = new Employee("Jim", 5000);
        jim.RaiseSalary(50);
        Console.WriteLine(jim.Salary);
    }
}

class Employee
{
    public string Name {get;}
    public double Salary{get;private set;}

    public Employee(string employeeName, double employeeSalary)
    {
        Name = employeeName;
        Salary = employeeSalary;
    }

    public void RaiseSalary(double percentage)
    {
        Salary = ((percentage/100) * Salary) + Salary;
    }

}