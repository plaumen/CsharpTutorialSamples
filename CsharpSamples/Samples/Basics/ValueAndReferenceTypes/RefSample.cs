using CsharpSamples.Common.Interfaces;

namespace CsharpSamples.Samples.Basics.ValueAndReferenceTypes
{
    public class RefSample : ISample
    {
        public void Run()
        {
            int myValue = 5;
            System.Console.WriteLine($"myValue = {myValue}");

            multiplyBy(myValue);
            System.Console.WriteLine($"myValue after multiplication without ref = {myValue}");

            refMultiplyBy(ref myValue);
            System.Console.WriteLine($"myValue after multiplication with ref = {myValue}");

            // OUTPUT 
            // myValue = 5
            // myValue after multiplication without ref = 5
            // myValue after multiplication with ref = 20
        }

        private void refMultiplyBy(ref int value, int multiplicator = 4)
        {
            value = value * multiplicator;
        }

        private void multiplyBy(int value, int multiplicator = 4)
        {
            value = value * multiplicator;
        }
    }
}
