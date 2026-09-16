using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using RunIdentity.Data;
using RunIdentity.Helper;
using RunIdentity.Models.Entities;

namespace RunIdentity
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
            //اینجا رشته اتصال رو معرفی میکنیم
            services.AddDbContext<DataBaseContext>(p => p.UseSqlServer("server=.;initial catalog=identitydb;integrated security=true;"));
            services.AddControllersWithViews();

            services.AddIdentity<User, Role>()// برای اینکه سرویس ها ایدنتیتی برای ما فعال بشه باید اینکارو انجام بدیم
                .AddEntityFrameworkStores<DataBaseContext>()
                .AddDefaultTokenProviders()
                .AddRoles<Role>() //برای اینکه نقش ها در کلیم ذخیره بشه و سیستم بتونه ازون استفاده کنه باید این کانفیگ روهم انجام بدیم
                .AddErrorDescriber<CustomIdentityError>() //برای اینکه تنظیم کنیم خطاهارو از این کلاس بگیره
                .AddPasswordValidator<MyPasswordValidator>(); //اعتبار سنجی مخصوص به خود برای سیستم


            //services.AddScoped<IUserClaimsPrincipalFactory<User>, AddMyClaims>(); // کارهای مربوط به claim 
            //services.AddScoped<IClaimsTransformation, AddMyClaim>();// این هم روش دیگری برای اضافه کردن کلیم های مختلف میباشد که از روش بالایی بهتر هست

            //services.Configure<IdentityOptions>(op =>
            //{
            //    //user setting
            //    op.User.RequireUniqueEmail = true;

            //    //password setting
            //    op.Password.RequireDigit = false;
            //    op.Password.RequireLowercase = false;

            //    //lockout setting
            //    op.Lockout.MaxFailedAccessAttempts = 3;
            //    op.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(10);

            //    //signin setting
            //    op.SignIn.RequireConfirmedAccount= true;
            //    op.SignIn.RequireConfirmedEmail= true;
            //    op.SignIn.RequireConfirmedPhoneNumber= true;

            //});

            //services.ConfigureApplicationCookie(op =>
            //{
            //    //cookie setting
            //    op.ExpireTimeSpan=TimeSpan.FromMinutes(10);
            //});

            services.AddAuthorization(op =>
            {
                op.AddPolicy("Buyer", po =>
                {
                    po.RequireClaim("Buyer");
                });

                op.AddPolicy("BloodType", po =>
                {
                    po.RequireClaim("Blood", new List<string>{ "Ap", "Op" });
                });

                op.AddPolicy("Credit", po =>
                {
                    po.Requirements.Add(new UserCrediteRequerment(10000));
                });

                op.AddPolicy("IsBlogForUser", po =>
                {
                    po.AddRequirements(new BlogRequirement());
                });
            });

            //services.AddSingleton<IAuthorizationHandler, UserCreditHandler>();
            services.AddSingleton<IAuthorizationHandler, IsBlogForUser>();
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

            app.UseAuthentication(); //این قسمت رو هم باید در میدلویر اضافه کرد تا لاگین ثبت شود
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute( //این قسمت رو باید به فایل اضافه کرد تا نواحی مختلف به درستی کار کنند
                    name: "areas",
                    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");

            });
        }
    }
}
