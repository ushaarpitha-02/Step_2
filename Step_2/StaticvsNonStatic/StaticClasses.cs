using System;

static class Logger
{
    static string logedapp = "Whatsapp";
    static string loginreason = "to text her friend";


    static string Logedapp { get; set; }

    static Logger()
    {
        Logger.Logedapp = "Instagram";
    }
    static void logmessage(string count, string message)
    {
        Console.WriteLine($"{DateTime.Now} [{count}-{message}]");

    }
    static void loginfo(string message)
    {
        Logger.logmessage("INFO", message);
    }
    static void logwarning(string message)
    {
        Logger.logmessage("Warning", message);
    }
    static void logerror(string message)
    {
        Logger.logmessage("ERROR", message);
    }
    static void logcomplete(string message)
    {
        Logger.logmessage("App is closing",message);
    }
       
    static void Main()
    {
        string str = Logger.logedapp;
        Console.WriteLine(str);
        string str1 = Logger.loginreason;
        Console.WriteLine(str1);
        Console.WriteLine($"logged application is {Logger.logedapp} and login reason is {Logger.loginreason}");

        Logger.loginfo("Application is opened");
        Logger.logwarning("Your pin is incorrect.Please enter the correct pin");
        Logger.logerror("Your application is locked,please try again after sometime");
        Logger.logcomplete("Your application is closed");

    }
}