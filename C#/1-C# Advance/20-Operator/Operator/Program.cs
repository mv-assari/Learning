using System;

namespace Operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //عملگرهایی که میتوان بازنویسی کرد
            //== != < > <= >= 
            //+ - * % /

            Square square1=new Square(10);
            Square square2=new Square(15);

            Square square3=square1+square2;

            Console.WriteLine(square3.SideLength);

            Console.WriteLine(square1!=square2);

            Console.ReadLine();
        }
    }

    public class Square
    {
        public Square(int sideLength)
        {
            SideLength = sideLength;
        }

        public int SideLength { get; set; }

        public static Square operator +(Square left, Square right)
        {
            return new Square(left.SideLength + right.SideLength);
        }

        public static bool operator == (Square square1,Square square2)
        {
            return square1.SideLength == square2.SideLength;
        }

        public static bool operator != (Square square1,Square square2)
        {
            return square1.SideLength != square2.SideLength;
        }

        public static bool operator > (Square square1,Square square2)
        {
            return square1.SideLength > square2.SideLength;
        }

        public static bool operator < (Square square1, Square square2)
        {
            return square1.SideLength < square2.SideLength;
        }
    }
}
