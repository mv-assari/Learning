using System;
using System.Collections.Generic;
using System.Linq;

namespace Sorting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var result = GetCourseList().OrderBy(c = c.Name); -- OrderBy() --

            var result = GetCourseList().OrderByDescending(c = c.Name); -- OrderByDescending --

            var result=GetCourseList().OrderBy(c=c.Price).ThenBy(c=c.Name); -- ThenBy --

            var result = GetCourseList().OrderByDescending(c = c.Name).ThenByDescending(c = c.Price); -- ThenByDescending --

            var result = GetCourseList().OrderBy(c=c.Name).Reverse(); --> Reverse <--


            foreach (var item in result)
            {
                Console.WriteLine($Id={item.Id} Name={item.Name} Price={item.Price});
            }

            Console.ReadKey();
        }
        private static ListCourse GetCourseList()
        {
            ListCourse courses = new ListCourse
            {
                new Course{Id=1,Name=C#,Price=15000},
                new Course{Id=2,Name=Php,Price=25000},
                new Course{Id=3,Name=Java,Price=35000},
                new Course{Id=4,Name=Angular,Price=35000},
                new Course{Id=5,Name=Asp.Net Core,Price=55000},
                new Course{Id=6,Name=React,Price=65000},
            };

            return courses;
        }
    }

    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
    }

}
