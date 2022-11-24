using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Med_Shop.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Med_Shop.Data
{
    public class Med_ShopSecurityDBContext : IdentityDbContext<ApplicationUser>
    {
        public Med_ShopSecurityDBContext(DbContextOptions<Med_ShopSecurityDBContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}
