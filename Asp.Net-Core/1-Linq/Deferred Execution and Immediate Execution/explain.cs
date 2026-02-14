using System;
using System.Collections.Generic;
using System.Linq;

namespace explain
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Notes
            //--------------------------------------------
            // All of the linq query default is Deferred Execution 
            // For change deferred execution to immediate execution, we use methods for change for example ToList()
            //--------------------------------------------
            List<Course> courses = new List<Course>()
            {
                new Course{Id=1,Name="C#",Price=12500},
                new Course{Id=2,Name="Python",Price=22500},
                new Course{Id=3,Name="Java",Price=32500},
                new Course{Id=4,Name="Php",Price=42500},
                new Course{Id=5,Name="Android",Price=52500},
            };

            #region Deferred Execution
            var result = courses.Where(c => c.Price > 22500);//in this line query is created but not execute

            foreach(var course in result)//in this line query is used and execute
            {
                Console.WriteLine($"Id={course.Id} Name={course.Name} Price={course.Price}");
            }

            courses.Add(new Course { Id = 6, Name = "Angular", Price = 62500 });

            foreach (var course in result)//in this line query is used and execute
            {
                Console.WriteLine($"Id={course.Id} Name={course.Name} Price={course.Price}");
            }
            #endregion

            #region Immediate Execution
            var result2 = courses.Where(c => c.Price > 22500).ToList();//in this line query is created and use ---> deferred execution change to immediate execution

            foreach (var course in result2)
            {
                Console.WriteLine($"Id={course.Id} Name={course.Name} Price={course.Price}");
            }

            courses.Add(new Course { Id = 6, Name = "Angular", Price = 62500 });

            foreach (var course in result2)
            {
                Console.WriteLine($"Id={course.Id} Name={course.Name} Price={course.Price}");
            }
            #endregion

            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }

        public class Course
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Price { get; set; }
        }
    }
}
