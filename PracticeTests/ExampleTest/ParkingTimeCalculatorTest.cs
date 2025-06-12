using ConsolePractice.Eksample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeTests.ExampleTest
{
    [TestClass]
    public class ParkingTimeCalculatorTest
    {
        [TestMethod]
        public void parkingExpirationTest() {
            ParkingTimeCalculator timeCalculator = new();
            DateTime start1 = new DateTime(2025, 1, 1, 13, 0, 0);
            DateTime end1 = new DateTime(2025, 1, 1, 14, 0, 0);
            DateTime end2 = new DateTime(2025, 1, 1, 17, 0, 0);
            Assert.AreEqual(timeCalculator.parkingExpiration(5,start1),end1);
            Assert.AreEqual(timeCalculator.parkingExpiration(20, start1), end2);
        }
    }
}
