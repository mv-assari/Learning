using System;

namespace Replace_Array_with_Object
{
    public class After{}

    public class EmployeeService
    {
        public void RegisterEmployee(Employee employee)
        {

            employee.Validate();

            string fullName = employee.FirstName + " " + employee.LastName;
            decimal familyAllowance = employee.Children * 500000;

            Console.WriteLine($"کارمند {fullName} با حقوق {employee.BaseSalary} و حق اولاد {familyAllowance} ثبت شد");
        }
    }

    public class Employee
    {
        private string _firstName;
        private decimal _baseSalary;

        public string FirstName 
        {
            get{ return _firstName;}
            set{_firstName = value;}
        }
        public string LastName { get; set; }
        public string NationalCode { get; set; }
        public decimal BaseSalary 
        {
            get{ return _baseSalary;}
            set{ _baseSalary = value;}
        }
        public byte Children { get; set; }    

        public void Validate()
        {
            if (string.IsNullOrEmpty(FirstName))
                throw new Exception("نام الزامیست");
            if (BaseSalary < 0)
                throw new Exception("حقوق نامعتبر");
        }
    }
}
