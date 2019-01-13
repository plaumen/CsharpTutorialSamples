using CsharpSamples.Common.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace CsharpSamples.Samples.Basics.Collections
{
    public class YieldSample : ISample
    {
        public void Run()
        {
            foreach (var number in NumbersContainer.GetNumbers(4))
            {
                System.Console.WriteLine($"Handle: {number}");
            }

            // OUTPUT
            // Yield 0
            // Handle: 0
            // Yield 1
            // Handle: 1
            // Yield 2
            // Handle: 2
            // Yield 3
            // Handle: 3

            System.Console.WriteLine("\n");
            // note that numbersFiltered are enumerated in foreach not in declaration line
            var numbersFiltered = NumbersContainer.GetNumbers(5).Where(n => n < 3);
            foreach (var number in numbersFiltered)
            {
                System.Console.WriteLine($"Handle: {number}");
            }

            // OUTPUT 
            // Yield 0
            // Handle: 0
            // Yield 1
            // Handle: 1
            // Yield 2
            // Handle: 2
            // Yield 3
            // Break enumeration

            System.Console.WriteLine("\n");
            // note that numbersList is enumerated because ToList() is called.
            // So at first all values ale yielded then are handled
            var numbersList = NumbersContainer.GetNumbers(5).Where(n => n < 3).ToList();
            foreach (var number in numbersList)
            {
                System.Console.WriteLine($"Handle: {number}");
            }

            // OUTPUT
            // Yield 0
            // Yield 1
            // Yield 2
            // Yield 3
            // Break enumeration
            // Handle: 0
            // Handle: 1
            // Handle: 2
        }
    }

    public class NumbersContainer
    {
        public static IEnumerable<int> GetNumbers(int numbersCount)
        {
            for (int index = 0; index < numbersCount; index++)
            {
                if (index > 3)
                {
                    System.Console.WriteLine("Break enumeration");
                    yield break;
                }


                System.Console.WriteLine($"Yield {index}");
                yield return index;
            }
        }
    }
}
