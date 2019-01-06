using CsharpSamples.Common.Interfaces;
using System;

namespace CsharpSamples.Samples.Basics.Delegates
{
    public class FuncSample : ISample
    {
        public void Run()
        {
            Func<int> getCurrentYearFunc = getCurrentYear;
            getCurrentYearFunc();

            Func<string, int> countLettersFunc = countLetters;

            var word = "peninsula";
            var lettersCount = countLettersFunc(word);
            Console.WriteLine($"{word} has {lettersCount} letters");

            // OUTPUT 
            // peninsula has 9 letters
        }

        private int getCurrentYear()
        {
            return DateTime.Now.Year;
        }

        private int countLetters(string word)
        {
            return word.Length;
        }
    }
}
