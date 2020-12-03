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
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=SHASTRY;Database=harshaDB;Trusted_Connection=True;");
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
