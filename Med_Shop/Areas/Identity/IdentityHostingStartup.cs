using System;
using Med_Shop.Areas.Identity.Data;
using Med_Shop.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(Med_Shop.Areas.Identity.IdentityHostingStartup))]

namespace Med_Shop.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) =>
            {
                services.AddDbContext<Med_ShopSecurityDBContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("Med_ShopSecurityDBContextConnection")));

                services.AddDefaultIdentity<ApplicationUser>(options =>
                {
                    options.SignIn.RequireConfirmedAccount = false;
                    options.Password.RequireUppercase = false;
                    options.Password.RequireLowercase = false;
                })
                .AddRoles<IdentityRole>()
                    .AddEntityFrameworkStores<Med_ShopSecurityDBContext>();
            });
        }
    }
}