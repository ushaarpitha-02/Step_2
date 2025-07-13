using System;
namespace Methodswith_Returntypes
{
    class Methods
    {
        public static int Add() //method1 with return type int
        {
            return 2 + 3;
        }
        public static short Sub() //method2 with return type short
        {
            return 3 - 2;
        }
        public static long Mul() //method3 with return type long
        {
            return 3 * 2;
        }
        public static float Div() //mehtod4 with return type float
        {
            return 3 / 2;
        }
        public static double Power() //mehtod5 with return type double
        {
            return 3 / 2;
        }
        public static decimal DecimalNumbers() //method6 with return type decimal
        {
            return 3.0978790M;
        }
        public bool IsSuccess() //method7 with return type bool
        {
            return true;
        }
        public static byte Num() //method8 with return type byte
        {
            return 23;
        }
        public static char Letter() //method9 with return type char
        {
            return 'A';
        }
        public static string[] Names() //methos10 with return type array
        {
            string[] names = { "Usha", "Arpitha","Vinitha","Vinni"};
            return names;
        }
        static void Main()
        {
            Console.WriteLine($"The addition is:{ Add()}");
            Console.WriteLine($"The subtraction is:{Sub()}");
            Console.WriteLine($"The multiplication is:{Mul()}");
            Console.WriteLine($"The division is:{Div()}");
            Console.WriteLine($"The double is:{Power()}");
            Console.WriteLine($"The decimal number is:{DecimalNumbers()}");
            Methods methods = new Methods();
            bool result = methods.IsSuccess();
            Console.WriteLine($"The success value is:{result}");
            Console.WriteLine($"The number is:{Num()}");
            Console.WriteLine($"The first letter of arpitha:{Letter()}");
            foreach (string name in Names())
            {
                Console.WriteLine(name);
            }
        }

    }
   
}