using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using CLD.Models;

namespace CLD.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ConsultantExpertise>()
        .HasKey(bc => new { bc.ConsultantId, bc.ExpertiseId });
            modelBuilder.Entity<ConsultantExpertise>()
                .HasOne(bc => bc.Consultant)
                .WithMany(b => b.ConsultantExpertise)
                .HasForeignKey(bc => bc.ConsultantId);
            modelBuilder.Entity<ConsultantExpertise>()
                .HasOne(bc => bc.Expertise)
                .WithMany(c => c.ConsultantExpertise)
                .HasForeignKey(b => b.ExpertiseId);
        }

    
     

    
      public DbSet<CLD.Models.Consultant> Consultant { get; set; }
        public DbSet<CLD.Models.User> User { get; set; }
        public DbSet<CLD.Models.Contact> Contact { get; set; }
        public DbSet<CLD.Models.Question> Question { get; set; }
        public DbSet<CLD.Models.Category> Category { get; set; }
    }
}
