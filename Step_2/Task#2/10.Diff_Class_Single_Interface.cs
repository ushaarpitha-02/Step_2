using System;

namespace LaptopInterface
{
    interface ILaptop
    {
        void DisplayInfo();   // Every laptop will use this method implementatiojn
    }

    //Three different classes that implement ILaptop
    class GamingLaptop : ILaptop
    {
        public void DisplayInfo()
        {
            Console.WriteLine("Gaming Laptop");
            Console.WriteLine("Model : Acer Predator Helios 16");
            Console.WriteLine("CPU   : Intel Core i9");
            Console.WriteLine("GPU   : NVIDIA RTX 4080");
            Console.WriteLine("Price : Rupees.2,50,000\n");
        }
    }

    class BusinessLaptop : ILaptop
    {
        public void DisplayInfo()
        {
            Console.WriteLine("Business Laptop");
            Console.WriteLine("Model : Lenovo ThinkPad X1 Carbon");
            Console.WriteLine("CPU   : Intel Core i7");
            Console.WriteLine("GPU   : Integrated Iris Xe");
            Console.WriteLine("Price : Rupees.1,70,000\n");
        }
    }

    class StudentLaptop : ILaptop
    {
        public void DisplayInfo()
        {
            Console.WriteLine("Student Laptop");
            Console.WriteLine("Model : HP 15s");
            Console.WriteLine("CPU   : AMD Ryzen 5");
            Console.WriteLine("GPU   : Integrated Radeon");
            Console.WriteLine("Price : Rupees.55,000\n");
        }
    }

    class Program
    {
        static void Main()
        {
            // Create one object of each laptop type
            ILaptop[] laptops =
            {
                new GamingLaptop(),
                new BusinessLaptop(),
                new StudentLaptop()
            };

            Console.WriteLine("List of Laptops\n");
            //foreach (ILaptop lap in laptops)
            //    lap.DisplayInfo();
            laptops[0].DisplayInfo();
            laptops[1].DisplayInfo();
            laptops[2].DisplayInfo();


           
        }
    }
}

