using System;
class Home    //I am taking home as class name 
{

    string gatecolour = "Black";
    string doorcolour = "Brown";
    string windowcolour = "Light brown";
    string floorcolour = "White";
    string wallcolour = "Pink";
  
    public Home()
    {
        Console.WriteLine($"gatecolour is {gatecolour},doorcolour is {doorcolour},windowcolour is {windowcolour},floorcolour is {floorcolour},wallcolour is {wallcolour}");
        this.gatecolour = "Green";
        this.doorcolour = "Red";
        this.windowcolour = "Blue";
        this.floorcolour = "Lavender";
        this.wallcolour = "Sky blue";
        Console.WriteLine($"gatecolour is {gatecolour},doorcolour is {doorcolour},windowcolour is {windowcolour},floorcolour is {floorcolour},wallcolour is {wallcolour}");

    }
    public Home(string gatecolour, string doorcolour, string windowcolour, string floorcolour, string wallcolour)
    {
        this.gatecolour = gatecolour;
        this.doorcolour = doorcolour;
        this.windowcolour = windowcolour;
        this.floorcolour = floorcolour;
        this.wallcolour = wallcolour;

        Console.WriteLine($"{this.gatecolour},{this.doorcolour},{this.windowcolour},{this.floorcolour},{this.wallcolour}");
    }
    private Home(string gatecolour,string doorcolour)
    {
        this.gatecolour = gatecolour;
        this.doorcolour = doorcolour;
        Console.WriteLine($"Gate colour is {this.gatecolour} and Door colour is {this.doorcolour}");
    }
   


    static void Main()
    {
        Home home = new Home();
        //this.gatecolour = "White";//We cannot use this keyword inside a main method,can use in constructor classes
        Home home1 = new Home("violet","indigo","blue","green","yellow");
        Home home2 = new Home("purple", "seablue");
    }

}