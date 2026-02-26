using Moq;
using Moq.Protected;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApp.Controllers;
using WebApp.Services;
using Xunit;

namespace WebApp.Test
{
    public class UnitTest
    {
        #region Notes
        //Loose --> not required setup moq
        //Strict --> required setup moq
        #endregion

        [Fact]
        public void Test_MockBehavior()
        {
            var moq=new Mock<IProdcutService>(MockBehavior.Strict);
            moq.Setup(p => p.GetProductPrice(1)).Returns(1555);
            var result = moq.Object.GetProductPrice(1); //important use this moq becouse not behavior
        }

        [Fact]
        public void Test_PropertySetupTest()
        {
            var moq=new Mock<IProdcutService>();
            moq.Setup(p=>p.ProductCount).Returns(100);
        }

        [Fact]
        public void Test_Add_Product_SaveState()
        {
            var moq = new Mock<IProdcutService>();
            Product product = new Product
            {
                Id = 1,
                Name = "Test"
            };
            moq.Setup(p=>p.AddProduct(product)).Returns(product);
            //moq.SetupProperty(p => p.ProductCount); //for save state property
            moq.SetupAllProperties();//for save state all property
            HomeController controller = new HomeController(moq.Object,null);

            controller.AddProduct(product);

            Assert.Equal(1,moq.Object.ProductCount);
        }

        [Fact]
        public void Test_SetupSequence()
        {
            var moq = new Mock<IProdcutService>();
            moq.SetupSequence(p => p.GetProductPrice(1)).Returns(1555).Returns(40000).Returns(20000); // هر بار که میره سراغ متد مورد تست یک عدد برمیگردونه که میتونه هر تعداد باشه
            var result = moq.Object.GetProductPrice(1);
        }

        [Fact]
        public void Test_ProtectedMock()
        {
            var moq = new Mock<CarService>();
            moq.Protected().Setup<int>("GetCarPrice").Returns(40000); // for protected mothod and property
        }

        [Fact]
        public void Test_It() //method In
        {
            int[] ids =new int[] {1,2,3 };
            var moq = new Mock<IProdcutService>();
            moq.Setup(p => p.GetProductPrice(It.IsAny<int>())).Returns(2000);
            moq.Setup(p => p.GetProductPrice(It.IsInRange(2,100,Moq.Range.Inclusive))).Returns(2000);
            moq.Setup(p => p.GetProductPrice(It.IsIn(ids))).Returns(2000);
            moq.Setup(p => p.GetProductPrice(It.IsNotIn(ids))).Returns(5000);

        }

        [Fact]
        public void Test_OutParam()
        {
            var moq = new Mock<IProdcutService>();

            int price = 0;
            moq.Setup(p => p.GetProductPrice(1, out price));
        }

        [Fact]
        public void Test_ChainMock()
        {
            var moq = new Mock<IProdcutService>();
            moq.Setup(p => p.Brand.Id).Returns(1);
        }

        [Fact]
        public void Test_Behavior_SendMessageWithEmail()
        {
            var moq = new Mock<IMessage>();
            
            HomeController homeController=new HomeController(null,moq.Object);

            homeController.SendMessage("salam", 20, MessageType.Email);

            moq.Verify(p => p.Email(It.IsAny<string>(), It.IsAny<int>())); // حالت عادی که یعنی کلا این متد با این شرایط اجرا شده باشد
            //moq.Verify(p => p.Email(It.IsAny<string>(), It.IsAny<int>()), "this for failMessage");// نمایش پیام دلخواه خطا هنگامی که اجرا نشده است
            //moq.Verify(p => p.Email(It.IsAny<string>(), It.IsAny<int>()),Times.AtLeast(3));// میتونیم تعداد،زمان و هرچیزی که مربوط به زمان هست براش مشخص کنیم
        }


    }
}
