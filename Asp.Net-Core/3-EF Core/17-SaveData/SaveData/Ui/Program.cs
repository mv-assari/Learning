using DAL;
using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Ui
{
    internal class Program
    {
        static void Main(string[] args)
        {

            DataBaseContext context = new DataBaseContext();

            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();


            //Add(context);
            //Update(context);
            //Delete(context);
            //MultipleAction(context);
            //AddingGraph(context);
            //AddingRelated(context);
            //ChangingRelation(context);
            //RemoveRelationship(context);
            //Concurrency(context);

            //Transaction(context);

            Console.WriteLine("Hello World!");
        }

        private static void Transaction(DataBaseContext context)
        {
            // اولا اینکه در خود متد savechange  قابلیت رولبک وجود دارد 
            //یعنی اگر این متد را در آخر بگذاریم و هر کدام از موجودیت ها به مشکل بخورد به صورت خودکار رولبک میشه
            //Pay pay = new Pay()
            //{

            //};
            //context.Pays.Add(pay);


            //Order order = new Order()
            //{

            //};
            //context.Orders.Add(order);
            //context.SaveChanges();

            //یا میتونیم از روش زیر برای مدیریت آن استفاده کنیم
            using (var transaction = context.Database.BeginTransaction())
            {
                Pay pay = new Pay()
                {

                };
                context.Pays.Add(pay);
                context.SaveChanges();

                Order order = new Order()
                {

                };
                context.Orders.Add(order);
                context.SaveChanges();

                transaction.Commit();//تا کامیت نکنیم در دیتابیس ذخیره نمیشه
                                     //transaction.Rollback(); با اینکار کلا تغییرات سمت دیتابیس ذخیره نمیشه

            }
        }

        private static void Concurrency(DataBaseContext context)
        {
            var category = context.Categories.Find((long)1);
            category.Name = "Laptop";

            bool saved = false;

            while (!saved)
            {
                try
                {
                    context.SaveChanges();
                    saved = true;
                }
                catch (DbUpdateConcurrencyException ex)
                {
                    foreach (var entity in ex.Entries)
                    {
                        if (entity.Entity is Category)
                        {
                            var currentValues = entity.CurrentValues;
                            var databaseValues = entity.GetDatabaseValues();

                            foreach (var property in currentValues.Properties)
                            {
                                var c_value = currentValues[property];
                                var databaseValue = databaseValues[property];
                            }

                            entity.OriginalValues.SetValues(databaseValues);
                        }
                    }

                }

            }
        }

        private static void RemoveRelationship(DataBaseContext context)
        {
            var category = context.Categories.Include(p => p.Products).FirstOrDefault(p => p.Id == 3);
            var product = category.Products.FirstOrDefault();
            category.Products.Remove(product);
            context.SaveChanges();
        }

        private static void ChangingRelation(DataBaseContext context)
        {
            var prodcut = context.Products.Find((long)1);
            Category category = new Category
            {
                Name = "SE"
            };

            prodcut.Category = category;
            context.SaveChanges();
        }

        private static void AddingRelated(DataBaseContext context)
        {
            var category = context.Categories.Include(p => p.Products).FirstOrDefault(c => c.Id == 2);
            var product = new Product { Name = "Apple" };
            category.Products.Add(product);
            context.SaveChanges();
        }

        private static void AddingGraph(DataBaseContext context)
        {
            Category category = new Category()
            {
                Name = "Pc",
                Products = new List<Product>
                {
                    new Product{Name="Dell"},
                    new Product{Name="Lenovo"}
                }
            };

            context.Categories.Add(category);
            context.SaveChanges();
        }

        private static void MultipleAction(DataBaseContext context)
        {
            Category category = new Category()
            {
                Name = "Laptop"
            };

            context.Categories.Add(category);

            var categoryUp = context.Categories.FirstOrDefault();
            categoryUp.Name = "Mobile";

            context.Categories.Remove(new Category { Id = 1 });

            context.SaveChanges();
        }

        private static void Delete(DataBaseContext context)
        {
            //var category = context.Categories.Find((long)1);
            //context.Categories.Remove(category); به این صورت هم میشه

            context.Categories.Remove(new Category { Id = 1 });
            context.SaveChanges();
        }

        private static void Update(DataBaseContext context)
        {
            //برای آپدیت دیتا حتما باید ترک شده باشد واگرنه در دیتابیس تغییری ایجاد نمیشه
            var category = context.Categories.FirstOrDefault();
            category.Name = "Mobile";
            //context.Categories.Update (category); تست کردم موردی نبود به صورت خودجوش
            context.SaveChanges();
        }

        private static void Add(DataBaseContext context)
        {
            Category category = new Category()
            {
                Name = "Laptop"
            };

            context.Categories.Add(category);
            context.SaveChanges();
        }
    }
}
