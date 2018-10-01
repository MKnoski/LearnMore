using LearnMore.Data.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LearnMore.Data.Context
{
    public class AppDbContext : IdentityDbContext<AppUserEntity>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {          
        }

        public DbSet<TestEntity> Tests { get; set; }

        public DbSet<CustomerEntity> Customers { get; set; }
    }
}