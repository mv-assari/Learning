using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDD.Models;
using Xunit;

namespace TDD.Test
{
    public class SumTest
    {
        [Theory]
        [InlineData("1,2",3)]
        [InlineData("",0)]
        [InlineData("1,2,4",7)]
        [InlineData("1,2,4,",7)]
        [InlineData("0",0)]
        public void Execute_SumNumber_When_StringNumber(string numbers,int expected)
        {
            //Arrange
            Sum sum = new Sum();

            //Act

            var result=sum.Execute(numbers);

            //Assert

            Assert.Equal(expected, result);
        }
    }
}
