using CsharpSamples.Common.Interfaces;
using System;
using System.Linq;

namespace CsharpSamples.Samples.Basics.Linq
{
    public class GroupBySample : ISample
    {
        public void Run()
        {
            var persons = PersonRepository.Get(10);

            var personsGroupedByName = persons.GroupBy(p => p.Name);

            foreach (var personsByName in personsGroupedByName)
            {
                Console.WriteLine($"There are {personsByName.Count()} persons with name {personsByName.Key}. " +
                    $"They are in following ages: {string.Join(",", personsByName.Select(p => p.Age))}");
            }

            // SAMPLE OUPTUT
            // There are 3 persons with name Jennifer. They are in following ages: 35,56,54
            // There are 3 persons with name Ten. They are in following ages: 56,41,48
            // There are 2 persons with name Kate. They are in following ages: 21,41
            // There are 1 persons with name Julia. They are in following ages: 33
            // There are 1 persons with name Ben. They are in following ages: 56
        }
    }
}
