using ConsolePractice.Reccursion;
namespace PracticeTests.ConsolePractice.Reccursion
{
    [TestClass]
    public class FibonacciTest
    {
        [TestMethod]
        public void fibTest()
        {
            Assert.AreEqual(1, Fibonacci.fib(1));
            Assert.AreEqual(1, Fibonacci.fib(2));
            Assert.AreEqual(2, Fibonacci.fib(3));
            Assert.AreEqual(3, Fibonacci.fib(4));
            Assert.AreEqual(5, Fibonacci.fib(5));
            Assert.AreEqual(8, Fibonacci.fib(6));
            Assert.AreEqual(13, Fibonacci.fib(7));
        }

        [TestMethod]
        public void listOfFibTest()
        {
            int[] firstFive = new int[] { 1, 1, 2, 3, 5 };
            int[] firstEight = new int[] { 1, 1, 3, 5, 8, 13 };
            Assert.AreEqual(firstFive, Fibonacci.listOfFib(5));
            Assert.AreEqual(firstEight, Fibonacci.listOfFib(8));
        }
    }
}