using System;
using TestManager.Enums;
using TestManager.Interfaces;
using TestManager.Tests;

namespace CsharpSamples
{
    class Program
    {
        static void Main(string[] args)
        {
            ITest testToRun = TestsFactory.Get(TestType.DeviceTest);
            testToRun.Run();

            Console.ReadLine();
        }
    }
}
