using System;
namespace simplecode
{
    class Bodmas
    {
        public static int a = 100;
        public static int b = 200;
        public static int c = 300;

        public static void Addition(int a,int b,int c)
        {
            int d = a + b + c;
            Console.WriteLine($"The addition of a,b,c is:{d}");
            //Bodmas.Subtraction(90, 30, 20);//reference is required for non static methods
        }
        public void Subtraction(int a,int b,int c)
        {
            int e = c - b - a;
            Console.WriteLine($"The subtraction of a,b,c is:{e}");
            Bodmas.Addition(19,87,98);//reference is not required as it is a static method
            
            Bodmas.Division();

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
                Bodmas.Addition(10, 20, 30);
                Division();
                Addition(a, 20, 30);
                Bodmas.Addition(a, b, c);
                Bodmas.Division();

                Bodmas bodmas = new Bodmas();
                bodmas.Subtraction(200,39,20);


            }
        }
    }
}
