using System;
using System.Xml.Serialization;

namespace EmployeeSystem
{


    //Interface provides the rules(rule can be property or method), but it won't implement

    interface ISuppertTask
    {
        string getBonusAmount();
    }

    interface IContract
    {
        string WorkContarct();
    }
    interface ISoftwareEmployee
    {
        void task();
        void KT();
        void Location();

        void GetSalary(double salary);

    }

    //I would like to take the contract of EmployeeSystem
    class PermanentEmployee : ISoftwareEmployee, ISuppertTask
    {
        public void GetSalary(double salary)
        {
            Console.WriteLine($"Credited Salary: {salary}");
        }

        public void KT()
        {
            Console.WriteLine("Given KT");
        }



        public void task()
        {
            Console.WriteLine("Task is completed");
        }

        public string getBonusAmount()
        {
            return "30000";
        }


        public void Location()
        {
            Console.WriteLine("My Location is Banglore");
        }
    }

    class Freelancer : ISoftwareEmployee, IContract
    {
        public void GetSalary(double salary)
        {
            Console.WriteLine($"Credited Salary: {salary}");
        }

        public void KT()
        {
            Console.WriteLine("Given KT");
        }

        public void Location()
        {
            Console.WriteLine("My Location is Banglore");
        }

        public void task()
        {
            Console.WriteLine("Task is completed");
        }

        public string WorkContarct()
        {
            //Console.WriteLine("Worked on Contract Based");
            return "Worked on Contract Based";
        }


    }

 

    class Program
    {
        static void Main()
        {
            ISoftwareEmployee employee = new PermanentEmployee();
            employee.GetSalary(50000);

            ISoftwareEmployee freelance = new Freelancer();
            freelance.GetSalary(40000);

            ISoftwareEmployee permanentemployee = new PermanentEmployee();
        }
    }
}
