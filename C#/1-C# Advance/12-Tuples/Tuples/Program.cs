using System;

namespace Tuples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string LastName = "Assari";

            var user1 = (Id:1,Name: "vahid",LastName, "address");

            Console.WriteLine(user1.Id);
            Console.WriteLine(user1.Name);
            Console.WriteLine(user1.LastName);
            Console.WriteLine(user1.Item3);

            var result = GetUser();
            Console.WriteLine(result.Name);
            Console.WriteLine(result.LastName);

            //--------------------------------------------------------------------------


            ValueTuple<string, int> user2 = ValueTuple.Create("vahid", 5);
            (string,int) user3 = ValueTuple.Create("vahid", 5);
            (string Name,int Id) user4 = ValueTuple.Create("vahid", 5);

            //Deconstructing Tuples

            (string Name, int Id) = user4;
            Console.WriteLine(Name);
            Console.WriteLine(Id);

            //compare two tuples

            var t1 = ("vahid", 1);
            var t2 = ("vahid", 1);

            Console.WriteLine(t1==t2);
            Console.WriteLine(t1.Equals(t2));


            //Tuples       vs        system.tuple
            //value type             reference type
            //mutable                 immutable
            //fileds                  properties
            //پیشنهادی     

            Console.ReadLine();
        }

        public class Product
        {

            public Product(int id,string name)=>(_Id,_Name)=(id,name);//use tuples

            private int _Id;
            private string _Name;

            public int Id
            {
                get { return _Id; }
                set { _Id = value; }
            }

            public string Name
            {
                get { return _Name; }
                set { _Name = value; }
            }
        }

        public static (int Id,string Name,string LastName,string Address) GetUser()
        {
            return (5, "fatameh", "tabasi", "qom");
        }
    }
}
