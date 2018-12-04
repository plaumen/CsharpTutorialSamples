using CsharpSamples.Common.Interfaces;
using System;

namespace CsharpSamples.Samples.Basics.Types
{
    public class EnumSample : ISample
    {
        public void Run()
        {
            var testResult = TestResults.NotRun;

            Console.WriteLine($"Test result is {testResult}");

            int testResultAsInt = (int)testResult;

            Console.WriteLine($"Int test result is: {testResultAsInt}");

            doesTestRun(testResult);

            testResult = (TestResults)1;

            doesTestRun(testResult);

            Console.WriteLine($"{LongDerivedEnum.MaxValue} = {(long)LongDerivedEnum.MaxValue}");

            isItWindows(Systems.Linux);

            isItWindows(Systems.Windows10RS3);

            // OUTPUT
            // Test result is NotRun
            // Int test result is: 0
            // Does test run? False
            // Does test run? True
            // MaxValue = 9223372036854775807
            // Linux is not windows
            // Windows10RS3 is windows
        }

        void doesTestRun(TestResults testResult)
        {
            Console.WriteLine($"Does test run? {testResult > 0}");
        }

        void isItWindows(Systems system)
        {
            if ((int)system >= 100 && (int)system < 200)
            {
                Console.WriteLine($"{system} is windows");
                return;
            }

            Console.WriteLine($"{system} is not windows");

        }

    }

    enum TestResults
    {
        NotRun,

        Failed,

        Passed
    }

    enum LongDerivedEnum : long
    {
        Unknown,

        MaxValue = long.MaxValue
    }

    // If you expect that your enums list will expand
    // you can extract categories and assign values with large difference.
    // It will allow you to add status without worrying about logic of methods
    enum Systems
    {
        None = 0,

        Windows = 100,

        Windows10 = 110,

        Windows10RS3 = 111,

        Linux = 200
    }


}
