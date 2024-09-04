using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Radhey.DAL.IdentityTables;

using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Radhey.DAL.DatabaseContext
{
    public class RadheyDbContext : IdentityDbContext<TblApplicationUser>
    {

        public RadheyDbContext(DbContextOptions<RadheyDbContext> options) : base(options)
        {
        }

#nullable disable
        public DbSet<TblApplicationUser> AspNetUsers { get; set; }






    }
}
