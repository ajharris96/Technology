using Microsoft.VisualStudio.TestTools.UnitTesting;
using Technology;

namespace TechnologyTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SmartPhoneProperlyImplementsComputer()
        {
            SmartPhone andrews = new SmartPhone("iOS", 2018, "Apple", "Xfinity");
            andrews.TurnOn();
            Assert.IsTrue(andrews.IsOn);

        }

        [TestMethod]
        public void SmartPhoneProperlyPlacesCall()
        {
            SmartPhone andrews = new SmartPhone("iOS", 2018, "Apple", "Xfinity");
            long number = 2154106595;
            string str = andrews.PlaceCall(number);
            Assert.IsTrue(str == "Placing call to 2154106595 with carrier, Xfinity, using OS, iOS");

        }
    }
}
