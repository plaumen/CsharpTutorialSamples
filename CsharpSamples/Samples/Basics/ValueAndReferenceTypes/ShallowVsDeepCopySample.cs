using CsharpSamples.Common.Interfaces;
using System;

namespace CsharpSamples.Samples.Basics.ValueAndReferenceTypes
{
    public class ShallowVsDeepCopySample : ISample
    {
        public void Run()
        {
            var test = new Test { Name = new Name("Test") };
            var testShallowCopy = test.ShallowCopy();
            testShallowCopy.Name.Value = "Shallow copy test";

            Console.WriteLine($"Shallow copy test name: {testShallowCopy.Name}\nTest name: {test.Name}\n\n");

            var testDeepCopy = test.DeepCopy();
            testDeepCopy.Name.Value = "Deep copy";

            Console.WriteLine($"Deep copy test name: {testDeepCopy.Name}\nTest name: {test.Name}");

            // OUTPUT
            // Shallow copy test name: Shallow copy test
            // Test name: Shallow copy test
            //
            //
            // Deep copy test name: Deep copy
            // Test name: Shallow copy test
        }
    }

    class Test : ICloneable
    {
        public Name Name { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }


        internal Test ShallowCopy()
        {
            // creates new object Test. References to members are kept.
            return (Test)this.Clone();
        }

        internal Test DeepCopy()
        {
            // creates new object Test. References to members are not kept.
            var testDeepCopy = (Test)this.Clone();
            testDeepCopy.Name = (Name)this.Name.Clone();

            return testDeepCopy;
        }
    }

    class Name : ICloneable
    {
        public Name(string value)
        {
            Value = value;
        }

        public string Value { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public override string ToString()
        {
            return this.Value;
        }
    }



}
