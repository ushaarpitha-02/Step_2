using System;

namespace SimpleMobileExample
{
    // Interface 1: Calling
    interface ICaller
    {
        void MakeCall();
    }

    // Interface 2: Messaging
    interface IMessenger
    {
        void SendMessage();
    }

    // Class implementing both interfaces
    class MobilePhone : ICaller, IMessenger
    {
        public void MakeCall()
        {
            Console.Write("Enter mobile number to call: ");
            string number = Console.ReadLine();
            Console.WriteLine($"Calling {number}...\n");
        }

        public void SendMessage()
        {
            Console.Write("Enter mobile number: ");
            string number = Console.ReadLine();

            Console.Write("Enter your message: ");
            string message = Console.ReadLine();

            Console.WriteLine($"Message sent to {number}: {message}\n");
        }

        public void ShowStatus()
        {
            Console.WriteLine("Mobile is ON and working.\n");
        }
    }

    class Program
    {
        static void Main()
        {
            MobilePhone phone = new MobilePhone();

            while (true)                    
            {
                Console.WriteLine("\n--- Mobile Menu ---");
                Console.WriteLine("1. Show Mobile Status");
                Console.WriteLine("2. Make a Call");
                Console.WriteLine("3. Send a Message");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice (1‑4): ");

                string choice = Console.ReadLine();  
                Console.WriteLine();                

                switch (choice)                     
                {
                    case "1":
                        phone.ShowStatus();
                        break;

                    case "2":
                        phone.MakeCall();
                        break;

                    case "3":
                        phone.SendMessage();
                        break;

                    case "4":
                        Console.WriteLine("Exiting program...");
                        return;                     

                    default:
                        Console.WriteLine("Invalid option. Try again.");
                        break;
                }
            }
        }
    }
}