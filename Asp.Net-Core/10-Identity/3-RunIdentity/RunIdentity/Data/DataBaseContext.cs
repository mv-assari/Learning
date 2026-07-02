using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace RunIdentity.Data
{
    public class DataBaseContext:IdentityDbContext<IdentityUser>
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
    }
}
