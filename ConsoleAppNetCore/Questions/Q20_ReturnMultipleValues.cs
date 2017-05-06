using System;
using System.Linq;

namespace ConsoleAppNetCore.Questions
{
    public class Q20_ReturnMultipleValues
    {
        private struct MinMax
        {
            public int max;
            public int min;
        }

        public static void Run()
        {
            var myArray = new int[] { 12, 34, 56, 90 };
            var results = MultipleReturns(myArray);
            int arrMin = results.min;
            int arrMax = results.max;

            Console.WriteLine("Array min is {0} and max is {1}", arrMin, arrMax);
        }

        private static MinMax MultipleReturns(int[] arr)
        {
            return new MinMax
            {
                min = arr.Min(),
                max = arr.Max(),
            };
        }
    }
}