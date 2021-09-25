using System;

namespace Technology
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            SmartPhone andrews = new SmartPhone("iOS", 2018, "Apple", "Xfinity");
            Console.WriteLine(SmartPhone.MakeCall());
            andrews.TurnOn();
            Console.WriteLine(andrews.IsOn);
            Laptop sahvas = new Laptop("OSX", 2015, "Apple", 15.5);
            sahvas.TurnOn();
            Console.WriteLine(sahvas.IsOn);
            Console.WriteLine(sahvas.IsOpen);
            Console.WriteLine(andrews.Id);
            Console.WriteLine(sahvas.Id);


        }
    }
}
