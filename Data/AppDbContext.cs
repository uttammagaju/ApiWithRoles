using ApiWithRoles.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ApiWithRoles.Data
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
            
        }
        public DbSet<Login> logins { get; set; }
        public DbSet<Register> registers { get; set; }
        public DbSet<UserRole> userRoles { get; set; }
    }
}
