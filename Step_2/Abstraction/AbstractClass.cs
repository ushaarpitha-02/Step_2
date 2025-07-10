using System;
namespace onlineshopping
{
    abstract class ShoppingApps   //base class
    {
        public string product {  get; set; }
        public string Category {  get; set; }
        public string customersupport {  get; set; }

        public abstract void sigin();
        public abstract void searchforproduct();
        public abstract void addtocart();
        public abstract void sigout();

        public void ShowShoppingDetails()
        {
            Console.WriteLine($"[Product] is:{product}");
            Console.WriteLine($"[Category] is:{Category}");
            Console.WriteLine($"[Available or not]:{customersupport}");
           
        }
      

    }
    class Amazon:ShoppingApps
    {
        
        public override void sigin()
        {
            Console.WriteLine("Customer sigend in successfully");
        }
        public override void searchforproduct()
        {
            Console.WriteLine("Customer is searching for the product");
        }
        public override void addtocart()
        {
            Console.WriteLine("Product is added to cart");
        }


        public override void sigout()
        {
            Console.WriteLine("Customer signed out successfully");

        }
    }
    class Flipkart : ShoppingApps
    {
        public override void sigin()
        {
            Console.WriteLine("Customer sigend in successfully");
        }
        public override void searchforproduct()
        {
            Console.WriteLine("Customer is searching for the product");
        }
        public override void addtocart()
        {
            Console.WriteLine("Product is added to cart");
        }


        public override void sigout()
        {
            Console.WriteLine("Customer signed out successfully");

        }
    }
    class Savana : ShoppingApps
    {
        public override void sigin()
        {
            Console.WriteLine("Customer sigend in successfully");
        }
        public override void searchforproduct()
        {
            Console.WriteLine("Customer is searching for the product");
        }
        public override void addtocart()
        {
            Console.WriteLine("Product is added to cart");
        }


        public override void sigout()
        {
            Console.WriteLine("Customer signed out successfully");

        }
    }
    class Shopping
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Amazon app");
            ShoppingApps amazon = new Amazon();
            amazon.sigin();
            amazon.searchforproduct();
            amazon.addtocart();
            amazon.sigout();
            amazon.product = "Joggers";
            amazon.customersupport = "Available";
            amazon.Category = "Western for women";
            amazon.ShowShoppingDetails();


            Console.WriteLine("Welcome to Flipkart app");
            ShoppingApps flipkart=new Flipkart();
            flipkart.sigin();
            flipkart.searchforproduct();
            flipkart.addtocart();
            flipkart.sigout();
            flipkart.product = "Jeans";
            flipkart.customersupport = "Available";
            flipkart.Category = "Western for women";
            flipkart.ShowShoppingDetails();



            Console.WriteLine("Welcome to Savana app");
            ShoppingApps savana = new Savana();
            savana.sigin();
            savana.searchforproduct();
            savana.addtocart();
            savana.sigout();
            savana.product = "Grinder";
            savana.customersupport = "Available";
            savana.Category = "Home Appliances";
            savana.ShowShoppingDetails();

        }
    }
}
