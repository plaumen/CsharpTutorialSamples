using CsharpSamples.Common.Interfaces;
using CsharpSamples.Samples.Basics.Types;
using System;

namespace CsharpSamples
{
    class Program
    {
        static void Main(string[] args)
        {
            ISample sample = new ArraysSample();
            sample.Run();

            Console.ReadLine();
        }
    }
}
