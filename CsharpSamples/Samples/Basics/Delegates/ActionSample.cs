using CsharpSamples.Common.Interfaces;
using System;

namespace CsharpSamples.Samples.Basics.Delegates
{
    public class ActionSample : ISample
    {
        public void Run()
        {
            Action doNothingAction = doNothing;
            doNothingAction();

            Action<int[]> printNumbersAction = NumbersPrinter.PrintNumbers;

            var numbers = new int[] { 1, 2, 3, 5, 7 };
            printNumbersAction.Invoke(numbers);

            // OUTPUT
            // I am in DoNothing() method
            // Numbers are: 1,2,3,5,7
        }

        private void doNothing()
        {
            Console.WriteLine("I am in DoNothing() method");
        }

        private static class NumbersPrinter
        {
            internal static void PrintNumbers(int[] numbers)
            {
                Console.WriteLine("Numbers are: " + string.Join(",", numbers));
            }
        }
    }
}
