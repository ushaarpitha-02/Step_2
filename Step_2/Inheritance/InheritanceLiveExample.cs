using System;

class Employee
{
    public string Name { get; set; }
    public int EmployeeID { get; set; }
    public double BasicSalary { get; set; }

    public void DisplayDetails()
    {
        Console.WriteLine($"[Employee] Name: {Name}, ID: {EmployeeID}, Salary: {BasicSalary}");
    }
}

class Manager : Employee
{
    public double Bonus { get; set; }

    public double GetTotalSalary()
    {
        return BasicSalary + Bonus;
    }

    public void ShowManagerDetails()
    {
        Console.WriteLine($"[Manager] Name: {Name}, ID: {EmployeeID}, Basic Salary: {BasicSalary}, Bonus: {Bonus}, Total: {GetTotalSalary()}");
    }
}

class Developer : Employee
{
    public double ProjectAllowance { get; set; }

    public double GetTotalSalary()
    {
        return BasicSalary + ProjectAllowance;
    }

    public void ShowDeveloperDetails()
    {
        Console.WriteLine($"[Developer] Name: {Name}, ID: {EmployeeID}, Basic Salary: {BasicSalary}, Project Allowance: {ProjectAllowance}, Total: {GetTotalSalary()}");
    }
}

class Intern : Employee
{
    public double Stipend { get; set; }

    public void ShowInternDetails()
    {
        Console.WriteLine($"[Intern] Name: {Name}, ID: {EmployeeID}, Stipend: {Stipend}");
    }
}

class Program
{
    static void Main()
    {
        Manager mgr = new Manager
        {
            Name = "Usha Arpitha",
            EmployeeID = 101,
            BasicSalary = 60000,
            Bonus = 15000
        };
        mgr.ShowManagerDetails();

        Developer dev = new Developer
        {
            Name = "Vinitha",
            EmployeeID = 102,
            BasicSalary = 50000,
            ProjectAllowance = 10000
        };
        dev.ShowDeveloperDetails();

        Intern intern = new Intern
        {
            Name = "Dhatri",
            EmployeeID = 103,
            Stipend = 15000
        };
        intern.ShowInternDetails();

        Console.ReadLine();
    }
}
