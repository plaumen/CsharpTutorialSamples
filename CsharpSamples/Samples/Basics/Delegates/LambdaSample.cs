using CsharpSamples.Common.Interfaces;
using System;
using System.Collections.Generic;

namespace CsharpSamples.Samples.Basics.Delegates
{
    public class LambdaSample : ISample
    {
        delegate int ProcessTwoNumbersDelegate(int x, int y);

        public void Run()
        {
            ProcessTwoNumbersDelegate Add = (x, y) => x + y;
            var additionResult = Add(1, 2);
            Console.WriteLine($"Addition result is {additionResult}");

            ProcessTwoNumbersDelegate Multiply = (int x, int y) => { return x * y; };
            var multiplicationResult = Multiply(5, 7);
            Console.WriteLine($"Multiplicaiton result is {multiplicationResult}");

            var numbersRepository = new IntNumbersRepository(20);
            var divisibleBy3 = numbersRepository.Get(n => n % 3 == 0);

            Console.WriteLine("Numbers divisible by 3 are: " + string.Join(",", divisibleBy3));

            //OUTPUT 
            // Addition result is 3
            // Multiplicaiton result is 35
            // Numbers divisible by 3 are: 0,3,6,9,12,15,18
        }
    }

    internal class IntNumbersRepository
    {
        private List<int> _numbers;

        public IntNumbersRepository(int numbersCount)
        {
            _numbers = new List<int>();
            for (int index = 0; index < numbersCount; index++)
            {
                _numbers.Add(index);
            }
        }

        public List<int> Get(Predicate<int> filter)
        {
            var filteredList = new List<int>();

            foreach (var number in _numbers)
            {
                if (filter(number))
                    filteredList.Add(number);
            }

            return filteredList;
        }
    }
}
