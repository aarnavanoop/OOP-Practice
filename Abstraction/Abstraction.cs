using System;
using System.Collections.Generic;

namespace AbstractionProject
{
    public abstract class Vehicle
    {
        public string Model { get; set; }
        public double FuelLevel { get; set; }

        protected Vehicle(string model, double fuelLevel)
        {
            Model = model;
            FuelLevel = fuelLevel;
        }

        public abstract void StartEngine();
        public abstract double GetRange();

        public void Refuel(double amount)
        {
            FuelLevel += amount;
        }
    }

    public class ElectricCar : Vehicle
    {
        public double BatteryKwh { get; set; }

        public ElectricCar(string model, double fuelLevel, double batteryKwh) 
            : base(model, fuelLevel) 
        {
            BatteryKwh = batteryKwh;
        }

        public override void StartEngine()
        {
            Console.WriteLine($"{Model}: Powering up silent electric motors...");
        }

        public override double GetRange()
        {
            return FuelLevel * 4.5; 
        }
    }

    public class Truck : Vehicle
    {
        public double CargoWeight { get; set; }

        public Truck(string model, double fuelLevel, double cargoWeight) 
            : base(model, fuelLevel)
        {
            CargoWeight = cargoWeight;
        }

        public override void StartEngine()
        {
            Console.WriteLine($"{Model}: Diesel engine ROARING!");
        }

        public override double GetRange()
        {
            return (FuelLevel * 2.0) - (CargoWeight * 0.01);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> myFleet = new List<Vehicle>
            {
                new ElectricCar("Tesla Model S", 90, 100),
                new Truck("Volvo FH16", 300, 5000)
            };

            foreach (Vehicle v in myFleet)
            {
                v.StartEngine();
                Console.WriteLine($"{v.Model} Range: {v.GetRange()} miles");
                v.Refuel(20);
            }
        }
    }
}