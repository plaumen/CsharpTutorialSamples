using CsharpSamples.Common.Interfaces;
using System.Linq;

namespace CsharpSamples.Samples.Basics.Linq
{
    public class SelectSample : ISample
    {
        public void Run()
        {
            var persons = PersonRepository.Get(10);
            var personsAges = persons.Select(p => p.Age);
            System.Console.WriteLine($"Persons ages are {string.Join(",", personsAges)}");

            // declaration of anonysmous type
            var namesAgesList = persons.Select(p => new { Name = p.Name, Age = p.Age }).ToList();
            foreach (var nameAge in namesAgesList)
            {
                System.Console.WriteLine($"{nameAge.Name} is {nameAge.Age}");
            }

        }
    }
}
