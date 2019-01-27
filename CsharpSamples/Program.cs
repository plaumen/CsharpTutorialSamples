using CsharpSamples.Common.Interfaces;
using CsharpSamples.Samples.Basics.Serialization;
using System;

namespace CsharpSamples
{
    class Program
    {
        static void Main(string[] args)
        {
            ISample sample = new SerializationSample();
            sample.Run();

            Console.ReadLine();
        }
    }
}
