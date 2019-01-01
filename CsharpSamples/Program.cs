using CsharpSamples.Common.Interfaces;
using CsharpSamples.Samples.Basics.ValueAndReferenceTypes;
using System;

namespace CsharpSamples
{
    class Program
    {
        static void Main(string[] args)
        {
            ISample sample = new OutSample();
            sample.Run();

            Console.ReadLine();
        }
    }
}
