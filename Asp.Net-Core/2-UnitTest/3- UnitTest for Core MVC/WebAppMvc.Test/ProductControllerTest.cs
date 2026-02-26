using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAppMvc.Controllers;
using WebAppMvc.Models;
using WebAppMvc.Models.Entities;
using WebAppMvc.Models.Services;
using Xunit;

namespace WebAppMvc.Test
{
    public class ProductControllerTest
    {
        [Fact]
        public void Index_Test()
        {
            //------Arrange------
            MockData data= new MockData();
            var moq = new Mock<IProductService>();
            moq.Setup(p=>p.GetAll()).Returns(data.GetAll());

            ProductController productController = new ProductController(moq.Object);

            //------Act-------

            var result = productController.Index();

            //------Assert------

            Assert.IsType<ViewResult>(result);

            var viewResult = result as ViewResult;
            Assert.IsAssignableFrom<List<Product>>(viewResult.Model);
        }

        [Theory]
        [InlineData(1,-2)]
        public void Detail_Test(int validId,int inValidId)
        {
            //----Arrange-----

            MockData data= new MockData();

            var moq = new Mock<IProductService>();
            moq.Setup(p => p.GetById(validId)).Returns(data.GetAll().FirstOrDefault(p=>p.Id==validId));

            ProductController productController=new ProductController(moq.Object);

            //-----Act-------

            var result = productController.Details(validId);

            //----Assert-----

            Assert.IsType<ViewResult>(result);
            var viewResult = result as ViewResult;
            Assert.IsAssignableFrom<Product>(viewResult.Model);

            //-----------------------------------------------------------------------------

            //----Arrange-----


            moq.Setup(p => p.GetById(inValidId)).Returns(data.GetAll().FirstOrDefault(p => p.Id == inValidId));


            //-----Act-------

            var result2= productController.Details(inValidId);

            //----Assert-----

            Assert.IsType<NotFoundResult>(result2);


        }

        [Fact]
        public void Create_Test()
        {
            
            //----Arrange-----

            var moq=new Mock<IProductService>();
            
            ProductController productController= new ProductController(moq.Object);

            Product product = new Product
            {
                Id = 1,
                Name = "Test",
                Description = "Test",
                Price = 1000
            };

            //-----Act-------

            var resutl= productController.Create(product);

            //----Assert-----

            var redirect= Assert.IsType<RedirectToActionResult>(resutl);
            Assert.Equal(nameof(productController.Index), redirect.ActionName);
            Assert.Null(redirect.ControllerName);

            //----------------------------------------------------------------------------

            //----Arrange-----

            Product invalidProduct=new Product { Id = 1,Description="Test",Price=10000};
            productController.ModelState.AddModelError("Name", "نام را وارد کنید.");

            //-----Act-------

            var invalidResult=productController.Create(invalidProduct);
            //----Assert-----

            Assert.IsType<BadRequestObjectResult>(invalidResult);
        }

        [Theory]
        [InlineData(1)]
        public void Delete_Test(int validId) 
        {            

            //----Arrange-----

            var moq= new Mock<IProductService>();
            moq.Setup(p => p.Remove(validId));

            ProductController productController=new ProductController(moq.Object);

            //-----Act-------

            var result=productController.Delete(validId);
            

            //----Assert-----

            var redirect= Assert.IsType<RedirectToActionResult>(result);
            Assert.Equal("Index", redirect.ActionName);
        }
    }
}
