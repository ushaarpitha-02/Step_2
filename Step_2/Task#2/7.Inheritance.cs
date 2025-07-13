using System;
namespace Inheritance
{
    class Office
    {
        public int EmpID { get; set; }
        public string EmpName { get; set; }
        public int EmpSalary { get; set; }
        public Office()
        {
            this.EmpID = 0;
            this.EmpName = string.Empty;
            this.EmpSalary = 0;
        }
        public void getOfficeDetails()
        {
            Console.WriteLine("Employee ID: " + EmpID);
            Console.WriteLine("Employee Name: " + EmpName);
            Console.WriteLine("Employee Salary:" + EmpSalary);
        }
    }
    class Junior_Developer : Office
    {
        public string Technology { get; set; }

        public Junior_Developer()
        {
            Technology = "C#";
        }

        public void ShowJuniorDetails()
        {
            getOfficeDetails();
            Console.WriteLine("Technology: " + Technology);
            Console.WriteLine("Level: Junior Developer");
        }

    }
    class Senior_Developer : Office
    {
        public int ExperienceYears { get; set; }

        public Senior_Developer()
        {
            ExperienceYears = 5;
        }

        public void ShowSeniorDetails()
        {
            getOfficeDetails();
            Console.WriteLine("Experience: " + ExperienceYears + " years");
            Console.WriteLine("Level: Senior Developer");
        }
    }
    class OfficeDetails
    {

        static void Main()
        {
            Console.WriteLine("________Junior developer details_________");

            Junior_Developer jd = new Junior_Developer();
            jd.EmpID = 101;
            jd.EmpName = "Usha";
            jd.EmpSalary = 30000;
            jd.Technology = "C#";
            jd.ShowJuniorDetails();

            Console.WriteLine("________Senior developer details_________");

            Senior_Developer sd = new Senior_Developer();
            sd.EmpID = 201;
            sd.EmpName = "Arpitha";
            sd.EmpSalary = 60000;
            sd.ExperienceYears = 8;
            sd.ShowSeniorDetails();
        }
    }

}
