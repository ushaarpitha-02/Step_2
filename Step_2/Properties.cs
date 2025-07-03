using System;
class EventManager
{

    string eventname = "haldi";
    string eventlocation = "bangalore";
    string eventorganizer = "Usha";
    string eventdate = "1st june";


    string Eventname { get; set; }
    string Eventlocation { get; set; }
    string Eventorganizer { get; set; }
    string Eventdate { get; set; }

    static void Main()
    {
        
        EventManager events=new EventManager();
        Console.WriteLine($"Event name is {events.eventname}\nEvent location is {events.eventlocation}\nEvent organizer is {events.eventorganizer}\nEvent date is on {events.eventdate}");

        events.Eventname = "mehendi";
        events.Eventlocation = "hyderabad";
        events.Eventorganizer = "Arpitha";
        events.Eventdate = "2nd june";

        Console.WriteLine($"Event name is {events.Eventname}\nEvent location is {events.Eventlocation}\nEvent organizer is {events.Eventorganizer}\nEvent date is on {events.Eventdate}");
    }

}








