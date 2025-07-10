using System;
namespace CompileTimePolymorphism
{
    class TravelFareCalculator
    {
        public double CalculateFare(double distance, string mode)
        {
            if (mode == "Flight")
            {
                return distance * 100;
            }
            else if (mode == "Train")
            {
                return distance * 30;
            }
            else if (mode == "Bus")
            {
                return distance * 25;
            }
            else
            {
                return 0;
            }
        }
        public double CalculateFare(double distance, string mode, string classtype)
        {
            double fare = CalculateFare(distance, mode);
            if (classtype == "Business")
            {
                fare = fare * 20;
                return fare;
            }
            else if (classtype == "Economy")
            {
                fare = fare * 30;
                return fare;
            }
            else
            {
                return 0;
            }
        }
        public double CalculateFare(double distance, string mode, string passengertype, int age)
        {
            double fare1 = CalculateFare(distance, mode);
            if (passengertype == "Child"&&age<=8)
            {
                fare1 = fare1 * 0.5;
                return fare1;
            }
            else if (passengertype == "Senior citizen"&&age>=60)
            {
                fare1 = fare1 * 0.7;
                return fare1;
            }
            else if (passengertype == "Disabled person")
            {
                fare1 = fare1 * 0.3;
                return fare1;
            }
            else
            {
                return 0;
            }
        }
    }
    class Fare
    {
        static void Main()
        {
            TravelFareCalculator travelFareCalculator = new TravelFareCalculator();
            Console.WriteLine($"Flight ticket price:{travelFareCalculator.CalculateFare(100, "Flight")}");
            Console.WriteLine($"Train ticket price:{travelFareCalculator.CalculateFare(100, "Train")}");
            Console.WriteLine($"Bus ticket price:{travelFareCalculator.CalculateFare(100, "Bus")}");
            Console.WriteLine($"Flight ticket price:{travelFareCalculator.CalculateFare(100, "Flight","Economy")}");
            Console.WriteLine($"Train ticket price:{travelFareCalculator.CalculateFare(100, "Train","Business")}");
            Console.WriteLine($"Bus ticket price:{travelFareCalculator.CalculateFare(100, "Bus","Economy")}");
            Console.WriteLine($"Flight ticket price:{travelFareCalculator.CalculateFare(100, "Flight", "Disabled person",67)}");
            Console.WriteLine($"Train ticket price:{travelFareCalculator.CalculateFare(100, "Train","Child",5)}");
            Console.WriteLine($"Bus ticket price:{travelFareCalculator.CalculateFare(100, "Bus","Senior citizen",65)}");

        }
    }
}