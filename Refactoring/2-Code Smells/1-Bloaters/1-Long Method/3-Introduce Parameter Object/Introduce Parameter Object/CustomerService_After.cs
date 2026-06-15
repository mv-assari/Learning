using System;
using System.Collections.Generic;
using System.Linq;

namespace Introduce_Parameter_Object
{
    public class CustomerService_After
    {
        private readonly List<Customer> _customers = new();

        public void RegisterCustomer(CustomerDto customerDto)
        {
            // اعتبارسنجی
            customerDto.Validation();

            var customer = new Customer
            {
                FirstName = customerDto.FirstName,
                LastName = customerDto.LastName,
                Email = customerDto.Email,
                Phone = customerDto.Phone,
                Address = customerDto.Address,
                City = customerDto.City,
                PostalCode = customerDto.PostalCode,
                BirthDate = customerDto.BirthDate
            };

            _customers.Add(customer);

            Console.WriteLine($"مشتری {customer.FirstName} {customer.LastName} ثبت شد");
        }

        public void UpdateCustomer(int customerId,CustomerDto customerDto)
        {
            // دوباره همون اعتبارسنجی تکراری!
            customerDto.Validation();

            var customer = _customers.FirstOrDefault(c => c.Id == customerId);
            if (customer == null) return;

            customer.FirstName = customerDto.FirstName;
            customer.LastName = customerDto.LastName;
            customer.Email = customerDto.Email;
            customer.Phone = customerDto.Phone;
            customer.Address = customerDto.Address;
            customer.City = customerDto.City;
            customer.PostalCode = customerDto.PostalCode;
            customer.BirthDate = customerDto.BirthDate;


            Console.WriteLine($"مشتری {customerDto.FirstName} {customerDto.LastName} بروزرسانی شد");
        }
    }

    public class CustomerDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public DateTime BirthDate { get; set; }

        public void Validation()
        {
            if (string.IsNullOrEmpty(FirstName))
                throw new ArgumentException("نام الزامیست");
            if (string.IsNullOrEmpty(LastName))
                throw new ArgumentException("نام خانوادگی الزامیست");
            if (string.IsNullOrEmpty(Email))
                throw new ArgumentException("ایمیل الزامیست");
        }
    }

    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public DateTime BirthDate { get; set; }

    }
}
