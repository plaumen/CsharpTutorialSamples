using CsharpSamples.Common.Interfaces;
using System;

namespace CsharpSamples.Samples.Basics.Types
{
    public class ArraysSample : ISample
    {
        public void Run()
        {
            int red = 120;
            int green = 120;
            int blue = 120;

            // first way of array creation and values assignment
            int[] rgbArray = new int[3];
            rgbArray[0] = red;
            rgbArray[1] = green;
            rgbArray[2] = blue;

            // array creation and values assignment in one line
            rgbArray = new int[] { red, green, blue, 230 };

            Console.WriteLine($"RGB array length is: {rgbArray.Length}\n");
            Console.WriteLine("Items: " + string.Join(",", rgbArray) + "\n");

            int[][] multiDimensionalArray = new int[3][] {
                rgbArray,
                new int[] { 0, 1 },
                new int[] { 1,3,4 }
             };

            Console.WriteLine($"Two dimensional array rank is: {multiDimensionalArray.Rank}\n");

            for (int index = 0; index < multiDimensionalArray.Length; index++)
            {
                Console.WriteLine($"Items[{index}]: " + string.Join(",", multiDimensionalArray[index]) + "\n");
            }

            // Output:
            // RGB array length is: 4
            // Items: 120,120,120,230
            // Two dimensional array rank is: 1
            // Items[0]: 120,120,120,230
            // Items[1]: 0,1
            // Items[2]: 1,3,4
        }
    }
}
