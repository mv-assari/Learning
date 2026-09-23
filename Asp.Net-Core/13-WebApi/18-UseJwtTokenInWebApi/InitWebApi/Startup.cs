using InitWebApi.Models.Context;
using InitWebApi.Models.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace InitWebApi
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

            services.AddControllers();

            services.AddAuthentication(op =>
            {
                op.DefaultSignInScheme = JwtBearerDefaults.AuthenticationScheme;
                op.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                op.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(c =>
            {
                c.TokenValidationParameters = new TokenValidationParameters()
                {
                    ValidIssuer = Configuration["JWTConfig:issuer"],
                    ValidAudience = Configuration["JWTConfig:audience"],
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["JWTConfig:key"])),
                    ValidateIssuerSigningKey = true,
                    ValidateLifetime = true
                };

                c.SaveToken = true;
                c.Events = new JwtBearerEvents
                {
                    OnAuthenticationFailed= context=>
                    {
                        //log
                        //.........
                        return Task.CompletedTask;
                    },
                    OnTokenValidated = context =>
                    {
                        //coustom validate
                        //...........
                        return Task.CompletedTask;
                    },
                    OnChallenge = context =>
                    {
                        //log change
                        return Task.CompletedTask;
                    },
                    OnMessageReceived = context =>
                    {
                        //when sever is recived token this event is running
                        //log or .......
                        return Task.CompletedTask;
                    },
                    OnForbidden= context =>
                    {
                        return Task.CompletedTask;
                    }
                };
            });



            string connection = "data source=.; initial catalog=WebApi; integrated security=true; multipleactiveresultsets=true";

            services.AddEntityFrameworkSqlServer().AddDbContext<DataBaseContext>(op => op.UseSqlServer(connection));
            services.AddScoped<ToDoRepository, ToDoRepository>();// register in IOC container
            services.AddScoped<CategoryRepository, CategoryRepository>();

            services.AddApiVersioning(op =>
            {
                op.AssumeDefaultVersionWhenUnspecified = true;
                op.DefaultApiVersion = new ApiVersion(1, 0);
                op.ReportApiVersions= true;
            });

            services.AddSwaggerGen(c =>
            {
                c.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, "InitWebApi.xml"), true); //برای فعال کردن فایل سند
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "InitWebApi", Version = "v1" });
                //c.SwaggerDoc("v2", new OpenApiInfo { Title = "InitWebApi", Version = "v2" });

                c.DescribeAllEnumsAsStrings();//برای اینکه enum ها به صورت عدد نباشند و متن قابل فهم ایجاد بشه ازین تنظیم استفاده میکنیم

                //c.DocInclusionPredicate((docName, apiDesc) =>
                //{
                //    if (!apiDesc.TryGetMethodInfo(out var methodInfo)) return false;

                //    var versions = methodInfo.DeclaringType
                //        .GetCustomAttributes<ApiVersionAttribute>(true)
                //        .SelectMany(attr => attr.Versions);

                //    return versions.Any(v => $"v{v.ToString()}" == docName);
                //});
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c =>
                {
                    c.SwaggerEndpoint("/swagger/v1/swagger.json", "InitWebApi v1");
                    //c.SwaggerEndpoint("/swagger/v2/swagger.json", "InitWebApi v2");
                });
            }

            app.UseHttpsRedirection();

            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
