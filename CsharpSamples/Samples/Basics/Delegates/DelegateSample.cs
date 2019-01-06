using CsharpSamples.Common.Interfaces;
using System;

namespace CsharpSamples.Samples.Basics.Delegates
{
    public class DelegateSample : ISample
    {
        private delegate int AddDelegate(int x, int y);

        private AddDelegate Add;

        public void Run()
        {
            Add = AddImplementation;
            var result = Add.Invoke(1, 2);
            Console.WriteLine($"Addition result is: {result}");

            Add = Calculator.Add;
            result = Add(1, 2);
            Console.WriteLine($"Addition result from calculator is: {result}");

            // OUTPUT
            // Addition result is: 3
            // Addition result from calculator is: 3
        }

        private int AddImplementation(int x, int y)
        {
            return x + y;
        }

        private static class Calculator
        {
            internal static int Add(int x, int y)
            {
                return x + y;
            }
        }
    }
}
