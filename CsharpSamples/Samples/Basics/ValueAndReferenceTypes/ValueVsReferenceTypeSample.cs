using CsharpSamples.Common.Interfaces;
using System;

namespace CsharpSamples.Samples.Basics.ValueAndReferenceTypes
{
    public class ValueVsReferenceTypeSample : ISample
    {
        public void Run()
        {
            swapValueTypeValues();
            swapReferenceTypeValues();

            // OUTPUT
            // x = 5
            // x.Value = 10
        }

        private void swapValueTypeValues()
        {
            int x = 5;
            int y = 4;

            y = x;
            y = 10;
            Console.WriteLine($"x = {x}");
        }

        private void swapReferenceTypeValues()
        {
            var x = new IntContainer { Value = 5 };
            var y = new IntContainer { Value = 4 };

            y = x;
            y.Value = 10;
            Console.WriteLine($"x.Value = {x.Value}");
        }
    }

    class IntContainer
    {
        public int Value { get; set; }
    }
}
