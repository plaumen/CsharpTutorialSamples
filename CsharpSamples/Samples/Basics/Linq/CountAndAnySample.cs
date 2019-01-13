using CsharpSamples.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CsharpSamples.Samples.Basics.Linq
{
    public class CountAndAnySample : ISample
    {
        public void Run()
        {
            var emptyNumbersList = new List<int>();
            var listContainsNumbers = emptyNumbersList.Any();
            Console.WriteLine(listContainsNumbers ? "List contains numbers" : "List does not contain numbers");

            var manyNumbersList = new List<int> { 1, 2, 1, 2, 3, 1, 2, 3, 4 };
            var listHasAny4 = manyNumbersList.Any(n => n == 4);
            Console.WriteLine(listHasAny4 ? "List has 4's" : "List does not have 4's");

            var numberOf3s = manyNumbersList.Count(n => n == 3);
            Console.WriteLine($"List has {numberOf3s} 3's");

            // OUTPUT
            // List does not contain numbers
            // List has 4's
            // List has 2 3's
        }
    }
}
