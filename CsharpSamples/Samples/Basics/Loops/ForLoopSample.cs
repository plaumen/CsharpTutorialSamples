using CsharpSamples.Common.Interfaces;
using System;

namespace CsharpSamples.Samples.Basics.Loops
{
    public class ForLoopSample : ISample
    {
        public void Run()
        {
            var integers = new[] { 1, 2, 3, 4, 5, 6 };

            var average = _countAverage(integers);

            Console.WriteLine($"Average: {average}");

            _forOnObjects();

            // OUTPUT
            // Average: 3,5
            // Value increased to 1
            // Value increased to 2
            // Value increased to 3
        }

        float _countAverage(int[] values)
        {
            var sum = 0;
            for (int index = 0; index < values.Length; index++)
            {
                sum += values[index];
            }

            return (1.0f * sum) / values.Length;
        }

        // this way of for loop usage is not common! To use it this way use foreach instead
        void _forOnObjects()
        {
            for (ValueBox vb = new ValueBox(); vb.Value < 3; vb.IncreaseValue())
            { }
        }


    }

    class ValueBox
    {
        public int Value = 0;

        public void IncreaseValue()
        {
            Value++;
            Console.WriteLine($"Value increased to {Value}");
        }

    }
}
