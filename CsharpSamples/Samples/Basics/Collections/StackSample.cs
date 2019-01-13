using CsharpSamples.Common.Interfaces;
using System.Collections.Generic;

namespace CsharpSamples.Samples.Basics.Collections
{
    public class StackSample : ISample
    {
        public void Run()
        {
            var booksOnDesk = new Stack<Book>();

            booksOnDesk.Push(new Book("Robert C. Martin", "Clean Code"));
            booksOnDesk.Push(new Book("Jon Skeet", "C# in depth"));
            booksOnDesk.Push(new Book("O'Reilly", "Trying stuff until it works"));

            var bookToRead = booksOnDesk.Pop();
            System.Console.WriteLine($"I took book from the top and it is {bookToRead}");

            // OUTPUT
            // I took book from the top and it is O'Reilly - Trying stuff until it works
        }
    }

    public class Book
    {
        private readonly string _author;
        private readonly string _title;

        public Book(string author, string title)
        {
            _author = author;
            _title = title;
        }

        public override string ToString()
        {
            return $"{_author} - {_title}";
        }
    }
}
