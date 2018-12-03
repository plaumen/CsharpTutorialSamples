using CsharpSamples.Common.Interfaces;
using System;

namespace CsharpSamples.Samples.Basics.Functions
{
    public class FunctionsOverloadingSample : ISample
    {
        public void Run()
        {
            float basePrice = 100;

            float finalPrice = _getFinalPrice(basePrice, 10);
            Console.WriteLine($"Final price is: {finalPrice}");

            finalPrice = _getFinalPrice(basePrice, 10, 20);
            Console.WriteLine($"Final price is: {finalPrice}");

            string finalPriceInString = _getFinalPrice(basePrice, "no discounts for you!");
            Console.WriteLine(finalPriceInString);

            //OUTPUT
            // Final price is: 90
            // Final price is: 70
            // 100 no discounts for you!
        }

        float _getFinalPrice(float basePrice, float discountInPercents)
        {
            return ((100 - discountInPercents) / 100) * basePrice;
        }

        float _getFinalPrice(float basePrice, float discount, float workersDiscountInPercents)
        {
            return ((100 - discount - workersDiscountInPercents) / 100) * basePrice;
        }

        string _getFinalPrice(float basePrice, string message)
        {
            return $"{basePrice} {message}";
        }

        // Solution below will not work because function is named the same as another and have the same parameters signature

        //string _getFinalPrice(float basePrice, float discountInPercents)
        //{
        //    return "Am I really working?";
        //}
    }
}
