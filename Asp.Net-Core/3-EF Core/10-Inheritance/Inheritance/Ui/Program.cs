using DAL;
using Entities;
using System;

namespace Ui
{
    internal class Program
    {
        static void Main(string[] args)
        {

            DataBaseContext context= new DataBaseContext();

            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();

            Student student = new Student()
            {
                EnrollmentDate = DateTime.Now,
                FirstName = "vahid",
                LastName = "Assari"
            };

            context.Students.Add(student);

            Teacher teacher = new Teacher()
            {
                HireDate = DateTime.Now,
                FirstName = "fatemeh",
                LastName = "tabasi"
            };
            context.Teachers.Add(teacher);

            context.SaveChanges();


            Console.WriteLine("Hello World!");
        }
    }
}
