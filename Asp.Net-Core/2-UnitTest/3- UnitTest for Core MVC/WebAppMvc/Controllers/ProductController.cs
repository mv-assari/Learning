using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAppMvc.Models.Entities;
using WebAppMvc.Models.Services;

namespace WebAppMvc.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _product;
        public ProductController(IProductService product)
        {
            _product = product;
        }

    
        // GET: ProductController
        public ActionResult Index()
        {
            return View(_product.GetAll());
        }

        // GET: ProductController/Details/5
        public ActionResult Details(int id)
        {
            var product = _product.GetById(id);
            if(product == null)
                return NotFound();
            
            return View(_product.GetById(id));
        }

        // GET: ProductController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProductController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Product product)
        {
            try
            {
                if (!ModelState.IsValid) 
                    return BadRequest(ModelState);

                _product.Add(product);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductController/Delete/5
        public ActionResult GetDelete(int id)
        {
            return View(_product.GetById(id));
        }

        // POST: ProductController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            try
            {
                _product.Remove(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(nameof(NotFound));
            }
        }
    }
}
