using CsharpSamples.Common.Interfaces;
using System;

namespace CsharpSamples.Samples.Basics.Functions
{
    public class StringMethodsSample : ISample
    {
        public void Run()
        {
            // string.Empty - static method to initialize variables by empty string 
            // the same as 
            // var message = ""
            var message = string.Empty;

            // returns information if string is null or contains just whitespace
            // can be useful e.g. in output validation
            bool isEmpty = string.IsNullOrWhiteSpace(message);

            Console.WriteLine($"Is message empty? {isEmpty}");

            int one = 1;
            int two = 2;
            var formattedString = string.Format("One is {0}, Two is {1}...", one, two);

            var interpolatedString = $"One is {one}, Two is {two}";

            Console.WriteLine(formattedString);
            Console.WriteLine(interpolatedString);

            string weatherQuestion = "What was the weather";
            bool containsWeather = weatherQuestion.Contains("weather");

            Console.WriteLine($"{weatherQuestion} contains weather? {containsWeather}");

            // OUTPUT:
            // Is message empty? True
            // One is 1, Two is 2...
            // One is 1, Two is 2
            // What was the weather contains weather? True
        }
    }
}
