using System;

namespace Record
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Location location = new Location(20,30);
            Console.WriteLine(location);
            (double lat, double lag) = location;

            //فقط این پراپرتی تغییر میکند و بقیه پراپرتی ها مستقیما کپی میشه به رکورد جدید
            Location location2 = location with { Lat = 24 };

            //compare is by value ,not by reference
            Console.WriteLine(location==location2);




            Console.ReadLine();
        }
    }


    //نحوه تعریف رکورد
    //public record Location
    //{

    //    public Location(double lat,double lng)
    //    {
    //        this.Lat = lat;
    //        this.Lng = lng;
    //    }

    //    public double Lat { get; init; }
    //    public double Lng { get; init; }
    //}

    //نحوه دیگر تعریف رکورد و ساده تر که همان کار بالا را انجام میدهد
    record Location(double Lat,double Lng);
}
