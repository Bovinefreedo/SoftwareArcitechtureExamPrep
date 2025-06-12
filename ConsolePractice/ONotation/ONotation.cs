using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePractice.ONotation
{
    public class ONotation
    {
        public static bool containsDuplicates1(int[] numbers) {
            for (int i = 0; i < numbers.Length; i++) {
                for (int j = 0; j < numbers.Length; j++) {
                    if (numbers[i] == numbers[j] && i != j) {
                        return true;
                    }
                }
            }
            return false;
        }

        public static bool containsDuplicates2(int[] numbers) {
            Array.Sort(numbers);
            for (int i = 0; i < numbers.Length - 1; i++) {
                if (numbers[i] == numbers[i + 1]) {
                    return true;
                }
            }
            return false;
        }

        public static bool containsDuplicates3(int[] numbers) {
            int nums = numbers.Length;
            HashSet<int> ints = new HashSet<int>();
            for (int i = 0; i < numbers.Length; i++) {
                ints.Add(numbers[i]);
            }
            if (ints.Count != nums) {
                return true;
            }
            return false;

        }

    }
}
