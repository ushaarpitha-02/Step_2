using System;
using System.Net;
namespace StaticvsNonStaticInstantiate
{
    public static class Staticclass
    {
        public static void PrintMessage()
        {
            Console.WriteLine("This is a static class method");
        }

    }
    public class NonStaticclass
    {
        public void PrintMessage()
        {
            Console.WriteLine("This is a non static class method");
        }
        public static void Printmessage1()
        {
            Console.WriteLine("Static method in nonstatic class method");
        }
    }
    public class Program
    {
        static void Main()
        {
            Staticclass.PrintMessage();
            NonStaticclass nonStaticclass = new NonStaticclass();
            nonStaticclass.PrintMessage();
            NonStaticclass.Printmessage1();
        }
    }
}
   