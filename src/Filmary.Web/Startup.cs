using Filmary.BLL.Api.Interfaces;
using Filmary.BLL.Api.Services;
using Filmary.BLL.Interfaces;
using Filmary.BLL.Repository;
using Filmary.BLL.Services;
using Filmary.Common.Interfaces;
using Filmary.Context;
using Filmary.DAL.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NETCore.MailKit.Extensions;
using NETCore.MailKit.Infrastructure.Internal;
using System;

namespace Filmary.Web
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

            services.AddScoped<IProfileService, ProfileService>();
            services.AddScoped<IApiService, ApiService>();
            services.AddScoped<IFilmsService, FilmsService>();
            services.AddDbContext<FilmaryDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("FilmaryDatabase")));

            services.AddIdentity<User, IdentityRole>()
                .AddEntityFrameworkStores<FilmaryDbContext>()
                .AddDefaultTokenProviders();

            services.AddControllersWithViews();

            // NuGet services
            var mailKitOptions = Configuration.GetSection("Mail").Get<MailKitOptions>();
            services.AddMailKit(optionBuilder =>
            {
                optionBuilder.UseMailKit(new MailKitOptions()
                {
                    Server = mailKitOptions.Server,
                    Port = mailKitOptions.Port,
                    SenderName = mailKitOptions.SenderName,
                    SenderEmail = mailKitOptions.SenderEmail,
                    Account = mailKitOptions.Account,
                    Password = mailKitOptions.Password,
                    Security = true
                });
            });
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseDeveloperExceptionPage();

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();    // add autentification
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}