using CsharpSamples.Common.Interfaces;
using CsharpSamples.Samples.Basics.Files;
using System;

namespace CsharpSamples
{
    class Program
    {
        static void Main(string[] args)
        {
            ISample sample = new FileSample();
            sample.Run();

            Console.ReadLine();
        }
    }
}
