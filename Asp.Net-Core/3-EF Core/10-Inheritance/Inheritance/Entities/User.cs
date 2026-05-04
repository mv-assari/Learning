using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{

    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    public class Student:Person
    {
        
        public DateTime EnrollmentDate { get; set; }
    }

    public class Teacher:Person
    {
        public DateTime HireDate { get; set; }
    }
}
