using CsharpSamples.Common.Interfaces;
using System;
using System.Linq;

namespace CsharpSamples.Samples.Basics.Linq
{
    public class WhereSample : ISample
    {
        public void Run()
        {
            var persons = PersonRepository.Get(30);
            var employedPersons = persons.Where(p => p.IsEmployed);
            Console.WriteLine($"Employed persons are:\n{(string.Join("\n", employedPersons))}");

            var employedJohns = employedPersons.Where(p => p.Name == "John");
            Console.WriteLine($"\nEmployed Johns are:\n{(string.Join("\n", employedJohns))}");

            // query predefined as Func
            Func<Person, bool> personWithChildrenFilter = p => p.Children != null && p.Children.Any();
            var personsWithChildren = persons.Where(personWithChildrenFilter).ToList();
            Console.WriteLine($"\nChildren have:\n{(string.Join("\n", personsWithChildren))}");
        }
    }
}
