using CsharpSamples.Common.Interfaces;
using CsharpSamples.Samples.Basics.Linq;
using System;

namespace CsharpSamples
{
    class Program
    {
        static void Main(string[] args)
        {
            ISample sample = new CountAndAnySample();
            sample.Run();

            Console.ReadLine();
        }
    }
}
