namespace Problem2;

class EmployeeProgram
{
    static void Main(string[] args)
    {
        string? raiseInput = "";
        bool isValid = false;
        double raiseValue = 0;
        string percentageToRaise = "";
        double percentageRaise = 0;

        Employee jimEmployee = new Employee("Jim", 10000);

        Console.WriteLine($"Hello {jimEmployee.getName()}, you are earning a salary of {jimEmployee.getSalary():C}");
        Console.WriteLine();

        do
        {

            Console.WriteLine("What is the raise given to you?: ");
            raiseInput = Console.ReadLine();
            string[] percentageToRaiseArray =  raiseInput.Split("%");
            percentageToRaise = percentageToRaiseArray[0];
            isValid = double.TryParse(percentageToRaise, out raiseValue);
            if (!isValid)
            {
                Console.WriteLine("You have to enter a number! ");
                Console.WriteLine();
            }

        }while(!isValid);

        jimEmployee.raiseSalary(raiseValue);

        Console.ReadLine();

    }
}

class Employee
{
    private string _employeeName;
    private double _currentSalary;

    public Employee(string employeeName, double currentSalary)
    {
        _employeeName = employeeName;
        _currentSalary = currentSalary;
    }

    public string getName()
    {
        return _employeeName;
    }

    public double getSalary()
    {
        return _currentSalary;
    }

    public void raiseSalary(double percentage)
    {
        _currentSalary = (_currentSalary * (percentage/100)) + _currentSalary;
        Console.WriteLine($"Your salary after your raise is {getSalary():C}");
    }
    
}