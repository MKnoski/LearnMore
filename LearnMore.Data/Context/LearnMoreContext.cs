using LearnMore.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace LearnMore.Data.Context
{
    public class LearnMoreContext : DbContext
    {
        public LearnMoreContext(DbContextOptions<LearnMoreContext> options)
            : base(options)
        {          
        }

        public DbSet<Test> Tests { get; set; }
    }
}