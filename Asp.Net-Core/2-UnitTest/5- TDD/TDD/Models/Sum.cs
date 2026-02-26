using System;
using System.ComponentModel;
using System.Linq;

namespace TDD.Models
{
    public class Sum
    {
        public int Execute(string numbers)
        {
            if (numbers=="")
                return 0;
            
            if(numbers=="0")
                 return 0; 

            if (numbers.EndsWith(','))
            {
                numbers=numbers.Substring(0,numbers.Length-1);
            }
            string[] spnum=numbers.Split(',');

            int[] intNumbers=Array.ConvertAll(spnum,s=>int.Parse(s));

            return intNumbers.Sum();
        }
    }
}
