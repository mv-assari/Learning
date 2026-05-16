using System;
using System.Net;

namespace ErrorHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int[] array= { 1,2,4};
            
            try
            {

                int result = 0;
                bool bb=TryDiv(5,1,out result);


                int result2 = 0;
                bool aa= int.TryParse("asdf",out result2);



                TestMethod("");

                int a = 0, b = 5;
                int c = b / array[100];

                WebClient client = new WebClient();
                client.DownloadString("https://testsite.ir");
            }
            catch(WebException ex) when (ex.Status==WebExceptionStatus.SendFailure)
            {
                //
            }
            catch(WebException ex) when (ex.Status == WebExceptionStatus.Timeout)
            {
                //
            }
            catch (WebException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("you can not divide by zero");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                //همیشه اجرا میشه مثل بستن کانکشنی که به دیتابیس متصل هست
            }


            Console.ReadLine();
        }

        static private void TestMethod(string name)
        {
            try
            {
                TestMethod2(name);
                if (string.IsNullOrEmpty(name))
                    throw new NotSupportedException("Name is NullOrEmpty");
            }
            catch (Exception ex)
            {
                ex.Data.Add("testdata", "خطا رخ داده است");
                throw new Exception(ex.Message, ex);
            }
        }

        static private void TestMethod2(string name)
        {
            //throw new NotImplementedException("Not Implemented Exception");
            throw new NotFoundException("Not Found"); //این نوع خطا توسط خودم ایجاد شده
        }

        static private bool TryDiv(int a ,int b , out  int result)
        {
            try
            {
                result = a / b;
                return true;
            }
            catch (Exception)
            {
                result = 0;
                return false;
            }
        }
    }
}
