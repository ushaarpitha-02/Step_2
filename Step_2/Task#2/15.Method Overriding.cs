using System;

namespace Orders_Online
{
    class Order        // Base class
    {
        protected double price = 500; // base product price

        public virtual void TrackStatus()
        {
            Console.WriteLine("Order status: Processing at warehouse.");
        }

        public virtual double CalculateTotal()
        {
            Console.WriteLine("Calculating total in base Order class...");
            return price;  // base price without any extra charge
        }
    }

    class OnlineOrder : Order    // Derived class
    {
        private double shippingCharge = 50;

        public override void TrackStatus()
        {
            Console.WriteLine("Online Order status: Shipped via courier, tracking available.");
        }

        public override double CalculateTotal()
        {
            Console.WriteLine("Calculating total in OnlineOrder class with shipping charge...");
            return price + shippingCharge;
        }
    }
    class OfflineOrder : Order
    {
        private double deliveryCharge = 100;
        public override void TrackStatus()
        {
            Console.WriteLine("offline order statuc:Shipped via person,tracking is shown.");
        }
        public override double CalculateTotal()
        {
            Console.WriteLine("Claculating offline order in total with delivery charges");
            return price + deliveryCharge;
        }
    }



    class Program
    {
        static void Main()
        {
            // Base class object
            Order regularOrder = new Order();
            regularOrder.TrackStatus();
            Console.WriteLine($"Regular Order Total: {regularOrder.CalculateTotal()}");

            Console.WriteLine();

            // Derived class object
            OnlineOrder onlineOrder = new OnlineOrder();
            onlineOrder.TrackStatus();
            Console.WriteLine($"Online Order Total: {onlineOrder.CalculateTotal()}");

            Console.WriteLine();

            // Base class reference pointing to derived class object
            OfflineOrder offlineOrder = new OfflineOrder();
            offlineOrder.TrackStatus();     // Runtime polymorphism
            Console.WriteLine($"Offline Order Total: {offlineOrder.CalculateTotal()}");
        }
    }
}

