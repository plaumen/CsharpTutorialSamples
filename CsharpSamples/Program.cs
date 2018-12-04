using CsharpSamples.Common.Interfaces;
using CsharpSamples.Samples.Basics.Loops;
using System;

namespace CsharpSamples
{
    class Program
    {
        static void Main(string[] args)
        {
            ISample sample = new LoopsBreakingSample();
            sample.Run();

            Console.ReadLine();
        }
    }
}
