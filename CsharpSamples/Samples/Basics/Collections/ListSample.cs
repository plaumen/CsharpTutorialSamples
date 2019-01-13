using CsharpSamples.Common.Interfaces;
using System.Collections.Generic;

namespace CsharpSamples.Samples.Basics.Collections
{
    public class ListSample : ISample
    {
        public void Run()
        {
            List<Student> students = new List<Student>();
            // 1st student is added to list
            students.Add(new Student("1st student"));
            printStudentsList(students);

            var secondStudent = new Student("2nd student");
            // 2nd student is inserted at index 0 what causes that is listed befor 1st student 
            students.Insert(0, secondStudent);
            printStudentsList(students);

            // 2nd student index is found
            var indexOfStudentToRemove = students.IndexOf(secondStudent);
            // 2nd student is removed by index
            students.RemoveAt(indexOfStudentToRemove);
            printStudentsList(students);

            //list is emptied
            students.Clear();
            printStudentsList(students);

            // OUTPUT
            // 1st student
            // 2nd student,1st student
            // 1st student
            // There are no students
        }

        void printStudentsList(List<Student> students)
        {
            var message = students.Count == 0 ? "There are no students" : string.Join(",", students);
            System.Console.WriteLine(message);
        }
    }

    public class Student
    {
        public Student(string name)
        {
            Name = name;
        }

        public string Name { get; }

        public override string ToString()
        {
            return Name;
        }
    }
}
