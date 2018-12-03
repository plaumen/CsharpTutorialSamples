using CsharpSamples.Common.Interfaces;
using System;

namespace CsharpSamples.Samples.Basics.Functions
{
    public class DefaultParametersSample : ISample
    {
        public void Run()
        {
            string phone = "12345";
            string phoneWithDefaultCountryCode = _addCountryCodeToPhoneNumber(phone);

            Console.WriteLine($"Default: {phoneWithDefaultCountryCode}");

            string phoneWithCustomCountryCode = _addCountryCodeToPhoneNumber(phone, "365");

            Console.WriteLine($"Custom: {phoneWithCustomCountryCode}");

            string phoneWithMyCountryCode = _addCountryCodeFromConstToPhoneNumber(phone);

            Console.WriteLine($"My: { phoneWithMyCountryCode}");

            // OUTPUT
            // Default: 048 - 12345
            // Custom: 365 - 12345
            // My: 038 - 12345
        }

        string _addCountryCodeToPhoneNumber(string phoneNumber, string countryCode = "048")
        {
            return countryCode + "-" + phoneNumber;
        }

        string _addCountryCodeFromConstToPhoneNumber(string phoneNumber, string countryCode = myCountryCode)
        {
            return _addCountryCodeToPhoneNumber(phoneNumber, countryCode);
        }

        private const string myCountryCode = "038";
    }
}
