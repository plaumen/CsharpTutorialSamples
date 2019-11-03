using CsharpSamples.Common.Interfaces;
using CsharpSamples.Samples.Basics.RegularExpressions;
using System;

namespace CsharpSamples
{
    class Program
    {
        static void Main(string[] args)
        {
            ISample sample = new RegexNamedGroupsSample();
            sample.Run();

            Console.ReadLine();
        }
    }
}
