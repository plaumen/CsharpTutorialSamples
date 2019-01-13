using CsharpSamples.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CsharpSamples.Samples.Basics.Linq
{
    public class FirstsSample : ISample
    {
        public void Run()
        {
            var numbers = new List<int> { 1, 2, 3 };
            var emptyNumbersList = new List<int>();
            var firstNumber = numbers.First();
            Console.WriteLine($"First number: {firstNumber}");

            // OUTPUT
            // First number: 1

            try
            {
                emptyNumbersList.First();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Exception during getting First from empty list\n{e.Message}");
            }

            // OUTPUT
            // Exception during getting First from empty list
            // Sequence contains no elements

            firstNumber = emptyNumbersList.FirstOrDefault();
            // value types have default values e.g. ints have 0 what can cause that you will get a number from empty collection
            Console.WriteLine($"First number from empty list: {firstNumber}");

            // OUTPUT
            // First number from empty list: 0


            var shoesList = new List<Shoes>();
            var firstShoes = shoesList.FirstOrDefault();
            // reference types have default value null
            Console.WriteLine($"First or default shoes are: {firstShoes}.");

            shoesList.Add(new Shoes(42));
            firstShoes = shoesList.FirstOrDefault();
            Console.WriteLine($"First or default shoes are: {firstShoes}.");

            // OUTPUT
            // First or default shoes are: .
            // First or default shoes are: 42.
        }

        private class Shoes
        {
            public Shoes(int size)
            {
                Size = size;
            }
            public int Size { get; }

            public override string ToString()
            {
                return Size.ToString();
            }
        }
    }
}
