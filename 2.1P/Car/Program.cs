namespace Problem3;

class CarProgram
{
    static void Main(string[] args)
    {
        bool isValid = false;
        double efficiency;
        do
        {
            Console.WriteLine("Please tell me the fuel efficiency of you car: ");
            string? input = Console.ReadLine();

            isValid = double.TryParse(input, out efficiency);
            if (!isValid)
            {
                Console.WriteLine("Please enter a valid number!");
            }
        }while(!isValid);
                Car firstCar = new Car(efficiency);

        Console.WriteLine($"Car has been created with an efficiency of {firstCar.FuelEfficiency} mpg");
        Console.WriteLine($"The amount of fuel it has in the tank is {firstCar.FuelInLitres} litres ");
        Console.WriteLine($"The total miles driven is {firstCar.MilesDriven}");

        string message = firstCar.printFuelCost();
        Console.WriteLine(message);

    }
}

class Car
{
    public double FuelEfficiency {get; set;}
    public double FuelInLitres {get;set;}
    public double MilesDriven {get;set;}
    private const double costOfFuel = 1.385;

    public Car(double fuelEfficiency, double fuelInLitres = 0, double milesDriven = 0)
    {
        FuelEfficiency = fuelEfficiency;
        FuelInLitres = fuelInLitres;
        MilesDriven = milesDriven;
    }

    public string printFuelCost()
    {
        return $"The cost of fuel is: {costOfFuel:C}";
    }

    public void addFuel(double fuelToAdd)
    {
        FuelInLitres += fuelToAdd;
        Console.WriteLine($"The cost of the fill is: ${(costOfFuel * fuelToAdd):C}");

    }

    public double calcCost(double fuelAvailable)
    {   
        double fuelCost = 0;
        fuelCost = fuelAvailable * costOfFuel;
        return fuelCost;

    }

    public double convertToLitres(double numberOfGallons)
    {
        double gallonsInLitres = 0;
        gallonsInLitres = numberOfGallons * 4.546;
        return gallonsInLitres; 
    }

    public void drive(double milesToDrive)
    {
        double fuelUsedInGallons;
        double fuelUsedInLitres;
        double costOfJourney = 0;
        string fuelUsed = "";
        MilesDriven += milesToDrive;
        fuelUsedInGallons = milesToDrive/FuelEfficiency;
        fuelUsedInLitres = convertToLitres(fuelUsedInGallons);

        costOfJourney = calcCost(fuelUsedInLitres);

        fuelUsed = printFuelCost();
        Console.WriteLine(fuelUsed);

    }
}