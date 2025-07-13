using System;

namespace NonStaticClass_StaticMember
{
    class SoftwareDeveloper//non static class
    {
        //static fields or members
        public static string CompanyName = "Misard Solutions";
        public static int TotalDevelopers = 0;

        public static void ShowCompanyStats()
        {
            Console.WriteLine($"Company: {CompanyName}");
            Console.WriteLine($"Total developers so far: {TotalDevelopers}\n");
        }

        //instance fields & methods 
        public string Name { get; }
        public string PrimarySkill { get; }

        public SoftwareDeveloper(string name, string skill)
        {
            Name = name;
            PrimarySkill = skill;
            TotalDevelopers++;
        }

        public void ShowProfile()
        {
            Console.WriteLine($"Developer: {Name}");
            Console.WriteLine($"Skill    : {PrimarySkill}\n");
        }

        public void WorkOn(string task)
        {
            Console.WriteLine($"{Name} is working on '{task}' using {PrimarySkill}.\n");
        }
    }


    class Program
    {
        static void Main()
        {
            SoftwareDeveloper.ShowCompanyStats();

            SoftwareDeveloper dev1 = new SoftwareDeveloper("Arpitha", "C#");
            SoftwareDeveloper dev2 = new SoftwareDeveloper("Usha", "JavaScript");
            SoftwareDeveloper dev3 = new SoftwareDeveloper("Vinitha", "HTML");

            dev1.ShowProfile();
            dev2.ShowProfile();
            dev3.ShowProfile();

            dev1.WorkOn("API's");
            dev2.WorkOn("Angular");
            dev3.WorkOn("Front end");

            SoftwareDeveloper.ShowCompanyStats();
        }
    }
}
