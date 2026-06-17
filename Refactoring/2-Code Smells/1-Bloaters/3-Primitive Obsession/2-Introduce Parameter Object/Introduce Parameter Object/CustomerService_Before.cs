using System;
using System.Collections.Generic;
using System.Linq;

namespace Introduce_Parameter_Object
{
    public class CustomerService_Before
    {
        private readonly List<Customer> _customers = new();

        public void RegisterCustomer(
            string firstName,
            string lastName,
            string email,
            string phone,
            string address,
            string city,
            string postalCode,
            DateTime birthDate)
        {
            // اعتبارسنجی
            if (string.IsNullOrEmpty(firstName))
                throw new ArgumentException("نام الزامیست");
            if (string.IsNullOrEmpty(lastName))
                throw new ArgumentException("نام خانوادگی الزامیست");
            if (string.IsNullOrEmpty(email))
                throw new ArgumentException("ایمیل الزامیست");

            var customer = new Customer
            {
                FirstName = firstName,
                LastName = lastName,
                Email = email,
                Phone = phone,
                Address = address,
                City = city,
                PostalCode = postalCode,
                BirthDate = birthDate
            };

            _customers.Add(customer);
            Console.WriteLine($"مشتری {firstName} {lastName} ثبت شد");
        }

        public void UpdateCustomer(
            int customerId,
            string firstName,
            string lastName,
            string email,
            string phone,
            string address,
            string city,
            string postalCode,
            DateTime birthDate)
        {
            // دوباره همون اعتبارسنجی تکراری!
            if (string.IsNullOrEmpty(firstName))
                throw new ArgumentException("نام الزامیست");
            if (string.IsNullOrEmpty(lastName))
                throw new ArgumentException("نام خانوادگی الزامیست");
            if (string.IsNullOrEmpty(email))
                throw new ArgumentException("ایمیل الزامیست");

            var customer = _customers.FirstOrDefault(c => c.Id == customerId);
            if (customer == null) return;

            customer.FirstName = firstName;
            customer.LastName = lastName;
            customer.Email = email;
            customer.Phone = phone;
            customer.Address = address;
            customer.City = city;
            customer.PostalCode = postalCode;
            customer.BirthDate = birthDate;

            Console.WriteLine($"مشتری {firstName} {lastName} بروزرسانی شد");
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
