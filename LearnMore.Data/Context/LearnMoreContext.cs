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

        public DbSet<Quiz> Quizzes { get; set; }
    }
}