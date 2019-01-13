using CsharpSamples.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CsharpSamples.Samples.Basics.Linq
{
    public class TakeSkipSample : ISample
    {
        public void Run()
        {
            var numbers = getNumbers(5);

            var takenNumbers = numbers.Take(7);

            // OUTPUT
            // Taken numbers: 0,1,2,3,4

            Console.WriteLine($"Taken numbers: {string.Join(',', takenNumbers)}");

            numbers = getNumbers(12);
            var chunkSize = 4;
            var chunksCount = (int)Math.Ceiling(1.0f * numbers.Count / chunkSize);
            for (int chunkIndex = 0; chunkIndex < chunksCount; chunkIndex++)
            {
                var chunk = numbers.Skip(chunkIndex * chunkSize).Take(chunkSize);
                Console.WriteLine($"Chunk {chunkIndex + 1}: {string.Join(',', chunk)}");
            }

            // OUTPUT
            //Chunk 1: 0,1,2,3
            //Chunk 2: 4,5,6,7
            //Chunk 3: 8,9,10,11


        }

        private List<int> getNumbers(int numbersCount)
        {
            var numbers = new List<int>();
            for (int index = 0; index < numbersCount; index++)
            {
                numbers.Add(index);
            }

            return numbers;
        }
    }
}
