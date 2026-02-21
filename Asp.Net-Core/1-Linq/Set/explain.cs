using System;
using System.Collections.Generic;
using System.Linq;

namespace Set
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<User> users = new List<User> 
            {
                new User{Name="Vahid"},
                new User{Name="Ehsan"},
                new User{Name="Ali"},
                new User{Name="Vahid"},
                new User{Name="Hasan"},
            };

            List<User> users2 = new List<User>
            {
                new User{Name="Vahid1"},
                new User{Name="Ehsan2"},
                new User{Name="Ali"},
                new User{Name="Vahid"},
                new User{Name="Hasan"},
            };

            IList<string> data = new List<string> { "1", "2", "3", "4", "5", "6", "7", "8", "6", "6", "6", "6", "6", "6" };
            IList<string> data2 = new List<string> { "4", "5", "6", "7", "8" };

            var distincResult = data.Distinct();// remove duplicate object 

            var exceptResult=data.Except(data2);//data - data2 => {"1","2","3"}

            var intersectResult=data.Intersect(data2); // Intersect--> common data and data2

            var unionResult=data.Union(data2); // Union --> union data and data2 without duplicate

            var concatResult=data.Concat(data2); // Concat --> concat data and data2

            var distincResult2=users.Distinct(new UserComparer());// exception for remove duplicate object

            foreach (var item in distincResult2)
            {
                //Console.WriteLine(item.Name);
            }

            var exceptResult2=users.Except(users2, new UserComparer());

            foreach (var item in exceptResult2)
            {
                //Console.WriteLine(item.Name);
            }

            var intersectResult2=users.Intersect(users2, new UserComparer());

            foreach (var item in intersectResult2)
            {
                //Console.WriteLine(item.Name);
            }

            var unionResult2=users.Union(users2, new UserComparer());

            foreach (var item in unionResult2)
            {
                Console.WriteLine(item.Name);
            }

            Console.ReadLine();
        }
    }

    public class User
    {
        public string Name { get; set; }
    }

    public class UserComparer : IEqualityComparer<User>
    {
        bool IEqualityComparer<User>.Equals(User x, User y)
        {
            if (x.Name == y.Name)
                return true;
            return false;
        }

        int IEqualityComparer<User>.GetHashCode(User obj)
        {
                var a= obj.Name.GetHashCode();
            return a;
        }
    }
}
