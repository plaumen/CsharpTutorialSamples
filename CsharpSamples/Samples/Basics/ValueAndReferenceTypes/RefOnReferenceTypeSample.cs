using CsharpSamples.Common.Interfaces;

namespace CsharpSamples.Samples.Basics.ValueAndReferenceTypes
{
    class RefOnReferenceTypeSample : ISample
    {
        public void Run()
        {
            ValueContainer myValue = new ValueContainer { Value = 5 };
            System.Console.WriteLine($"myValue = {myValue.Value}");

            multiplyBy(myValue);
            System.Console.WriteLine($"myValue after multiplication without ref = {myValue.Value}");

            refMultiplyBy(ref myValue);
            System.Console.WriteLine($"myValue after multiplication with ref = {myValue.Value}");

            // OUTPUT
            // myValue = 5
            // myValue after multiplication without ref = 20
            // myValue after multiplication with ref = 80

            // COMMENT
            // Behavior for refererence type is the same with or without ref usage
        }

        private void refMultiplyBy(ref ValueContainer value, int multiplicator = 4)
        {
            value.Value = value.Value * multiplicator;
        }

        private void multiplyBy(ValueContainer value, int multiplicator = 4)
        {
            value.Value = value.Value * multiplicator;
        }
    }

    class ValueContainer
    {
        public int Value { get; set; }
    }
}
