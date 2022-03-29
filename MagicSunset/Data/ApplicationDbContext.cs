using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using MagicSunset.Data;

namespace MagicSunset.Data
{
    public class ApplicationDbContext : IdentityDbContext<Users>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        //public DbSet<MagicSunset.Data.Dishess> Dish { get; set; }
        //public DbSet<MagicSunset.Data.Drinks> Drink { get; set; }
        public DbSet<MagicSunset.Data.Order> Orders { get; set; }
        public DbSet<MagicSunset.Data.Tables> Tables { get; set; }
        public DbSet<MagicSunset.Data.Reservations> Reservations { get; set; }
        public DbSet<MagicSunset.Data.Dishess> Dishess { get; set; }
        public DbSet<MagicSunset.Data.Drinks> Drinks { get; set; }
        public DbSet<MagicSunset.Data.Dishkind> Dishkind { get; set; }
        public DbSet<MagicSunset.Data.Drinkkind> Drinkkind { get; set; }


    }
}
