//namespace Abstract_class_Polymorphism_ForReach
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Hello, World!");
//        }
//    }
//}
using System.Diagnostics;
using System.Runtime.ConstrainedExecution;

class Program
{
    static void Main()
    {
        
        Car car1 = new Car("Mercedes", "E200", 2023, "10-AA-001", 4, 500, true, 220);
        Car car2 = new Car("BMW", "320i", 2022, "99-BB-999", 4, 480, true, 235);
        Car car3 = new Car("Toyota", "Camry", 2021, "77-CC-777", 4, 524, true, 210);

      
        Motorcycle moto1 = new Motorcycle("Yamaha", "R1", 2023, "10-MM-100", 998, false, 299, "Sport");
        Motorcycle moto2 = new Motorcycle("Harley-Davidson", "Fat Boy", 2022, "10-HH-020", 1868, true, 180, "Cruiser");

       
        Truck truck1 = new Truck("MAN", "TGX", 2020, "90-TT-101", 18, 3, 12, 120);
        Truck truck2 = new Truck("Volvo", "FH16", 2021, "90-VV-202", 25, 4, 18, 110);

      
        Console.WriteLine("--- CARS ---");
        ShowAndCalculate(car1, 500);
        ShowAndCalculate(car2, 500);
        ShowAndCalculate(car3, 500);

        Console.WriteLine("\n--- MOTORCYCLES ---");
        ShowAndCalculateMoto(moto1, 300);
        ShowAndCalculateMoto(moto2, 300);

        Console.WriteLine("\n--- TRUCKS ---");
        ShowAndCalculateTruck(truck1, 800);
        ShowAndCalculateTruck(truck2, 800);
    }

 
    static void ShowAndCalculate(Car c, double dist)
    {
        c.ShowCarInfo();
        Console.WriteLine($"{dist} km üçün yanacaq xərci: {c.CalculateFuelCost(dist)} AZN\n");
    }

    static void ShowAndCalculateMoto(Motorcycle m, double dist)
    {
        m.ShowMotorcycleInfo();
        Console.WriteLine($"{dist} km üçün yanacaq xərci: {m.CalculateFuelCost(dist)} AZN\n");
    }

    static void ShowAndCalculateTruck(Truck t, double dist)
    {
        t.ShowTruckInfo();
        Console.WriteLine($"{dist} km üçün yanacaq xərci: {t.CalculateFuelCost(dist)} AZN\n");
    }
}