using CsharpSamples.Common.Interfaces;
using System;

namespace CsharpSamples.Samples.Basics.Functions
{
    public class NamedParametersSample : ISample
    {
        public void Run()
        {
            _functionWithNamedParameters(depth: 10);

            // OUTPUT
            // Wow depth is different than 1.Now it is 10
            // width = 1, height = 1
        }

        void _functionWithNamedParameters(int width = 1, int height = 1, int depth = 1)
        {
            if (depth != 1)
            {
                Console.WriteLine($"Wow depth is different than 1. Now it is {depth}");
            }

            Console.WriteLine($"width = {width}, height = {height}");
        }
    }
}
