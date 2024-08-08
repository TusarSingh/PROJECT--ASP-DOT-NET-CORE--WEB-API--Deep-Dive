using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Radhey.DAL.IdentityTables;

namespace Radhey.DAL.DatabaseContext
{
    public class ApplicationDbContext : IdentityDbContext<TblApplicationUser>
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options ) : base( options )
        {
            
        }




        public DbSet<TblApplicationUser> AspNetUser { get; set; }




        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }





    }
}
