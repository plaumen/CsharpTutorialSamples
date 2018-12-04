using CsharpSamples.Common.Interfaces;
using CsharpSamples.Samples.Basics.Logic;
using System;

namespace CsharpSamples
{
    class Program
    {
        static void Main(string[] args)
        {
            ISample sample = new SwitchSample();
            sample.Run();

            Console.ReadLine();
        }
    }
}
