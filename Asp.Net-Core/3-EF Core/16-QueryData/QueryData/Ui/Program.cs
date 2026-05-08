using DAL;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace Ui
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataBaseContext context = new DataBaseContext();
            //QueryData1(context);

            //ClientVsServer(context);

            //TrackingVsNoTracking(context);

            //FromSqlRaw(context);

            //IgnoreQueryFilter(context);

            //AsEnumerableVsAsQueryable(context);

            Console.WriteLine("Hello World!");
        }

        private static void AsEnumerableVsAsQueryable(DataBaseContext context)
        {
            var usersEnumerable = context.Users.AsEnumerable(); // در همینجا تمام کاربران را میدهد و تغییراتی نمیتوان روی کوئری اعمال کرد
            usersEnumerable = usersEnumerable.Where(p => p.Name.Contains("M")); // این قسمت در سمت کلاینت اجرا میشود
            var userlist = usersEnumerable.ToList(); // و نتیجه نهایی را میدهد

            var userQueryable = context.Users.AsQueryable(); // هنوز کوئری سمت دیتابیس نرفته و قابلیت تغییر در سمت کلاینت را دارد
            userQueryable = userQueryable.Where(p => p.Name.Contains("M")); // باز هم میتوان روی کوئری تغییرات اعمال کرد 
            var userlist2 = userQueryable.ToList(); // در نهایت کوئری سمت دیتابیس رفته و موارد بالایی اعمال میشود
        }

        private static void IgnoreQueryFilter(DataBaseContext context)
        {
            var users = context.Users.ToList(); // فقط آن کاربرهایی را می آورد که حذف نشده باشند چون در کانفیگ تغییرات داریم

            var users2 = context.Users.IgnoreQueryFilters().ToList();// تمام تنظیمات مربوط به کافیگ که با فیلتر هست را نادیده میگیرد و تمام کاربران را برمیگرداند
        }

        private static void FromSqlRaw(DataBaseContext context)
        {
            var posts = context.Posts.FromSqlRaw("SELECT * FROM POSTS").ToList();
        }

        private static void TrackingVsNoTracking(DataBaseContext context)
        {
            //context.ChangeTracker.QueryTrackingBehavior=QueryTrackingBehavior.NoTracking برای ترک کردن داده با این کانتکس

            var tags = context.Tags.ToList();

            var posts = context.Posts.AsNoTracking().FirstOrDefault(); // به این صورت میتوان نیز تغییرات را فقط برای این متغیر انجام داد و روی کل کانتکس تغییرات اعمال نشود
            var posts2 = context.Posts.FirstOrDefault(); // چون از قبل تگ ها لود شده بود پس داده های تگ را نمایش میده

            var tag1 = context.Tags.Where(t => t.Id == 1).FirstOrDefault();

            var tag2 = context.Tags.Find((long)2); // چون داده ترک شده است دیگر برای این مورد سمت دینابیس نمیرود و از اسنپشات که داده ها را در خود ذخیره کرده استفاده میکنه و این برای پرفرمنس خوب هست

            //در کل اگر بخواهیم روی مجموعه فقط داده های آن را بخوانیم بهتر است از نوترکینگ استفاده کنیم
            //و اگر بخواهیم روی داده ها تغییراتی اعمال کنیم باید از ترکینگ استفاده کنیم چون تغییرات در نهایت در دیتابیس ثبت نمیشوند
        }

        private static void ClientVsServer(DataBaseContext context)
        {
            //چون شرط باید بوسیله یک متد در خود سی شارپ چک شود به خطا میخوره پس
            //در این مورد ابتدا تمام داده ها لود میشود سپس شروط اعمال میشه
            var prodcut = context.Products.ToList().Where(p => CalculatTax(p.Price) > 7000)
                .Select(p => new
                {
                    Price = CalculatTax(p.Price)
                }).ToList();
        }

        public static decimal CalculatTax(long Price)
        {
            return (Price * 9) / 100;
        }

        private static void QueryData1(DataBaseContext context)
        {
            //context.Database.EnsureDeleted();
            //context.Database.EnsureCreated();

            //var result = context.Posts.ToQueryString();
            //var postList = context.Posts.TagWith("this is comment").ToList();


            //-----Eager Loading
            //var posts = context.Posts
            //    .Include(p=>p.Category)
            //    .Include(p=>p.Comments).ThenInclude(u=>u.User)
            //    .Include(p=>p.Tags)
            //    .ToList();

            //var post = context.Posts.Include(p => p.Comments).ToList();
            //var postSplit = context.Posts.Include(p => p.Comments).AsSplitQuery().ToList();

            //var posts = context.Posts.Include(p => p.Comments.Where(c => c.IsConfirm == true)).ToList();

            //------Explicit Loading //بر اساس یک معباری میتوان داده مرتبط را لود کرد
            var post = context.Posts.Where(p => p.Id == 1).FirstOrDefault();

            context.Entry(post).Collection(p => p.Comments).Load();

            context.Entry(post).Reference(p => p.Category).Load();

            var commentCount = context.Entry(post).Collection(p => p.Comments).Query().Count();

            //Lazy Loading // داده های مرتبط را بدون هیچ محدودیتی کامل لود میکند که این کار خیلی خطرناک است و به صورت پیش فرض نیز این مورد غیرفعال هست 

            // به دو صورت فعال میشود
            //proxy
            // که باید کتابخونه مخصوص به خودش رو نصب کرد که باید روی دیتااکسس لایر نیز نصب شود
            //اگر بخوام از این نوع لود کردن استفاده کنم باید تمام نویگیشن های من در موجودیت ها باید به صورت ویرچوال تعریف شده باشند

            var posts = context.Posts.FirstOrDefault();
        }
    }
}
