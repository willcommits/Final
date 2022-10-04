using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Co_Mute.Models;

namespace Co_Mute.Data
{
    public class PoolDatabase : DbContext
    {
        public PoolDatabase (DbContextOptions<PoolDatabase> options)
            : base(options)
        {
        }

        public DbSet<User> User { get; set; }
        public DbSet<Carpool> Carpool { get; set; }
        public DbSet<AvailablePool> AvailablePool { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AvailablePool>().ToTable("Pool_Opportunity");
            modelBuilder.Entity<Carpool>().ToTable("Car_Pool");
            modelBuilder.Entity<User>().ToTable("User");
        }
    }
}
