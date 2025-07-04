using System;

namespace CookingExample
{

    static class KitchenTools
    {
        public static void GetUtensils()
        {
            Console.WriteLine("🧂 Getting pan, spatula, and bowl from the kitchen.");
        }

        public static void WashVegetables()
        {
            Console.WriteLine("🥕 Washing vegetables...");
        }
      
    }

    class DhosaRecipe
    {
        public string GetChefName()
        {
            return chefName;
        }

        private string mainIngredient;
        public const string DishName = "Masala Dhosa";
        private readonly string chefName;

        public bool IsSpicy { get; set; }
        public int SpicinessLevel { get;  set; }

        public DhosaRecipe(string chef)
        {
            chefName = chef;
            mainIngredient = "Rice and Urad Dal Batter";
            IsSpicy = false;
        }

        public void PrepareIngredients()
        {
            Console.WriteLine("🥣 Mixing ingredients for batter...");
            KitchenTools.WashVegetables();
        }

        public void SetSpiceLevel(int level)
        {
            SpicinessLevel = level;
            IsSpicy = level > 5;
            Console.WriteLine($"🌶️ Spice level set to: {level}");
        }

        public bool CheckIfReady(bool isBatterFermented)
        {
            if (!isBatterFermented)
            {
                Console.WriteLine("⏳ Batter not ready. Ferment it overnight.");
                return false;
            }

            Console.WriteLine("✅ Batter is ready to make dhosas!");
            return true;
        }

        public void StartCooking(int type)
        {
            Console.WriteLine("🔥 Starting to cook...");

            switch (type)
            {
                case 1:
                    Console.WriteLine("Cooking Plain Dhosa.");
                    break;
                case 2:
                    Console.WriteLine("Cooking Masala Dhosa with potato stuffing.");
                    break;
                case 3:
                    Console.WriteLine("Cooking Cheese Dhosa.");
                    break;
                default:
                    Console.WriteLine("Unknown Dhosa Type. Making default Masala Dhosa.");
                    break;
            }

            if (IsSpicy)
            {
                Console.WriteLine("Adding extra chilies based on your spice preference.");
            }
            else
            {
                Console.WriteLine("Making it mild as per your spice level tolorence.");
            }
        }

        public void ServeDhosas(int count)
        {
            for (int i = 1; i <= count; i++)
            {
                Console.WriteLine($"🍽️ Serving dhosa #{i}.");
            }

            int remaining = count;
            while (remaining > 0)
            {
                Console.WriteLine($"Remaining dhosas to serve: {remaining}");
                remaining--;
            }
        }

       
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;//I used this for emoji display option

            Console.WriteLine("👨‍🍳 Welcome to the Cooking Debugger App!");

            Console.Write("Enter your name (Chef's name): ");
            string chefName = Console.ReadLine();

            DhosaRecipe dhosa = new DhosaRecipe(chefName);

            KitchenTools.GetUtensils();
            dhosa.PrepareIngredients();

            Console.Write("Enter spice level (0-10): ");
            int spiceLevel = int.Parse(Console.ReadLine());
            dhosa.SetSpiceLevel(spiceLevel);

            Console.Write("Is the batter fermented? (yes/no): ");
            string batterInput = Console.ReadLine();
            bool isReady = dhosa.CheckIfReady(batterInput.ToLower() == "yes");//I used this just incase the user may give YES or yes or Yes anything in the form of word yes may be lower or upper 

            if (isReady)
            {
                Console.WriteLine("Select Dhosa Type:\n1. Plain\n2. Masala\n3. Cheese");
                Console.Write("Enter choice (1/2/3): ");
                int dhosaType = int.Parse(Console.ReadLine());

                dhosa.StartCooking(dhosaType);

                Console.Write("Enter number of dhosas to serve: ");
                int count = int.Parse(Console.ReadLine());

                dhosa.ServeDhosas(count);

                Console.WriteLine($"👨‍🍳 Dhosa is prepared by: {dhosa.GetChefName()}");
                Console.WriteLine("✅ Cooking is completed. Enjoy your meal!");
            }
            else
            {
                Console.WriteLine($"❌ Dhosa could not be prepared by Chef {dhosa.GetChefName()}.As dhosa batter is not fermented properly.");
                Console.WriteLine("🙏 Sorry to say about this.Please visit again. ");
            }
        }
    }
}
