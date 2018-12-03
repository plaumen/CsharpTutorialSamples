using CsharpSamples.Common.Interfaces;
using CsharpSamples.Samples.Basics.Functions;
using System;

namespace CsharpSamples
{
    class Program
    {
        static void Main(string[] args)
        {
            ISample sample = new StringMethodsSample();
            sample.Run();

            Console.ReadLine();
        }
    }
}
