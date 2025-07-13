using System;
using System.Globalization;
using System.Net;
using System.Xml.Linq;
namespace DiffReturnTypesDiffParameters
{
    class DiffReturnTypes_DiffParameters
    {
       
        public static int Method1()
        {
            return 25;
        }
        public static string Method2(int a)
        {

            return "The value of a:" + a;
        }
        public static double Method3(int a, int b)
        {
            int c = a + b;
            return c;

        }
        public static ushort Method4(int n)
        {
            return (ushort)n;
        }
        public static bool Method5(string message, string message1)
        {

            if (message.Contains("u") && message1.Contains("v"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public char Method6(string name)
        {
            if (name.StartsWith("u"))
            {
                return 'y';
            }
            else
            {
                return 'n';
            }

        }
        public float Method7(float value)
        {
            return value;
        }
        public static void Method8(int number)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(number + " * " + i + " = " + (number * i));
            }
        }


       //public static DiffReturnTypes_DiffParameters Method9(DiffReturnTypes_DiffParameters number)
       // {
       //     return number;
       // }
        public static string Method10(string name)
        {
            if (name.Contains("a"))
            {
                return $"Name contains a in:{name}";
            }
            else
            {
                return $"Name does not contains a in:{name}";
            }
        }
        class Methods
        {
            public int Id;
            public string Name;
            public Methods(int id, string name) //method9
            {
                Id = id;
                Name = name;
            }
        }
        static void Main()
        {
            Console.WriteLine($"{Method1()}");
            Console.WriteLine($"{Method2(20)}");
            Console.WriteLine($"{Method3(20, 30)}");
            Console.WriteLine($"{Method4(89)}");
            Console.WriteLine($"{Method5("usha", " vinitha")}");
            DiffReturnTypes_DiffParameters m = new DiffReturnTypes_DiffParameters();
            Console.WriteLine($"{m.Method6("usha")}");
            Console.WriteLine($"{m.Method7(309.9f)}");
            Method8(1);
            Methods n1 = new Methods(101, "Usha");
            Console.WriteLine($"Id: {n1.Id}");
            Console.WriteLine($"Name: {n1.Name}");
            Console.WriteLine($"{Method10("Teju")}");
        }
    }
}
