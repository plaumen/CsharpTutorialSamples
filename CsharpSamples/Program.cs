using CsharpSamples.Common.Interfaces;
using CsharpSamples.Samples.Basics.Delegates;
using System;

namespace CsharpSamples
{
    class Program
    {
        static void Main(string[] args)
        {
            ISample sample = new LambdaSample();
            sample.Run();

            Console.ReadLine();
        }
    }
}
