using System;
namespace Technology
{
    public class Computer : AbstractEntity
    {
        public string OperatingSystem { get; set; }
        public int Year { get; }
        public string Manufacturer { get; }
        public bool IsOn = false;


        public Computer(string OS, int year, string manufacturer)
        {
            OperatingSystem = OS;
            Year = year;
            Manufacturer = manufacturer;
        }


        public void TurnOn()
        {
            IsOn = true;
        }

        public void TurnOff()
        {
            IsOn = false;
        }

    }
}
