using AutoMapper;
using FluentValidation.AspNetCore;
using LearnMore.Api.DependencyInjection;
using LearnMore.Api.Extensions;
using LearnMore.Api.Validation;
using LearnMore.Data.Context;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace LearnMore.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            var connectionString = Configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(connectionString));

            services.RegisterServices();
            services.RegisterManagers();
            services.RegisterRepositories();

            services.AddAutoMapper();

            services.AddMvc().AddFluentValidation();

            services.ConfigureIdentity();
            services.AddLogging();

            services.RegisterValidators();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            loggerFactory.AddFile("Logs/myapp-{Date}.txt");

            app.UseMvc();
        }
    }
}
