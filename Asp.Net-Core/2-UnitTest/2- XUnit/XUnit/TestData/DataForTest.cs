using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XUnitLearn.TestData
{
    public static class DataForTest
    {
        public static List<object[]> GetData()
        {
            List<object[]> mydata = new List<object[]>();

            mydata.Add(new object[] { 5, 5, 10 });
            mydata.Add(new object[] { 36, 15, 51 });

            return mydata;
        }
    }
}
