using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConfigRazorPages.Data;
using ConfigRazorPages.Models.Filters;
using ConfigRazorPages.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace ConfigRazorPages
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
            services.AddRazorPages()
            .AddMvcOptions(op =>
            {
                op.Filters.Add(new MyPageFilter()); //با این کار میتونیم به صورت سراسری روی تمام صفحات فیلتر مشخص کرد
            })
            .AddRazorPagesOptions(op=> { //این مورد برای تغییر پوشه پیشفرض هست که الان pages به content تغییر کرد
                //op.RootDirectory = "/Content";
            });

            services.AddDbContext<DataBaseContext>(op => op.UseSqlServer(Configuration["ConnectionStrings:ShopingConnectionString"]));
            services.AddScoped<IProductService, ProductService>();

            services.Configure<RouteOptions>(op =>
            {
                op.LowercaseUrls = true;
                op.LowercaseQueryStrings = true;
            });
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
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });
        }
    }
}
