using System;
using System.Collections.Generic;
using System.Linq;
using LearnMore.Data.Context;
using LearnMore.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace LearnMore.Data
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new AppDbContext(serviceProvider.GetRequiredService<DbContextOptions<AppDbContext>>()))
            {

                if (context.Tests.Any())
                {
                    return;
                }

                context.Tests.AddRange(
                    new List<Test>
                    {
                        new Test { Title = "First Test" },
                        new Test { Title = "Second Test" },
                        new Test { Title = "Third Test" },
                        new Test { Title = "Sample Test" },
                    });

                context.SaveChanges();
            }
        }
    }
}