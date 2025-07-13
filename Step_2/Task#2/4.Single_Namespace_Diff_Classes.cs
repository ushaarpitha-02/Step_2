using System;
namespace StudentList
{
    class firstclass
    {
        public int id;
        public string name;
        public int age;
        public firstclass()
        {
            id = 1;
            name = "Usha";
            age = 6;
        }

    }
    class secondclass
    {
        public int id;
        public string name;
        public int age;
        public secondclass()
        {
            id = 2;
            name = "Arpitha";
            age = 7;
        }

    }
    class thirdclass
    {
        public int id;
        public string name;
        public int age;
        public thirdclass()
        {
            id = 3;
            name = "Vinitha";
            age = 8;
        }
    }
    class fourthclass
    {
        public int id;
        public string name;
        public int age;
        public fourthclass()
        {
            id = 4;
            name = "Vinni";
            age = 9;
        }

    }
    class Program
    {
        static void Main()
        {
            firstclass a = new firstclass();
            Console.WriteLine("_________FIRST CLASS________________");
            Console.WriteLine("ID:"+a.id);
            Console.WriteLine("Name"+a.name);
            Console.WriteLine("Age"+a.age);
            secondclass b = new secondclass();
            Console.WriteLine("_________SECOND CLASS________________");
            Console.WriteLine("ID:"+b.id);
            Console.WriteLine("Name" + b.name);
            Console.WriteLine("Age" + b.age);
            thirdclass c = new thirdclass();
            Console.WriteLine("_________THIRDSECOND CLASS________________");
            Console.WriteLine("ID:"+c.id);
            Console.WriteLine("Name" + c.name);
            Console.WriteLine("Age" + c.age);
            fourthclass f = new fourthclass();
            Console.WriteLine("_________FOURTH CLASS________________");
            Console.WriteLine("ID:"+f.id);
            Console.WriteLine("Name" + f.name);
            Console.WriteLine("Age" + f.age);
        }
    }

}
