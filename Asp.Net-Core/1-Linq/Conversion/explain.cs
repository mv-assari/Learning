using System;
using System.Collections.Generic;
using System.Linq;

namespace Conversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student[] studentsArray =
            {
                new Student() { Name ="vahid"},
                new Student() { Name ="ali"},
                new Student() { Name ="hasan"},
                new Student() { Name ="ehsan"},
            };

            var enumerable = studentsArray.AsEnumerable();
            var queryable=studentsArray.AsQueryable();

            var newEnumerable=studentsArray.Cast<Student>();

            var arrayTest=enumerable.ToArray();

            var arrayToList=arrayTest.ToList();

            //----------------------------------------------

            List<Student> students = new List<Student>
            {
                new Student{Id=1,Name="vahid1"},
                new Student{Id=2,Name="vahid2"},
                new Student{Id=3,Name="vahid3"},
                new Student{Id=4,Name="vahid4"},
            };

            IDictionary<int, Student> keyValues = students.ToDictionary<Student, int>(s => s.Id);

            foreach (var item in keyValues.Keys)
            {
                Console.WriteLine($"Key:{item} , Value:{(keyValues[item] as Student).Name }");
            }

            Console.ReadKey();
        }
    }

    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
