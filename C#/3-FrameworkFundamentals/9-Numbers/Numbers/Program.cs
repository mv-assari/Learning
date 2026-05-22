using System.Numerics;
using System.Security.Cryptography;

Console.WriteLine(Math.Round(32.444));
Console.WriteLine(Math.Sin(90));


double result1 = Math.Pow(10, 10000);
Console.WriteLine(result1);

BigInteger big = BigInteger.Pow(10, 10000);
Console.WriteLine(big);

Random random = new Random();
Console.WriteLine(random.Next(500));
Console.WriteLine(random.Next(500));
Console.WriteLine(random.Next(500));
Console.WriteLine(random.Next(500));
Console.WriteLine(random.Next(500));

var random2=RandomNumberGenerator.Create(); //همون کار رندوم رو انجام میده ولی احتمال تکراری بودن خیلی کم هست و برای کارهای خیلی حساس مورد استفاده قرار میگیره
byte[] bytes = new byte[4];

random2.GetBytes(bytes);
int randomNumber=BitConverter.ToInt32(bytes, 0);
Console.WriteLine(randomNumber);



Console.ReadLine();