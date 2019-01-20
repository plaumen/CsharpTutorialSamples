using CsharpSamples.Common.Interfaces;
using System;

namespace CsharpSamples.Samples.Basics.ExtensionMethods
{
    public class ExtensionsSample : ISample
    {
        public void Run()
        {
            var ubuntu = OperatingSystems.Ubuntu;
            var windows10RS3 = OperatingSystems.Windows10RS3;

            if (ubuntu.IsUbuntu())
            {
                Console.WriteLine("Wow! Ubuntu is ubuntu");
            }

            if (windows10RS3.IsWindows())
            {
                Console.WriteLine("Wow! Windows10RS3 is windows");
            }

            // OUTPUT
            // Wow! Ubuntu is ubuntu
            // Wow! Windows10RS3 is windows
        }
    }

    public enum OperatingSystems
    {
        Unknown = 0,
        Windows = 100,
        Windows7 = 110,
        Windows8 = 120,
        Windows10 = 130,
        Windows10RS3 = 131,
        Linux = 200,
        Mint = 210,
        Ubuntu = 220
    }

    public static class Extensions
    {
        public static bool IsWindows(this OperatingSystems system)
        {
            return (int)system >= 100 && (int)system < 200;
        }

        public static bool IsUbuntu(this OperatingSystems system)
        {
            return system == OperatingSystems.Ubuntu;
        }
    }
}
