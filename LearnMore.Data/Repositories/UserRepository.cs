﻿using LearnMore.Data.Context;
using LearnMore.Data.Entities;
using LearnMore.Data.Repositories.Contracts;
using LearnMore.Domain.Models;
using System.Threading.Tasks;
using LearnMore.Domain.Models.Registration;

namespace LearnMore.Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext appDbContext;

        public UserRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public async Task<Result> AddUserAsync(string id, Registration model)
        {
            var newCustomer = new CustomerEntity
            {
                IdentityId = id,
                Gender = model.Gender          
            };

            await this.appDbContext.Customers.AddAsync(newCustomer);
            var result = await this.appDbContext.SaveChangesAsync();

            return new Result(result == 1);
        }
    }
}
