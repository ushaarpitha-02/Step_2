using System;
namespace StaticvsNonstaticClasses
{
    public static class Staticclass
    {
        public static void Static()
        {
            string Message1 = "Welcome to static method";
            Console.WriteLine(Message1);
        }

    }
    public class Nonstaticclass
    {
        public void Nonstatic()
        {
            string Message2 = "Welocme to non static method";
            Console.WriteLine(Message2);
        }
        public static void class1()
        {
            Console.WriteLine("class1");


          
        }

    }
    class Program
    {

        static void Main()
        {

            Staticclass.Static();
            Nonstaticclass.class1();
            Nonstaticclass nonstatic=new Nonstaticclass();
            nonstatic.Nonstatic();

        }
    }



}