using CsharpSamples.Common.Interfaces;
using System;

namespace CsharpSamples.Samples.Basics.Functions
{
    public class ConstructorsSample : ISample
    {
        public void Run()
        {
            var sample1 = new ClassWithManyConstructors();

            Console.WriteLine();

            var sample2 = new ClassWithManyConstructors("create me now");

            Console.WriteLine();

            var sample3 = new ClassWithManyConstructors("no message", "why?");

            // OUTPUT
            // I am default, parametersless ctor!
            //
            // I am default, parametersless ctor!
            // Ctor taking message: create me now
            //
            // I am default, parametersless ctor!
            // Ctor taking message: no message
            // Additional info is why?
        }
    }

    class ClassWithManyConstructors
    {
        public ClassWithManyConstructors()
        {
            Console.WriteLine("I am default, parametersless ctor!");
        }

        public ClassWithManyConstructors(string message)
            : this()
        {
            Console.WriteLine($"Ctor taking message: {message}");
        }

        public ClassWithManyConstructors(string message, string additionalInfo)
            : this(message)
        {
            Console.WriteLine($"Additional info is {additionalInfo}");
        }
    }


}
