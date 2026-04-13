using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_class_Polymorphism_ForReach
{
    internal class Transport { }
    


public class Vehicle
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string PlateNumber { get; set; }
        public double FuelLevel { get; set; }

        public Vehicle(string brand, string model, int year, string plateNumber)
        {
            this.Brand = brand;
            this.Model = model;
            this.Year = year;
            this.PlateNumber = plateNumber;
            this.FuelLevel = 100; 
        }

        public string GetVehicleInfo()
        {
            return $"{Year} {Brand} {Model} (Plate: {PlateNumber})";
        }

        public void ShowBasicInfo()
        {
            Console.WriteLine($"Vehicle: {GetVehicleInfo()}, Fuel: {FuelLevel}%");
        }
    }

  
    public class Car : Vehicle
    {
        public int DoorsCount { get; set; }
        public int TrunkCapacity { get; set; }
        public bool IsAutomatic { get; set; }
        public int MaxSpeed { get; set; }

        public Car(string brand, string model, int year, string plateNumber, int doors, int trunk, bool isAuto, int speed)
            : base(brand, model, year, plateNumber)
        {
            this.DoorsCount = doors;
            this.TrunkCapacity = trunk;
            this.IsAutomatic = isAuto;
            this.MaxSpeed = speed;
        }

        public void ShowCarInfo()
        {
            Console.WriteLine($"[CAR] {GetVehicleInfo()} | Doors: {DoorsCount}, Trunk: {TrunkCapacity}L, Auto: {IsAutomatic}, Max Speed: {MaxSpeed} km/h");
        }

        public double CalculateFuelCost(double distance)
        {
         
            return (distance / 100) * 8 * 1.50;
        }
    }


    public class Motorcycle : Vehicle
    {
        public int EngineCapacity { get; set; }
        public bool HasSidecar { get; set; }
        public int MaxSpeed { get; set; }
        public string Type { get; set; }

        public Motorcycle(string brand, string model, int year, string plateNumber, int engine, bool sidecar, int speed, string type)
            : base(brand, model, year, plateNumber)
        {
            this.EngineCapacity = engine;
            this.HasSidecar = sidecar;
            this.MaxSpeed = speed;
            this.Type = type;
        }

        public void ShowMotorcycleInfo()
        {
            Console.WriteLine($"[MOTO] {GetVehicleInfo()} | Type: {Type}, Engine: {EngineCapacity}cc, Sidecar: {HasSidecar}, Max Speed: {MaxSpeed} km/h");
        }

        public double CalculateFuelCost(double distance)
        {
          
            return (distance / 100) * 4 * 1.50;
        }
    }

  
    public class Truck : Vehicle
    {
        public double CargoCapacity { get; set; }
        public int AxleCount { get; set; }
        public double CurrentLoad { get; set; }
        public int MaxSpeed { get; set; }

        public Truck(string brand, string model, int year, string plateNumber, double capacity, int axles, double load, int speed)
            : base(brand, model, year, plateNumber)
        {
            this.CargoCapacity = capacity;
            this.AxleCount = axles;
            this.CurrentLoad = load;
            this.MaxSpeed = speed;
        }

        public void ShowTruckInfo()
        {
            Console.WriteLine($"[TRUCK] {GetVehicleInfo()} | Load: {CurrentLoad}/{CargoCapacity} t, Axles: {AxleCount}, Max Speed: {MaxSpeed} km/h");
        }

        public void LoadCargo(double weight)
        {
            if (CurrentLoad + weight <= CargoCapacity)
                CurrentLoad += weight;
            else
                Console.WriteLine("Warning: Overload! Capacity exceeded.");
        }

        public double CalculateFuelCost(double distance)
        {
 
            return (distance / 100) * (25 + CurrentLoad * 2) * 1.80;
        }
    }
}

