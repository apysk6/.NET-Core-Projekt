using System;
using System.Collections.Generic;
using System.Text;
using GuitarProjectWebsite.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GuitarProjectWebsite.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Guitar> Guitars { get; set; }

        public DbSet<Producer> Producers { get; set; }

        public DbSet<Category> Categories { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Guitar>().ToTable("Guitar");
            modelBuilder.Entity<Producer>().ToTable("Producer");
            modelBuilder.Entity<Category>().ToTable("Category");
        }
    }
}
