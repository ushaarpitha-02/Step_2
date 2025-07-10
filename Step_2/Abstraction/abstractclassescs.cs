using System;

namespace VehicleConfigurationSystem
{


    // Rule +  methodImplemention
    abstract class Vehicle
    {
        public string FuelType { get; set; }
        public int Capacity { get; set; }

        public abstract void Start();

        public abstract void Stop();

        public abstract void Engine();


        //Concrete methods
        public void ShowDetails()
        {
            Console.WriteLine($"Fuel Type: {FuelType}");
            Console.WriteLine($"Capacity: {Capacity} passengers");
        }

    }


    //Derive Class  or Child Class

    class Car : Vehicle
    {
        public override void Start()
        {

            Console.WriteLine("Car is starting with a key ignition.");
        }

        public override void Stop()
        {
            //throw new NotImplementedException();
            Console.WriteLine("Car has stopped.");
        }

        public override void Engine()
        {
            Console.WriteLine("Car engine is a 4-cylinder petrol engine.");
        }


        public void CarPurcahseDateandTime()
        {
            Console.WriteLine("12-06-2024:12:35:00");
        }

    }



    class Bike : Vehicle
    {
        public override void Engine()
        {
            Console.WriteLine("Bike engine is having 110cc.");
        }

        public override void Start()
        {
            Console.WriteLine("Bike has started");
        }

        public override void Stop()
        {
            Console.WriteLine("Bike has stopped.");
        }
    }

    class Program
    {
        public static void Main()
        {
           // Vehicle v = new Vehicle();

            Console.WriteLine("Car Details");
            Vehicle car1 = new Car()
            {
                FuelType = "petrol",
                Capacity = 5
            };
            car1.ShowDetails();
            Vehicle car = new Car();
            car.FuelType = "Diesel";
            car.Capacity = 7;
            car.Start();
            car.Engine();
            car.Stop();
            car.ShowDetails();
            Console.WriteLine("--------------------------");
            Console.WriteLine("Bike Details");
            Vehicle bike = new Bike();
            bike.FuelType = "Petrol";
            bike.Capacity = 2;
            bike.Start();
            bike.Engine();
            bike.Stop();
            bike.ShowDetails();




        }
    }


}