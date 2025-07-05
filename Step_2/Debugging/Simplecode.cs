using System;
using System.Net;
namespace simplecode
{
    class Bodmas
    {
        public static int a = 100;
        public static int b = 200;
        public static int c = 300;
        public static int w = 90;
        public static int Multiplication()
        {
            int k = a * b;
            Console.WriteLine($"{k}");
            return k;

        }
        public static void Addition()
        {
            int d = a + b + c;
            Console.WriteLine($"The addition of a,b,c is:{d}");
            //Bodmas.Subtraction(90, 30, 20);//reference is required for non static methods
        }
        public void Subtraction(int a,int b,int c)
        {
            int e = c - b - a;
            Console.WriteLine($"The subtraction of a,b,c is:{e}");
            //Bodmas.Addition(19,87,98);//reference is not required as it is a static method
            
            Bodmas.Division();
            Bodmas.Addition();

        }
        public static int Division()
        {
            
            int f = c / a;
            Console.WriteLine($"The division is:{f}");
            return f;
        }
        class Program
        {
            static void Main()
            {
                Multiplication();
                //Bodmas.Addition();

                Division();
                //SAddition();
                Bodmas.Addition();
                Bodmas.Division();

                Bodmas bodmas = new Bodmas();
                bodmas.Subtraction(200,39,20);
                Bodmas.Multiplication();



            }
        }
    }
}
