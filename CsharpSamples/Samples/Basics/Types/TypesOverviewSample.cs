using CsharpSamples.Common.Interfaces;
using System;

namespace CsharpSamples.Samples.Basics.Types
{
    public class TypesOverviewSample : ISample
    {
        public void Run()
        {
            bool defaultBool = default(bool);
            bool assignedBool = true;
            Console.WriteLine($"Default bool value is: {defaultBool}. Size of bool is {sizeof(bool)}");

            byte defaultByte = default(byte);
            byte assignedByte = 255;
            Console.WriteLine($"Default byte value is: {defaultByte}. Size of byte is {sizeof(byte)}");

            int defaultInt = default(int);
            int assignedInt = 12;
            Console.WriteLine($"Default int value is: {defaultInt}. Size of int is {sizeof(int)}");

            uint defaultUint = default(uint);
            uint assignedUint = 12u;
            Console.WriteLine($"Default uint value is: {defaultUint}. Size of uint is {sizeof(uint)}");

            float defaultFloat = default(float);
            float assignedFloat = 12.0f;
            Console.WriteLine($"Default float value is: {defaultFloat}. Size of float is {sizeof(uint)}");

            double defaultDouble = default(double);
            double assignedDouble = 12.0;
            Console.WriteLine($"Default double value is: {defaultDouble}. Size of double is {sizeof(double)}");

            long defaultLong = default(long);
            long assignedLong = 12l;
            Console.WriteLine($"Default long value is: {defaultLong}. Size of long is {sizeof(long)}");

            string defaultString = default(string);
            string assignedString = "Ala ma kota";
            Console.WriteLine($"Default string value is: {defaultString}. Size of string is undefined");

            // and many others... short, decimal, ulong...

            // OUTPUT (size in bytes):
            // Default bool value is: False.Size of bool is 1
            // Default byte value is: 0.Size of byte is 1
            // Default int value is: 0.Size of int is 4
            // Default uint value is: 0.Size of uint is 4
            // Default float value is: 0.Size of float is 4
            // Default double value is: 0.Size of double is 8
            // Default long value is: 0.Size of long is 8
            // Default string value is: . Size of string is undefined

            // Default string is null. It is why was not printed
        }
    }
}
