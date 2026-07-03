using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RunIdentity.Models.Entities;

namespace RunIdentity.Data
{
    public class DataBaseContext:IdentityDbContext<User,Role,string> //موجودیت شخصی سازی شده خودمون
    {
        //در اینجا ما چند کتابخانه باید نصب کنیم 
        //Microsoft.AspNetCore.Identity.EntityFrameworkCore
        //Microsoft.EntityFrameworkCore
        //Microsoft.EntityFrameworkCore.Design
        //Microsoft.EntityFrameworkCore.SqlServer
        //Microsoft.EntityFrameworkCore.Tools
        public DataBaseContext(DbContextOptions<DataBaseContext> options):base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<IdentityUserLogin<string>>().HasKey(p => new {p.ProviderKey,p.LoginProvider});
            builder.Entity<IdentityUserRole<string>>().HasKey(p => new {p.RoleId,p.UserId});
            builder.Entity<IdentityUserToken<string>>().HasKey(p => new {p.UserId,p.LoginProvider,p.Name});

            builder.Entity<User>().Ignore(u => u.NormalizedEmail);
        }
    }
}
