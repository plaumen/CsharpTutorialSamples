using CsharpSamples.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CsharpSamples.Samples.Basics.ExtensionMethods
{
    public class LinqExtensionsSample : ISample
    {
        public void Run()
        {
            var ints = new List<int> { 1, 2, 3 };
            var secondInt = ints.SecondOrDefaultInt();

            Console.WriteLine($"Second int is {secondInt}");

            // OUTPUT
            // Second int is 2

            secondInt = ints.SecondOrDefaut();
            Console.WriteLine($"Second int from generic method is {secondInt}");

            // OUTPUT
            // Second int from generic method is 2

            var words = new List<string> { "adam", "ewa", "kain", "abel" };
            var secondWord = words.SecondOrDefaut();
            Console.WriteLine($"Second word is: {secondWord}");

            // OUTPUT
            // Second word is: ewa    
        }
    }

    public static class LinqExtensions
    {
        public static int SecondOrDefaultInt(this IEnumerable<int> ints)
        {
            if (ints.Count() < 1)
                return default(int);

            return ints.ElementAt(1);
        }

        public static T SecondOrDefaut<T>(this IEnumerable<T> enumerable)
        {
            if (enumerable.Count() < 1)
                return default(T);

            return enumerable.ElementAt(1);
        }
    }
}
