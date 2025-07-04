using System;
namespace StaticandNonStaticMember
{
    public static class studentregister
    {
        public static  int studentcount=0;

        public static void logmessage(string message)
        {
            System.Console.WriteLine($"[LOG]{message}");
            studentcount++;
        }

        public static int GetCount()
        {
            return studentcount;
        }

    }
    public  class studentregister1
    {
        public static int studentcount = 0;

        public  void logmessage(string message)
        {
            System.Console.WriteLine($"[LOG]{message}");
            studentcount++;
        }

        public  int GetCount()
        {
            return studentcount;
        }

    }
    class Program
    {
        static void Main()
        {
            studentregister.logmessage("Usha is present in the class");
            studentregister.logmessage("Arpitha is present in the class");
            Console.WriteLine($"Total number of students present in the class is:{studentregister.GetCount()}");

            studentregister1 studentregister1 = new studentregister1();
            studentregister1.logmessage("Usha is present in the class");
            studentregister1.logmessage("Arpitha is present in the class");
            Console.WriteLine($"Total number of students present in the class is:{studentregister1.GetCount()}");
        }

    }

}