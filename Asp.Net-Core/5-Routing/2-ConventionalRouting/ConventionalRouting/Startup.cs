using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace ConventionalRouting
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                //در اینجا ترتیب روتینگها مهم هست و هر کدام که بالاتر باشد زودتر بررسی میشود
                

                endpoints.MapControllerRoute(
                    name: "about",
                    pattern: "about",
                    defaults: new { controller = "Home", action = "About" });

                //endpoints.MapControllerRoute( //ترتیب اجرا مهم و تعیین کننده هست
                //    name: "blog2222222",
                //    pattern: "blog",
                //    defaults: new { controller = "product", action = "index" });

                endpoints.MapControllerRoute(
                    name: "blog", 
                    pattern: "blog" ,
                    defaults: new {controller="blog" ,action="index"});

                endpoints.MapControllerRoute(
                    name: "detail", 
                    pattern: "blog/{category}/{url}",
                    defaults: new { controller = "blog", action = "Detail" });

                endpoints.MapControllerRoute(
                    name: "prodcut", 
                    pattern: "product",
                    defaults: new { controller = "product", action = "index" });

                //endpoints.MapControllerRoute(
                //    name: "prodcut", 
                //    pattern: "product/{*index}",//اگه از ستاره استفاده کنیم هر چیزی به جای ایندکس بنویسیم وارد این اکشن میشه 
                //    defaults: new { controller = "product", action = "index" });

                endpoints.MapControllerRoute(
                    name: "default", //نام ها نباید تکراری باشند
                    pattern: "{controller=Home}/{action=Index}/{id?}/{name?}");
            });
        }
    }
}
