using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;
using XUnitLearn.TestData;

namespace XUnit.Test
{
    public class MathHelperTest
    {
        private readonly ITestOutputHelper _outputHelper;
        public MathHelperTest(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }

        //[Fact] // --> متدهایی که پارامتر ورودی ندارند به این صورت عمل میکنیم
        [Fact(Skip ="برای غیرفعال کردن تست از این حالت استفاده میشود")] // --> متدهایی که پارامتر ورودی ندارند به این صورت عمل میکنیم
        public void JamTestByFact()
        {
            MathHelper mathHelper = new MathHelper();

            int x = 4;
            int y = 5;

            var result = mathHelper.Jam(x, y);

            Assert.IsType<int>(result);
            Assert.Equal(9, result);
        }

        [Theory] // --> اگر بخواهیم برای متد ورودی داشته باشیم باید از این حالت استفاده کنیم
        //[Theory(Skip = "برای غیرفعال کردن تست از این حالت استفاده میشود")] // --> اگر بخواهیم برای متد ورودی داشته باشیم باید از این حالت استفاده کنیم
        [InlineData(10, 15, 25)] // --> اگر بخواهیم ورودی داشته باشیم از این طریق به ورودی موارد مورد نظر را اعمال میکنیم
        [InlineData(-5, -5, -10)]
        [Trait("service","order")] // --> از این مورد برای دسته بندی تست ها استفاده میشود که برای تست در سیستم های بزرگ به مشکل نخوریم
        public void JamTest(int x, int y, int expected)
        {
            MathHelper mathHelper = new MathHelper();

            var result = mathHelper.Jam(x, y);

            Assert.Equal(expected, result);
            Assert.IsType<int>(result);
        }

        [Theory]
        //[Theory(Skip = "برای غیرفعال کردن تست از این حالت استفاده میشود")]
        [MemberData(nameof(DataForTest.GetData),MemberType =typeof(DataForTest))] // --> از این طریق هم میتوانیم به ورودی موارد مورد نظر را اعمال کنیم
        [Trait("service","card")] // --> از این مورد برای دسته بندی تست ها استفاده میشود که برای تست در سیستم های بزرگ به مشکل نخوریم
        public void Jam_MemberData_Test(int x, int y, int expected)
        {
            MathHelper mathHelper = new MathHelper();

            var result = mathHelper.Jam(x, y);

            Assert.Equal(expected, result);
            Assert.IsType<int>(result);
        }
        
        [Theory]
        //[Theory(Skip = "برای غیرفعال کردن تست از این حالت استفاده میشود")]
        [ClassData(typeof(MemberClassData))] // --> از این طریق نیز موارد مورد نظر را اعمال میکنیم
        [Trait("endpoint","order")] // --> از این مورد برای دسته بندی تست ها استفاده میشود که برای تست در سیستم های بزرگ به مشکل نخوریم
        public void Jam_ClassData_Test(int x, int y, int expected)
        {
            MathHelper mathHelper = new MathHelper();

            var result = mathHelper.Jam(x, y);

            _outputHelper.WriteLine("this is a test");
            _outputHelper.WriteLine(x.ToString());

            Assert.Equal(expected, result);
            Assert.IsType<int>(result);
        }
    }
}
