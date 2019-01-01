using CsharpSamples.Common.Interfaces;
using System;

namespace CsharpSamples.Samples.Basics.ValueAndReferenceTypes
{
    public class OutSample : ISample
    {
        public void Run()
        {
            int myValue;

            multiplyBy(out myValue);

            Console.WriteLine($"myValue = {myValue}");

            // OUTPUT
            // myValue = 40
        }

        private void multiplyBy(out int value, int multiplicator = 4)
        {
            value = 10;
            value = value * multiplicator;
        }
    }
}
