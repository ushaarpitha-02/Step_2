using System;

namespace AbstractClass_bothMembers
{
   
    abstract class ElectricalDevice
    {
        public string Name { get; }
        public double Voltage { get; }  
        public double Current { get; }  

        protected ElectricalDevice(string name, double voltage, double current)
        {
            Name = name;
            Voltage = voltage;
            Current = current;
        }

        //ABSTRACT MEMBER (no body)  
        public abstract void Describe();

        //NON‑ABSTRACT MEMBER (already implemented)
        public double CalculatePower()
        {
            return Voltage * Current;  
        }

        // A non‑abstract method
        public void ShowPower()
        {
            Console.WriteLine($"Power of {Name}: {CalculatePower()} W \n");
        }
    }
    class LightBulb : ElectricalDevice
    {
        public LightBulb(string name, double voltage, double current) : base(name, voltage, current) { }

        //override Describe()
        public override void Describe()
        {
            Console.WriteLine($"{Name}:simple light bulb.");
        }
    }

    class CeilingFan : ElectricalDevice
    {
        public CeilingFan(string name, double voltage, double current) : base(name, voltage, current) { }


        public override void Describe()
        {
            Console.WriteLine($"{Name}:ceiling fan.");
        }
    }

    class Program
    {
        static void Main()
        {
            ElectricalDevice bulb = new LightBulb("Living‑Room Bulb", 230, 0.3); 
            ElectricalDevice fan = new CeilingFan("Bedroom Fan", 230, 0.5); 

            bulb.Describe();
            bulb.ShowPower();    

            fan.Describe();
            fan.ShowPower();

        }
    }
}
