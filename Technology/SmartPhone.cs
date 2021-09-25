using System;
namespace Technology
{
    public class SmartPhone : Computer
    {
        public string CellularCarrier { get; set; }


        public SmartPhone(string OS, int year, string manufacturer, string cellCarrier) : base(OS, year, manufacturer)
        {
            CellularCarrier = cellCarrier;
        }

        public static string MakeCall()
        {
            return "Placing a call...";
        }

        public string PlaceCall(long phoneNumber)
        {
            return "Placing call to " + phoneNumber + " with carrier, " + CellularCarrier + ", using OS, " + OperatingSystem;
        }

    }
}
