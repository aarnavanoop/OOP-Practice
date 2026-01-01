namespace Problem3;

class CarProgram
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please tell me the fuel efficiency of you car: ");
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

    public string printFuelCost(double costOfFuel)
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
        MilesDriven += milesToDrive;
        fuelUsedInGallons = milesToDrive/FuelEfficiency;
        fuelUsedInLitres = convertToLitres(fuelUsedInGallons);

        costOfJourney = calcCost(fuelUsedInLitres);

        printFuelCost(costOfJourney);

    }
}