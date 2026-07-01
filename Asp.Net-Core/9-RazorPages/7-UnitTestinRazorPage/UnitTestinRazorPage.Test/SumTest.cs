using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestinRazorPage.Models;
using Xunit;

namespace UnitTestinRazorPage.Test
{
    public class SumTest
    {
        [Theory]
        [InlineData(5,5,10)]
        [InlineData(5,55,60)]
        [InlineData(50,40,90)]
        public void OnValue1Value2_ReturnSumResult(int value1,int value2,int expectedResult)
        {
            Sum sum=new Sum();
            var result = sum.Execute(value1, value2);

            Assert.Equal(expectedResult, result);
        }
    }
}
