using System;
class EmployeeDetails
{
    int empid = 101;
    string empname = "Usha";
    int empage = 25;
    string empjoindate = "May-23-2025";

    
    static void Main()
    {
        EmployeeDetails student = new EmployeeDetails()
        {
            empid = 103,
            empname = "Arpitha"
        };
        showdetails(student);
        EmployeeDetails employeeDetails = new EmployeeDetails();
        Console.WriteLine(employeeDetails.empid);

        employeeDetails.empid = 102;
        employeeDetails.empname = "Vnitha";
        employeeDetails.empage = 26;
        employeeDetails.empjoindate = "Jun-1-2025";
        Console.WriteLine(employeeDetails.empage);

        employeeDetails.ShowMessage("ush", 24);
        string name = ShowDetails("ushaaa", 103);



    }

    static string ShowDetails(string name, int id)
    {
        Console.WriteLine($"Name is {name} id is {id}");
        return name;
    }
    void ShowMessage(string empname, int empid)
    {
        Console.WriteLine($"name is {empname} id is {empid}");
    }
    static void showdetails(EmployeeDetails emp)
    {
        Console.WriteLine($"emp name is {emp.empname} emp id is {emp.empid}");
    }
}