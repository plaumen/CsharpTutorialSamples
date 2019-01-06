using CsharpSamples.Common.Interfaces;
using System;

namespace CsharpSamples.Samples.Basics.Delegates
{
    public class PredicateSample : ISample
    {
        public void Run()
        {
            Predicate<int> isGreaterThan10Predicate = isGreaterThan10;

            var number = 11;
            var comparisonResult = isGreaterThan10(number);

            Console.WriteLine(comparisonResult ? $"{number} is greater than 10" : $"{number} is less or equal than 10");

            // OUTPUT
            // 11 is greater than 10
        }

        private bool isGreaterThan10(int x)
        {
            return x > 10;
        }
    }
}
