using System;
using System.Collections.Generic;
using System.Linq;

namespace CsharpSamples.Samples.Basics.Linq
{
    public class Person
    {
        public Person(string name, int age, bool isEmployed, List<Person> children = null)
        {
            Name = name;
            Age = age;
            IsEmployed = isEmployed;
            Children = children;
        }

        public string Name { get; }
        public int Age { get; }
        public bool IsEmployed { get; }
        public List<Person> Children { get; }

        public override string ToString()
        {
            var childrenInfo = Children == null || !Children.Any() ? string.Empty : $"\nChildren: {(string.Join(",", Children.Select(c => c.Name)))}";
            return $"{Name} {Age} {childrenInfo}";
        }
    }

    public class PersonRepository
    {
        private static List<string> names = new List<string> { "John", "Kate", "Julia", "Ben", "Ten", "Jennifer" };
        private static Random rand = new Random();

        public static List<Person> Get(int numberOfPersons)
        {

            var persons = new List<Person>();
            for (int personIndex = 0; personIndex < numberOfPersons; personIndex++)
            {
                var name = names[rand.Next(names.Count)];
                var newPerson = new Person(name, rand.Next(18, 64), personIndex % 3 == 0, persons.Take(personIndex < 10 ? personIndex : 0).ToList());
                persons.Add(newPerson);
            }

            return persons;
        }
    }
}
