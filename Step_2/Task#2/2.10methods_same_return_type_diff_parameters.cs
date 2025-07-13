using System;
using System.Net;
namespace MethodswithDiffParameters
{
    class MethodswithParameters
    {
        public static string Method1()
        {
            return "Nothing";
        }
        public static string Method2(int a)
        {

            return "The value of a:" + a;
        }
        public static string Method3(int a,int b)
        {
            int c = a + b;
            return "The addition of a and b is:"+ c;

        }
        public static string Method4(string message)
        {
            return message;
        }
        public static string Method5(string message,string message1)
        {
            return message+message1;
        }
        public string Method6(int age,string name)
        {
            return $"The age is {age} and name is {name}";
        }
        public string Method7(int age,string name,string course)
        {
            return $"The age is {age} and name is {name} and belongs to the course {course}";
        }
        public string Method8(int id,string employee, string project,string manager)
        {
            return $"The id of the employee {id} with name {employee} having this project {project} comes under the manager {manager}";
        }
        public static string Method9(int a,int b)
        {
            if(a+b>=99 && a+b<=999)
            {
                return $"This is a 3 digit number";
            }
            else
            {
                return $"This is not a 3 digit number";
            }

        }
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
        static void Main()
        {
            Console.WriteLine($"{Method1()}");
            Console.WriteLine($"{Method2(20)}");
            Console.WriteLine($"{Method3(20,30)}");
            Console.WriteLine($"{Method4("Hello")}");
            Console.WriteLine($"{Method5("Hey"," Hi")}");
            MethodswithParameters m= new MethodswithParameters();
            Console.WriteLine($"{m.Method6(25,"Usha")}");
            Console.WriteLine($"{m.Method7(30,"Arpitha","Csharp")}");
            Console.WriteLine($"{m.Method8(11101, "Vinitha", "Bayer","Arpitha")}");
            Console.WriteLine($"{Method9(29,8)}");
            Console.WriteLine($"{Method10("Teju")}");
        }
    }
}