using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DevOpsProjectOne.Models;

namespace DevOpsProjectOne.Data
{
    public class CompanyContext : DbContext
    {
        public CompanyContext (DbContextOptions<CompanyContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; } = default!;
        public DbSet<Vendor> Vendor { get; set; }
        public DbSet<Part> Part { get; set; }
        public DbSet<Part_Plant> Part_Plant { get; set; }
        public DbSet<Plant> Plant { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("Users");
            modelBuilder.Entity<Vendor>().ToTable("Vendor");
            modelBuilder.Entity<Part>().ToTable("Parts");
            modelBuilder.Entity<Part_Plant>().ToTable("Plants_Parts");
            modelBuilder.Entity<Plant>().ToTable("Plants");
        }

    }
}
