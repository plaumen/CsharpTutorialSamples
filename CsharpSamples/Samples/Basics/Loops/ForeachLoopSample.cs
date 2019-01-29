using CsharpSamples.Common.Interfaces;
using System;

namespace CsharpSamples.Samples.Basics.Loops
{
    public class ForeachLoopSample : ISample
    {
        public void Run()
        {
            MyNumber[] numbers = new[] { new MyNumber { Value = 1 }, new MyNumber { Value = 2 }, new MyNumber { Value = 3 } };

            var average = _countAverage(numbers);

            Console.WriteLine($"Average: {average}");
        }

        float _countAverage(MyNumber[] values)
        {
            var sum = 1.0f;
            foreach (var number in values)
            {
                sum += number.Value;
            }

            return sum / values.Length;
        }
    }

    public class MyNumber
    {
        public int Value;
    }
}
