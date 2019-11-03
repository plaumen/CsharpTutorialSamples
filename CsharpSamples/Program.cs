using CsharpSamples.Common.Interfaces;
using CsharpSamples.Samples.Basics.RegularExpressions;
using CsharpSamples.Samples.Intermediate.Type;
using System;

namespace CsharpSamples
{
    class Program
    {
        static void Main(string[] args)
        {
            ISample sample = new IsOperatorSample();
            sample.Run();

            Console.ReadLine();
        }
    }
}
