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
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("User");
        }
        public DbSet<DevOpsProjectOne.Models.Vendor> Vendor { get; set; }
        public DbSet<DevOpsProjectOne.Models.Part> Part { get; set; }
        public DbSet<DevOpsProjectOne.Models.Part_Plant> Part_Plant { get; set; }
        public DbSet<DevOpsProjectOne.Models.Plant> Plant { get; set; }
    }
}
