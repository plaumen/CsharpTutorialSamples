using CsharpSamples.Common.Interfaces;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace CsharpSamples.Samples.Basics.RegularExpressions
{
    public class BasicRegexSample : ISample
    {
        public void Run()
        {
            var passwords = new[]
            {
                "MyName1991",
                "toothpaste",
                "misiaczek",
                "KropkaKreska66at@Home"
            };

            var passwordsWithRanks = ValidatePasswords(passwords);

            foreach (var passwordWithRank in passwordsWithRanks)
            {
                System.Console.WriteLine($"{passwordWithRank.Key} has rank {passwordWithRank.Value}");
            }

            // OUTPUT
            // MyName1991 has rank 2
            // toothpaste has rank 0
            // misiaczek has rank 0
            // KropkaKreska66at @Home has rank 4
        }

        private int GetPasswordRank(string password)
        {
            var passwordRank = 0;

            if (Regex.IsMatch(password, "[A-Z]"))
            {
                passwordRank++;
            }

            if (Regex.IsMatch(password, @"\d"))
            {
                passwordRank++;
            }

            if (Regex.IsMatch(password, @"[@\-;\]\[\?]"))
            {
                passwordRank += 2;
            }

            return passwordRank;
        }

        private Dictionary<string, int> ValidatePasswords(string[] passwords)
        {
            var validationResults = new Dictionary<string, int>();

            foreach (var password in passwords)
            {
                validationResults.Add(password, GetPasswordRank(password));
            }

            return validationResults;
        }
    }
}
