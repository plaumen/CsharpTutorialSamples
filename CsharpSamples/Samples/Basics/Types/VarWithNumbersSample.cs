using CsharpSamples.Common.Interfaces;
using System;

namespace CsharpSamples.Samples.Basics.Types
{
    class VarWithNumbersSample : ISample
    {
        public void Run()
        {
            calcAverageFromStronglyTypedInts();

            calcAverageOfWronglyAssignedVars();

            calcAverageOfVarsInitializedAsFloats();
        }

        void calcAverageFromStronglyTypedInts()
        {
            int value1 = 2;
            int value2 = 3;

            // var is used to show that division of ints gives int in result
            var average = (value1 + value2) / 2;

            // 2.0f in denominator forces calculation on floats. Integer used in denominator will cause calculation on ints.
            float realAverage = (value1 + value2) / 2.0f;

            Console.WriteLine($"Average is {average}.\nReal average: {realAverage}\n");

            // Output:
            // Average is 2.
            // Real average: 2,5

        }

        void calcAverageOfWronglyAssignedVars()
        {
            // Values specified as vars but assignment specific for ints. Compiler will know that value1 and value2 are ints.
            var value1 = 2;
            var value2 = 3;

            var average = (value1 + value2) / 2;
            float realAverage = (value1 + value2) / 2.0f;

            Console.WriteLine($"Average is {average}.\nReal average: {realAverage}\n");

            // Output:
            // Average is 2.
            // Real average: 2,5
        }

        void calcAverageOfVarsInitializedAsFloats()
        {
            // Values specified as vars but assignment specific for floats. Compiler will know that value1 and value2 are floats.
            var value1 = 2.0f;
            var value2 = 3.0f;

            var average = (value1 + value2) / 2;
            float realAverage = (value1 + value2) / 2.0f;

            Console.WriteLine($"Average is {average}.\nReal average: {realAverage}\n");

            // Output:
            // Average is 2,5.
            // Real average: 2,5
        }


    }
}
