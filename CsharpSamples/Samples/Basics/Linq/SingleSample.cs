using CsharpSamples.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CsharpSamples.Samples.Basics.Linq
{
    public class SingleSample : ISample
    {
        public void Run()
        {

            var singleItemList = new List<string> { "single item" };
            var singleItem = singleItemList.Single();

            // OUTPUT
            // Single item is single item

            Console.WriteLine($"Single item is {singleItem}");

            var emptyList = new List<string>();
            try
            {
                emptyList.Single();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Exception thrown when Single was called on empty list\n{e.Message}");
            }

            // OUTPUT
            // Exception thrown when Single was called on empty list
            // Sequence contains no elements

            var manyItemsList = new List<string> { "1", "second", "do not how", "1" };
            try
            {
                manyItemsList.Single();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Exception thrown when Single was called on list with many items\n{e.Message}");
            }

            // OUTPUT
            // Exception thrown when Single was called on list with many items
            // Sequence contains more than one element

            var singleString = emptyList.SingleOrDefault();
            Console.WriteLine($"Single string from empty list {singleString}.");

            // OUTPUT
            // Single string from empty list .

            singleString = singleItemList.SingleOrDefault();
            Console.WriteLine($"Single string from single item list {singleString}.");

            // OUTPUT
            // Single string from single item list single item.

            // single item meet this condition
            singleString = manyItemsList.SingleOrDefault(s => s.Equals("second"));
            Console.WriteLine($"Single string from many items list {singleString}.");

            // OUTPUT
            // Single string from many items list second.

            try
            {
                // two items meet this condition
                singleString = manyItemsList.SingleOrDefault(s => s.Equals("1"));
            }
            catch (Exception e)
            {
                Console.WriteLine($"Exception thrown when Single was called on list with many items\n{e.Message}");
            }

            // OUTPUT
            // Exception thrown when Single was called on list with many items
            // Sequence contains more than one matching element
        }
    }
}
