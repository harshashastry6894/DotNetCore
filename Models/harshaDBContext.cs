using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace MyApp.Models
{
    public partial class harshaDBContext : DbContext
    {
        public harshaDBContext()
        {
        }

        public harshaDBContext(DbContextOptions<harshaDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Command> Commands { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Name=ConnectionStrings.HarshaDbConnection");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Command>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Command");

                entity.Property(e => e.CodeFirst).HasMaxLength(50);

                entity.Property(e => e.HowTo)
                    .HasMaxLength(50)
                    .HasColumnName("HowTO");

                entity.Property(e => e.Line).HasMaxLength(50);

                entity.Property(e => e.Platform).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
