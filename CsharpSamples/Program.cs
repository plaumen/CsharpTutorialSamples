using CsharpSamples.Common.Interfaces;
using CsharpSamples.Samples.Basics.ExtensionMethods;
using System;

namespace CsharpSamples
{
    class Program
    {
        static void Main(string[] args)
        {
            ISample sample = new ExtensionsSample();
            sample.Run();

            Console.ReadLine();
        }
    }
}
