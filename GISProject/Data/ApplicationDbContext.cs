using GISProject.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GISProject.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        DbSet<Category> Categories { get; set; }
        DbSet<Point> Points { get; set; }
        DbSet<ApplicationUser> ApplicationUsers { get; set; }
        DbSet<AppUserDetails> AppUserDetails { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

    }
}