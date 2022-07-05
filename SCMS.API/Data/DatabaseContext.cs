using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SCMS.API.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {

        }

        public DbSet<Country> Country { get; set; }
        public DbSet<State> State { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);
        //    modelBuilder.Entity<Country>(e=>e.Property(o=>o.PhoneCode).HasColumnType("tinynt(1)").HasConversion<short>());//for boolean
        //    modelBuilder.Entity<Country>(e=>e.Property(o=>o.ShortName).HasConversion(new BoolToZeroOneConverter<Int16>()).HasColumnType("bit"));//for boolean
        //}
    }
}
