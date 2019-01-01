using CsharpSamples.Common.Interfaces;
using CsharpSamples.Samples.Basics.Exceptions;
using System;

namespace CsharpSamples
{
    class Program
    {
        static void Main(string[] args)
        {
            ISample sample = new ExceptionsSample();
            sample.Run();

            Console.ReadLine();
        }
    }
}
