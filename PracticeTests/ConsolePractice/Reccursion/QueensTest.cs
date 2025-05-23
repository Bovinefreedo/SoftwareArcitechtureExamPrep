using ConsolePractice.Reccursion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeTests.ConsolePractice.Reccursion
{
    [TestClass]
    public class QueensTest
    {
        [TestMethod]
        public void QueensNTest(){
            Queens queens = new Queens();
            Assert.AreEqual(1, queens.QueensN(1));
            Assert.AreEqual(92, queens.QueensN(8));
            Assert.AreEqual(724, queens.QueensN(10));
        }

    }
}
