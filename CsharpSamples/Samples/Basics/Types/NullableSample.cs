using CsharpSamples.Common.Interfaces;
using System;

namespace CsharpSamples.Samples.Basics.Types
{
    class NullableSample : ISample
    {
        public void Run()
        {
            int? nullableInt = null;

            Console.WriteLine($"Nullable int has value? {nullableInt.HasValue}");

            nullableInt = 12;
            Console.WriteLine($"Nullable int value is? {nullableInt.Value}");

            // OUTPUT:
            // Nullable int has value? False
            // Nullable int value is? 12
        }
    }
}
