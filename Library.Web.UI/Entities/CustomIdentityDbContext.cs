using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Library.Web.UI.Entities;


public class CustomIdentityDbContext:IdentityDbContext<CustomIdentityUser,CustomUserRole,string>
{

    public CustomIdentityDbContext(DbContextOptions<CustomIdentityDbContext> options):base(options)
    {
            
    }
}
