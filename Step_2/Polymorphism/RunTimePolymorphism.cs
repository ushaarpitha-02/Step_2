using System;
namespace RunTimePolymorphism
{
   class FoodItem
    {
        public int quantity {  get; set; }

        public virtual void Prepare()
        {
            Console.WriteLine("Preparing the food item you selected");
        }
        public virtual int CalculatePrice()
        {
            return 0;
        }
    }
    class Pizza:FoodItem
    {
        public override void Prepare()
        {
            Console.WriteLine("Preparing pizza with cheese and your selected toppings");
        }
        public override int CalculatePrice()
        {
            return 299;
        }

    }
    class Burger : FoodItem
    {
        public override void Prepare()
        {
            Console.WriteLine("Preparing burger of your choice");
        }
        public override int CalculatePrice()
        {
            return 199;
        }

    }
    class Frenchfries:FoodItem
    {
        public override void Prepare()
        {
            Console.WriteLine("Preparing french fries with periperi masala");
        }
        public override int CalculatePrice()
        {
            return 99;
        }

    }
    class Order
    {
        static void Main()
        {
            double totalprice = 0;
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Ordered Pizza");
            Console.WriteLine("-----------------------------------");
            FoodItem food = new Pizza();
            food.Prepare();
            food.quantity = 3;
            int Pizzatotal= food.CalculatePrice()*food.quantity;
            Console.WriteLine($"Number of Pizza {food.quantity}\nPizza total price is {Pizzatotal}");
            totalprice = totalprice + Pizzatotal;

            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Ordered Burger");
            Console.WriteLine("-----------------------------------");
            FoodItem fooditem =new Burger();
            fooditem.Prepare();
            fooditem.quantity = 2;
            int Burgertotal = fooditem.CalculatePrice() * food.quantity;
            Console.WriteLine($"Number of Burger {fooditem.quantity}\nBurger total price is {Burgertotal}");
            totalprice= totalprice + Burgertotal;

            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Ordered french fries");
            Console.WriteLine("-----------------------------------");
            FoodItem item =new Frenchfries();
            item.Prepare();
            item.quantity = 2;
            int Friestotal = item.CalculatePrice() * food.quantity;
            Console.WriteLine($"Number of Frenchfries is {food.quantity}\nFrenchfries total price is {Friestotal}");
            totalprice=totalprice+ Friestotal;

            Console.WriteLine("-----------------------------------");
            Console.WriteLine($"Total bill is:{totalprice}");
            Console.WriteLine("-----------------------------------");






        }
    }
}