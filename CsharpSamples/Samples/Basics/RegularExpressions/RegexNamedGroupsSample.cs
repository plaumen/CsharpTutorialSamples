using CsharpSamples.Common.Interfaces;
using System.Linq;
using System.Text.RegularExpressions;

namespace CsharpSamples.Samples.Basics.RegularExpressions
{
    public class RegexNamedGroupsSample : ISample
    {
        public void Run()
        {
            var exceptionsStory = "At the beginning InvalidOperationException was thrown. Then NullReferenceException was thrown." +
                "I am glad that ArgumentException was not thrown. To be Exception or not?";

            var exceptions = Regex.Matches(exceptionsStory, @"(?'exceptionName'\w+Exception)").Select(m => m.Groups["exceptionName"].Value);

            System.Console.WriteLine($"I found following exceptions in the story:\n{string.Join("\n", exceptions)}");

            // OUTPUT
            // I found following exceptions in the story:
            // InvalidOperationException
            // NullReferenceException
            // ArgumentException
        }
    }
}
