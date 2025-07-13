using System;
namespace BaseClass_Virtualmethodsandderivedclasswith_overridemethods
{
    class Animal          // Base class
    {
        public virtual void Speak()   //virtual methods
        {
            Console.WriteLine("The animal makes a sound.");
        }

        public virtual void Move()
        {
            Console.WriteLine("The animal moves.");
        }
    }

    class Dog : Animal    // Derived  class
    {
        public override void Speak()
        {
            Console.WriteLine("The dog barks.");
        }

        public override void Move()
        {
            Console.WriteLine("The dog runs.");
        }
    }
    class Cat : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("The cat sound mew mew");
        }
        public override void Move()
        {
            Console.WriteLine("The cat also move from one place to other");
        }
    }

    class Program
    {
        static void Main()
        {
            Animal generic = new Animal();
            generic.Speak();  
            generic.Move();   

            Animal myDog = new Dog();  
            myDog.Speak();   
            myDog.Move();   

            Animal myCat = new Animal();
            myCat.Speak();
            myCat.Move();
        }
    }
}