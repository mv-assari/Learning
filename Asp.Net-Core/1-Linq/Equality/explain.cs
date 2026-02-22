using System;
using System.Collections.Generic;
using System.Linq;

namespace Equality
{
    internal class Program
    {
        static void Main(string[] args)
        {

            IList<int> data = new List<int> { 5, 3, 10 };
            IList<int> data2 = new List<int> { 5, 3, 10 };

            var result = data.SequenceEqual(data2);

            List<User> users = new List<User>
            {
                new User{Name="Vahid"},
                new User{Name="Ali"},
                new User{Name="Hasan"},
                new User{Name="Ehsan"},
            };
            
            List<User> users2 = new List<User>
            {
                new User{Name="Vahid"},
                new User{Name="Ali"},
                new User{Name="Hasan"},
                new User{Name="Ehsan"},
            };

            var result2 = users.SequenceEqual(users2, new UserComparer());

            Console.ReadKey();
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
            return obj.Name.GetHashCode();
        }
    }
}
