using System;
namespace BiryaniCart
{
    static class Utils
    {
        public static void ShowWelcomeMessage()
        {
          Console.WriteLine("🍽️ Welcome to the Biryani Cooking Essentials Cart!");
        }

        public static void ShowLine()
        {
           Console.WriteLine("-------------------------------------------------");
        }
    }

    class CartItem
    {
        public string ItemName;
        public int Quantity;
        public double Price;

        public CartItem(string itemName, int quantity, double price)
        {
            ItemName = itemName;
            Quantity = quantity;
            Price = price;
        }

        public double GetItemTotal()
        {
            return Quantity * Price;
        }

        public void ShowItem()
        {
          Console.WriteLine("🛍️ Item: " + ItemName + ", Qty: " + Quantity + ", Price: ₹" + Price + ", Total: ₹" + GetItemTotal());
        }
    }

    class CartManager
    {
        private CartItem[] cart = new CartItem[10];
        private int itemCount = 0;

        public bool AddItem(string name, int qty, double price)
        {
            if (qty <= 0 || price <= 0 || itemCount >= 10)
                return false;

            cart[itemCount] = new CartItem(name, qty, price);
            itemCount++;
            return true;
        }

        public void DisplayCart()
        {
            Console.WriteLine("\n🥘 Your Biryani Ingredients:");
            for (int i = 0; i < itemCount; i++)
            {
                cart[i].ShowItem();
            }
        }

        public void Checkout()
        {
            double total = CalculateTotal();
            Console.WriteLine("\nTotal before discount: ₹" + total);

            double finalAmount = CheckDiscount(total);
            Console.WriteLine("Total after discount (if any): ₹" + finalAmount);
        }

        private double CalculateTotal()
        {
            double total = 0;
            for (int i = 0; i < itemCount; i++)
            {
                total += cart[i].GetItemTotal();
            }
            return total;
        }

        private double CheckDiscount(double total)
        {
            if (total >=1300)
            {
                Console.WriteLine("🎉 You get a 20% discount for a grand Biryani feast!");
                return total * 0.8;
            }
            else if(total >=800)
                {
               Console.WriteLine("🎉 You get a 10% discount for a grand Biryani feast!");
                return total * 0.9;
            }
                
            {
               Console.WriteLine("No discount this time. Keep cooking! 👨‍🍳");
                return total;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Utils.ShowWelcomeMessage();
            CartManager biryaniCart = new CartManager();

            // 🧂 Add Biryani Ingredients
            biryaniCart.AddItem("Basmati Rice (1kg)", 1, 120.00);
            biryaniCart.AddItem("Chicken (1kg)", 1, 250.00);
            biryaniCart.AddItem("Biryani Masala", 1, 45.00);
            biryaniCart.AddItem("Curd", 1, 35.00);
            biryaniCart.AddItem("Mint Leaves", 1, 20.00);
            biryaniCart.AddItem("Fried Onions Pack", 1, 50.00);
            biryaniCart.AddItem("Ghee", 1, 180.00);
            biryaniCart.AddItem("Chicken Masala", 1, 50.00); 

            Utils.ShowLine();
            biryaniCart.DisplayCart();
            Utils.ShowLine();
            biryaniCart.Checkout();

           Console.WriteLine("\n🍛 Happy Cooking! Enjoy your delicious Biryani!");
        }
    }
}
