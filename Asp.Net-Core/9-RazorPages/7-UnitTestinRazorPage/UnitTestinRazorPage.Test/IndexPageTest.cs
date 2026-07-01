using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestinRazorPage.Pages;
using Xunit;

namespace UnitTestinRazorPage.Test
{
    public class IndexPageTest
    {
        [Fact]
        public void OnPost_IfInvalidModel_ReturnBadRequest()
        {
            //arrange

            var pageModel =new IndexModel();

            //Act

            pageModel.ModelState.AddModelError("Error", "test error");
            var result = pageModel.OnPost();

            //Assert

            Assert.IsType<BadRequestResult>(result);
        }

        [Fact]
        public void OnPost_IfValidModel_ReturnPage()
        {
            //Arrange

            var pageModel =new IndexModel();

            //Act

            var result = pageModel.OnPost();

            //Assert

            Assert.IsType<PageResult>(result);
        }

        [Fact]
        public void OnGet_ReturnPage()
        {
            //Arrange

            var pageModel = new IndexModel();

            //Act

            var result = pageModel.OnGet();

            //Assert

            Assert.IsType<PageResult>(result);
        }
    }
}
