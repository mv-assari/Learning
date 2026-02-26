using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApp.Models;
using WebApp.Services;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProdcutService  _prodcutService;
        private readonly IMessage _message;

        public HomeController(IProdcutService prodcutService, IMessage message)
        {
            _prodcutService = prodcutService;
            _message = message;
        }

        public IActionResult SendMessage(string message,int userId,MessageType messageType)
        {
            switch (messageType)
            {
                case MessageType.Sms:
                    _message.Sms(message,userId);
                    break;
                case MessageType.Email:
                    _message.Email(message,userId);
                    break;
                case MessageType.Notif:
                    _message.Notif(message,userId);
                    break;             
            }
            return Json(true);
        }

        public IActionResult AddProduct(Product product)
        {
            _prodcutService.AddProduct(product);
            _prodcutService.ProductCount++;
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
