using System;
using System.Collections.Generic;
using System.Linq;

namespace Generation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IList<string> data = new List<string>();

            var list1 = data.DefaultIfEmpty();
            var list2 = data.DefaultIfEmpty("None");

            List<Student> students = new List<Student>();

            var newListStudent = students.DefaultIfEmpty(new Student { Name = "Vahid" });

            var collection = Enumerable.Empty<string>();
            var collection2 = Enumerable.Empty<Student>();

            var intCollection = Enumerable.Range(3, 10);

            var repeatCollection = Enumerable.Repeat(5, 10);

            Console.ReadKey();
        }
    }

    public class Student
    {
        public string Name { get; set; }
    }
}
