using System;
class Mall //base class
{
   
    public string Movies { get; set; }
    public string Gaming { get; set; }
    public string ClothShopping { get; set; }
    public string GroceriesShopping { get; set; }

    public void ShowMallDetails()
    {
        Console.WriteLine($"[Movies] {Movies},[Gaming] {Gaming},[ClothShopping] {ClothShopping},[GroceriesShopping] {GroceriesShopping}");
    }
    class BrookfeildMall:Mall
    {
        public string Art {  get; set; }
        public string CommonThings()
        {
            Art = "Painting";
            return Art;

        }
       public void Showbrookemall()
        {

            Console.WriteLine($"[Movies] {Movies},[Art] {CommonThings()}");
        }


    }
    class LuluMall : Mall
    {
        public string Exhibition { get; set; }
        public void ShowLuluMall()
        {
            Console.WriteLine($"[Gaming] {Gaming}, [Exhibition] {CommonThings()}");

        }


        public string CommonThings()
        {
            Exhibition = "Science exhi";
            return Exhibition;
        }
    }
    class MallofAsia : Mall
    {
        public string Nature { get; set; }
        public void ShowMallofAsia()
        {
            Console.WriteLine($"[ClothShopping] {ClothShopping},[GroceriesShopping] {GroceriesShopping},[Nature] {CommonThings()}");

        }
        public string CommonThings()
        {
            Nature = "Cool breezes";
            return Nature;

        }
    }
    class Program
    {
        static void Main()
        {
            BrookfeildMall brooke = new BrookfeildMall
            {
                Movies = "tollywood",
                

            };

            brooke.Showbrookemall();


            LuluMall lulu = new LuluMall
            {
                Gaming = "Games"
            };
            lulu.ShowLuluMall();

            MallofAsia asian = new MallofAsia
            {
                GroceriesShopping = "groceries",
                ClothShopping = "clothes"
            };
            asian.ShowMallofAsia();
        }
    }
}

