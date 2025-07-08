
using System;

namespace Gadgets
{


    interface IOperation
    {
        void PowerOn();
        void PowerOff();
        void SwitchallApps();

        void IncreaseButton();
        void DecreaseButton();
        void OpenwithPasscode();




    }
    

    interface IOperationModel
    {
        string getModel();
    }
   

    interface IOperationPrice
    {
        string getPrice();
    }

    class Mobile : IOperation, IOperationModel
    {
        public void DecreaseButton()
        {
            Console.WriteLine("Volume Decreased");
            
        }

        public string getModel()
        {
            return ("Samsung");
        }

        public void IncreaseButton()
        {
            Console.WriteLine("Volume increased");
        }

        public void OpenwithPasscode()
        {
            Console.WriteLine("Enter passcode to open");
        }

        public void PowerOff()
        {
            Console.WriteLine("Mobile is switched off");

        }

        public void PowerOn()
        {
            Console.WriteLine("Mobile is switched on");
        }

        public void SwitchallApps()
        {
            Console.WriteLine("Mobile is switching between all the apps");
        }
    }

    class Laptop : IOperation, IOperationPrice
    {
        public void DecreaseButton()
        {
            Console.WriteLine("Decreased");
        }

        public string getPrice()
        {
            return ("90k");
        }

        public void IncreaseButton()
        {
            Console.WriteLine("Increased");
        }

        public void OpenwithPasscode()
        {
            Console.WriteLine("Openwithpasscode");
        }

        public void PowerOff()
        {
            Console.WriteLine("Shutted down");
        }

        public void PowerOn()
        {
            Console.WriteLine("Laptop is ON");
        }

        public void SwitchallApps()
        {
            Console.WriteLine("Laptop is accessible to move from one app to other app");
        }
    }



   
    class Program
    {
        static void Main()
        {
            IOperation mobile = new Mobile();
            mobile.PowerOn();
            mobile.PowerOff();
            mobile.DecreaseButton();
            mobile.IncreaseButton();
            mobile.OpenwithPasscode();
            mobile.SwitchallApps();
            IOperationModel modelname = new Mobile();
            string model = modelname.getModel();
            Console.WriteLine("Model of the mobile is:"+model);


            IOperation laptop = new Laptop();
            laptop.PowerOn();
            laptop.DecreaseButton();
            laptop.IncreaseButton();
            laptop.OpenwithPasscode();
            laptop.SwitchallApps();
            laptop.PowerOff();

            IOperationPrice laptopprice = new Laptop();
            string price = laptopprice.getPrice();
            Console.WriteLine("Cost of the laptop is:"+price);

          

        }
    }

}
