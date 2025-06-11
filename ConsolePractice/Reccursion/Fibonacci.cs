using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePractice.Reccursion
{
    public class Fibonacci
    {
        //Make a reccursive method that calculates the nth number in the Fibonacci sequence.
        public static int fib(int n)
        {
            if (n < 1)
                return 0;
            if (n==1)
                return 1;
            return fib(n - 1) + fib(n - 2);
        }


        //Make a reccursive method that calculates the the n first numbers in the Fibonacci sequence.
        //Hint: use both listOfFib(int n) and listOfFib(int n, int[] array)
        public static int[] listOfFib(int n)
        {
            int[] array = new int[n];
            return listOfFib(n, array);
        }

        public static int[] listOfFib(int n, int[] array)
        {
            return new int[0];
        }
    }
}
