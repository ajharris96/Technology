using System;
namespace Technology
{
    public class Laptop : Computer
    {
        public readonly double DisplaySize;
        public bool IsOpen = false;

        public Laptop(string OS, int year, string manufacturer, double size) : base(OS ,year ,manufacturer)
        {
            DisplaySize = size;
        }

        public void Open()
        {
            IsOpen = true;
        }

        public void Close()
        {
            IsOpen = false;
        }




    }
}
