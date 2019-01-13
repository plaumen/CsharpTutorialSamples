using CsharpSamples.Common.Interfaces;
using System.Linq;

namespace CsharpSamples.Samples.Basics.Linq
{
    public class SelectManySample : ISample
    {
        public void Run()
        {
            var persons = PersonRepository.Get(20);

            var childrenNames = persons.SelectMany(p => p.Children).Select(c => c.Name);
            System.Console.WriteLine($"Children names are {(string.Join(',', childrenNames))}");

            var childrenNamesDistincted = childrenNames.Distinct();
            System.Console.WriteLine($"\nDistincted children names are {(string.Join(',', childrenNamesDistincted))}");
        }
    }
}
