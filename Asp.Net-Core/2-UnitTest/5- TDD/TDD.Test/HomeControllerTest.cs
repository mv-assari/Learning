using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDD.Controllers;
using Xunit;

namespace TDD.Test
{
    public class HomeControllerTest
    {
        [Fact]
        public void Index_Test()
        {
            //Arrange

            HomeController controller =new HomeController();

            //Act

            var result= controller.Index();

            //Assert

            Assert.IsType<ViewResult>(result);
        }
    }
}
