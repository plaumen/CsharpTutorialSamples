using CsharpSamples.Common.Interfaces;
using System;

namespace CsharpSamples.Samples.Basics.Types
{
    public class CastingNumbersSample : ISample
    {
        public void Run()
        {
            int myInt = int.MaxValue;
            long myLong = myInt;

            Console.WriteLine($"After implicit conversion:\nmyInt = {myInt} and myLong = {myLong}");

            myLong = long.MaxValue;
            myInt = (int)myLong;

            Console.WriteLine($"After casting long to int:\nmyInt = {myInt} and myLong = {myLong}");

            // code below will no work because there are no implicit and explicit conversions between int and string
            //string message = "Message in the bottle";
            //int messageAsInt = message;
            //int messageAsInt = (int)message;

            // OUTPUT
            // After implicit conversion:
            // myInt = 2147483647 and myLong = 2147483647
            // After casting long to int:
            // myInt = -1 and myLong = 9223372036854775807
        }
    }
}
