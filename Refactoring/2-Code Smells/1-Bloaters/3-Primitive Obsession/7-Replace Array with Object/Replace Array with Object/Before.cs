using System;

namespace Replace_Array_with_Object
{
    public class Before
    {
    }

    public class EmployeeService
    {
        public void RegisterEmployee(string[] data)
        {
            // data[0] = نام
            // data[1] = نام خانوادگی
            // data[2] = کد ملی
            // data[3] = حقوق پایه
            // data[4] = تعداد فرزندان

            if (string.IsNullOrEmpty(data[0]))
                throw new Exception("نام الزامیست");

            if (data[3] == null || decimal.Parse(data[3]) < 0)
                throw new Exception("حقوق نامعتبر");

            string fullName = data[0] + " " + data[1];
            decimal salary = decimal.Parse(data[3]);
            int children = int.Parse(data[4]);
            decimal familyAllowance = children * 500000;

            Console.WriteLine($"کارمند {fullName} با حقوق {salary} و حق اولاد {familyAllowance} ثبت شد");
        }
    }
}
