using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repository;
using System.Collections.Generic;

namespace DapperApp.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerController(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }
        // GET: CustomerController
        public ActionResult Index()
        
        {
            return View(_customerRepository.GetCustomers());


            //_customerRepository.Add(new CustomerDto { FirstName="Fatemeh",LastName="Tabasi"});

            //List<CustomerDto> customers = new List<CustomerDto>
            //{
            //    new CustomerDto{FirstName="ali",LastName="karimi"},
            //    new CustomerDto{FirstName="ali",LastName="khameni"},
            //    new CustomerDto{FirstName="hashem",LastName="babaie"}
            //};
            //_customerRepository.Add(customers);

            //_customerRepository.Delete(4);

            //_customerRepository.Update(new CustomerDto { Id = 1 ,FirstName="Vahid",LastName="Maleki"});

            //List<CustomerDto> customers = new List<CustomerDto>
            //{
            //    new CustomerDto{Id=1,FirstName="Vahid",LastName="Maleki"},
            //    new CustomerDto{Id=2,FirstName="Zahra",LastName="Nemidonamchi"}
            //};
            //_customerRepository.Update(customers);

        }

        // GET: CustomerController/Details/5
        public ActionResult Details(long id)
        {
            return View(_customerRepository.GetCustomer(id));
        }

        // GET: CustomerController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CustomerController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CustomerDto customer)
        {
            try
            {
                _customerRepository.Add(customer);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CustomerController/Edit/5
        public ActionResult Edit(long id)
        {
            return View(_customerRepository.GetCustomer(id));
        }

        // POST: CustomerController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(CustomerDto customer)
        {
            try
            {
                _customerRepository.Update(customer);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CustomerController/Delete/5
        public ActionResult Delete(long id)
        {
            return View(_customerRepository.GetCustomer(id));
        }

        // POST: CustomerController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(CustomerDto customer)
        {
            try
            {
                _customerRepository.Delete(customer.Id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
