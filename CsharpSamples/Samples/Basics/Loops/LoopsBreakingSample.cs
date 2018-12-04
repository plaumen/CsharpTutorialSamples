using CsharpSamples.Common.Interfaces;
using System;

namespace CsharpSamples.Samples.Basics.Loops
{
    public class LoopsBreakingSample : ISample
    {
        public void Run()
        {
            var numbers = new[] { 1, 2, 3, 4, 5, 6, 7 };

            foreachBreak(numbers);

            foreachContinue(numbers);

            // OUTPUT
            // Num is 1
            // Num is 2
            // Num is 3
            // Stop loop when num is 4
            // Num is 1
            // Num is 2
            // Num is 3 
            // Continue to next item
            // Continue to next item
            // Num is 6
            // Num is 7

        }

        void foreachBreak(int[] numbers)
        {
            foreach (var num in numbers)
            {
                if (num > 3)
                {
                    Console.WriteLine($"Stop loop when num is {num}");
                    break;
                }

                Console.WriteLine($"Num is {num}");

            }
        }

        void foreachContinue(int[] numbers)
        {
            foreach (var num in numbers)
            {
                if (num > 3 && num < 6)
                {
                    Console.WriteLine("Continue to next item");
                    continue;
                }

                Console.WriteLine($"Num is {num}");

            }
        }

    }
}
