using System;
namespace NonStaticclasses
{
    class NonStaticclass
    {
        public string str = "Usha";
        public string str1 = "Arpitha";
        public string str2 = "Usha Arpitha";



        string Str { get; set; }
        string Str1 { get; set; }
        string Str2 { get; set; }

        public NonStaticclass()
        {
           
            this.Str = "Vinitha";
            this.Str1 = "Vinni";
            this.Str2 = "VinithaVinni";
            Console.WriteLine(Str);
            Console.WriteLine(Str1);
            Console.WriteLine(Str2);
        }
        public NonStaticclass(string name)

        {
            this.str = name;
            Console.WriteLine(name);
        }
    }
    public class Program
    {
        static void Main()
        {
            NonStaticclass nonStaticclass1 = new NonStaticclass();

            NonStaticclass nonStaticclass = new NonStaticclass("Usha");



        }
    }
}

