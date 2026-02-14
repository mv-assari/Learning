using System;
using System.Collections.Generic;
using System.Linq;

namespace explain
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Company> companies = new List<Company>()
            {
                new Company{Id=1,Name="Lenovo"},
                new Company{Id=2,Name="Hp"},
                new Company{Id=3,Name="Asus"},
                new Company{Id=4,Name="Samsoung"},
                new Company{Id=5,Name="Apple"}
            };

            //Named Method------------------------------------
            var resultCompany1 = companies.Where(findCompany);

            //Use Delegate or Anonymous Method------------------------------
            var resultCompany2=companies.Where(delegate (Company company)
            {
                return company.Name.StartsWith("A");
            });

            //Lambda Expertion------------------------------------------
            var resultCompany3 = companies.Where(company=>company.Name.StartsWith("A"));

        }
        public static bool findCompany(Company company)
        {
            return company.Name == "Hp";
            //return company.Name.Equals("Hp"); این خط با خط بالایی یک کار انجام میدهند
        }

        public class Company
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }
    }
}
