using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAppApi.Controllers;
using WebAppMvc.Models;
using WebAppMvc.Models.Entities;
using WebAppMvc.Models.Services;
using Xunit;

namespace WebAppApi.Test
{
    public class ProductApiControllerTest
    {
        MockData mockData;
        public ProductApiControllerTest()
        {
            mockData = new MockData();
        }

        [Fact]
        public void Get_Test()
        {
            //Arrange
            var moq = new Mock<IProductService>();
            moq.Setup(p => p.GetAll()).Returns(mockData.GetAll());

            ProductApiController productApi=new ProductApiController(moq.Object);

            //Act
            var result= productApi.Get();

            //Assert
            Assert.IsType<OkObjectResult>(result);
            var list=result as OkObjectResult;
            Assert.IsType<List<Product>>(list.Value);
        }

        [Theory]
        [InlineData(1,-1)]
        public void GetById_Test(int validId, int inValidId)
        {
            var moq =new Mock<IProductService>();
            moq.Setup(p => p.GetById(validId)).Returns(mockData.GetAll().FirstOrDefault(p=>p.Id==validId));

            ProductApiController productApi= new ProductApiController(moq.Object);

            var result= productApi.Get(validId);

            Assert.IsType<OkObjectResult>(result);
            var product=result as OkObjectResult;
            Assert.IsType<Product>(product.Value);

            //--------------------------------

            moq.Setup(p => p.GetById(inValidId)).Returns(mockData.GetAll().FirstOrDefault(p=>p.Id==inValidId));

            var inValidIdResult=productApi.Get(inValidId);

            Assert.IsType<NotFoundResult>(inValidIdResult);

        }

        [Fact]
        public void Post_Test()
        {
            Product product = new Product
            {
                Id = 1,
                Name = "test",
                Description = "test",
                Price = 2000
            };

            var moq = new Mock<IProductService>();
            moq.Setup(p => p.Add(product)).Returns(mockData.GetAll().FirstOrDefault());

            ProductApiController productApi=new ProductApiController(moq.Object);

            var result=productApi.Post(product);

            Assert.IsType<CreatedAtActionResult>(result);
        }

        [Theory]
        [InlineData(1,-1)]
        public void Delete_Test(int validId,int inValidId)
        {
            var moq=new Mock<IProductService>();
            moq.Setup(p => p.GetById(validId)).Returns(mockData.GetAll().FirstOrDefault());
            moq.Setup(p => p.Remove(validId));

            ProductApiController productApi= new ProductApiController(moq.Object);

            var result= productApi.Delete(validId);

            Assert.IsType<OkObjectResult>(result);

            //-----------------------------------------

            moq.Setup(p=>p.Remove(inValidId));

            var resultInvalid = productApi.Delete(inValidId);

            Assert.IsType<NotFoundResult>(resultInvalid);
        }
    }
}
