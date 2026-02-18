using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Filtering
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var result = GetCourseList().Where(c =>c.Id > 3); this one of Where for this list but we use Where as chain for filtering

            //var result = GetCourseList().Where(p => p.Id > 3).Where(p => p.Price > 45000);

            //var result = GetCourseList().Where((c, i) => //where have two overload. this is example of other overload.i in enter parameter is index of c.
            //{
            //    if (i % 2 == 0)
            //        return true;
            //    return false;
            //});

            IList list = new ArrayList();
            list.Add(100);
            list.Add(new Course { Id= 1,Name="Html",Price=220000 });
            list.Add("this is a string value");
            list.Add("salam");

            var result = list.OfType<string>(); //other of filtering group is a OfType<TResult>


            foreach (var item in result)
            {
                Console.WriteLine(item);
            }


            Console.ReadKey();
        }

        private static List<Course> GetCourseList()
        {
            List<Course> courses = new List<Course>
            {
                new Course{Id=1,Name="C#",Price=15000},
                new Course{Id=2,Name="Php",Price=25000},
                new Course{Id=3,Name="Java",Price=35000},
                new Course{Id=4,Name="Angular",Price=45000},
                new Course{Id=5,Name="Asp.Net Core",Price=55000},
                new Course{Id=6,Name="React",Price=65000},
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
