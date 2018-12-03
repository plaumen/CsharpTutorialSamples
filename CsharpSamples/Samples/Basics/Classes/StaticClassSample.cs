using CsharpSamples.Common.Interfaces;
using System;

namespace CsharpSamples.Samples.Basics.Classes
{
    public class StaticClassSample : ISample
    {
        public void Run()
        {
            var password = Utilities.GetPassword();

            Console.WriteLine($"Password is {password}");

            var moreComplicatedPassword = Utilities.GetMoreComplicatedPassword();

            Console.WriteLine($"More complicated password is {moreComplicatedPassword}");

            // OUTPUT 
            // Password is CompanyName123
            // More complicated password is CompanyName123@!#
        }
    }

    public static class Utilities
    {
        public static string GetPassword()
        {
            return "CompanyName123";
        }

        public static string GetMoreComplicatedPassword()
        {
            return passwordCore + "@!#";
        }

        private static string passwordCore = "CompanyName123";
    }
}
