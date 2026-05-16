using System;
using System.Collections.Generic;

namespace BubbleSort_Delegate
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Credit { get; set; }

        public static bool Compare(User user1, User user2)
        {
            return user1.Credit > user2.Credit;
        }
    }

    public class Product
    {
        public int Id { get; set; }
        public int Price { get; set; }

        public static bool Compare(Product p1, Product p2)
        {
            return p1.Price > p2.Price;
        }
    }
    internal class Program
    {
        //Project-4
        static void Sort<T>(List<T> lists,Func<T,T,bool> compare)
        {
            bool change = true;
            do
            {
                change = false;

                for (int i = 0; i < lists.Count-1; i++)
                {
                    if (compare(lists[i], lists[i+1]))
                    {
                        T temp = lists[i];
                        lists[i] = lists[i+1];
                        lists[i+1] = temp;
                        change = true;
                    }
                }

            } while (change==true);
        }

        static void Main(string[] args)
        {
            List<User> users = new List<User>
            {
                new User{Id=1,Name="1",Credit=150000},
                new User{Id=2,Name="2",Credit=160000},
                new User{Id=3,Name="3",Credit=130000},
                new User{Id=4,Name="4",Credit=180000},
                new User{Id=5,Name="5",Credit=110000},
                new User{Id=6,Name="6",Credit=100000},
            };

            Sort<User>(users, User.Compare);

            foreach (User user in users)
            {
                Console.WriteLine($"userid:{user.Id} {user.Name} {user.Credit}");
            }

            List<Product> products = new List<Product>
            {
                new Product{Price=13000,Id=1},
                new Product{Price=16000,Id=2},
                new Product{Price=14000,Id=3},
                new Product{Price=12000,Id=4},
                new Product{Price=10000,Id=5},
            };

            Sort<Product>(products, Product.Compare);

            foreach (Product product in products)
            {
                Console.WriteLine($"Id:{product.Id} {product.Price}");
            }

            Console.ReadLine();
        }
    }
}
