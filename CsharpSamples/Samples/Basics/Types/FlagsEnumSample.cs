using CsharpSamples.Common.Interfaces;
using System;

namespace CsharpSamples.Samples.Basics.Types
{
    public class FlagsEnumSample : ISample
    {
        public void Run()
        {
            Console.WriteLine("\n#1 Flags for Linux and MacOs are set");
            var systemCompatibility = SystemCompatibility.Linux | SystemCompatibility.MacOs;

            canRunOnSystem(systemCompatibility);

            Console.WriteLine("\n#2 Windows flag is added");
            systemCompatibility = systemCompatibility | SystemCompatibility.Windows;

            canRunOnSystem(systemCompatibility);

            Console.WriteLine("\n#3 Linux flag is removed");
            systemCompatibility = systemCompatibility & ~SystemCompatibility.Linux;

            canRunOnSystem(systemCompatibility);

            // OUTPUT
            // #1 Flags for Linux and MacOs are set
            // Can run on linux
            // Can run on macos

            // #2 Windows flag is added
            // Can run on all systems

            // #3 Linux flag is removed
            // Can run on windows
            // Can run on macos
        }

        void canRunOnSystem(SystemCompatibility systemCompatibility)
        {
            if (systemCompatibility.HasFlag(SystemCompatibility.All))
            {
                Console.WriteLine("Can run on all systems");
                return;
            }

            if (systemCompatibility.HasFlag(SystemCompatibility.Linux))
            {
                Console.WriteLine("Can run on linux");
            }

            if (systemCompatibility.HasFlag(SystemCompatibility.Windows))
            {
                Console.WriteLine("Can run on windows");
            }

            if (systemCompatibility.HasFlag(SystemCompatibility.MacOs))
            {
                Console.WriteLine("Can run on macos");
            }
        }
    }

    [Flags]
    enum SystemCompatibility
    {
        NotCompatible = 0,

        Windows = 1,

        Linux = 2,

        MacOs = 4,

        All = Windows | Linux | MacOs

    }
}
