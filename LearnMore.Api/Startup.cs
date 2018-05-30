using System.Text;
using AutoMapper;
using FluentValidation.AspNetCore;
using LearnMore.Api.DependencyInjection;
using LearnMore.Api.Extensions;
using LearnMore.Api.Validation;
using LearnMore.Data.Context;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using JwtIssuerOptions = LearnMore.BusinessLogic.JWT.JwtIssuerOptions;

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
            services.TryAddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            services.AddAutoMapper();

            services.AddMvc().AddFluentValidation();

            services.ConfigureIdentity();
            services.AddLogging();

            services.RegisterValidators();

            var jwtAppSettingOptions = Configuration.GetSection(nameof(JwtIssuerOptions));
            var secretsSection = Configuration.GetSection("Secrets");
            var securityKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(secretsSection["JwtSecretKey"]));
            services.ConfigureJwtSecurity(jwtAppSettingOptions, securityKey);
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();

                builder.AddUserSecrets<Startup>();
            }

            loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            loggerFactory.AddDebug();
            loggerFactory.AddFile("../logs/LearnMore-{Date}.log");

            app.UseAuthentication();
            app.UseMvc();
        }
    }
}
