using CsharpSamples.Common.Interfaces;
using CsharpSamples.Samples.Basics.Collections;
using System;

namespace CsharpSamples
{
    class Program
    {
        static void Main(string[] args)
        {
            ISample sample = new QueueSample();
            sample.Run();

            Console.ReadLine();
        }
    }
}
