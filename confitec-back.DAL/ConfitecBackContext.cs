using confitec_back.DL.DB;
using confitec_back.DL.Enums;
using Microsoft.EntityFrameworkCore;
using System;

#nullable disable

namespace confitec_back.DAL
{
    public partial class ConfitecBackContext : DbContext
    {
        public ConfitecBackContext()
        {
        }

        public ConfitecBackContext(DbContextOptions<ConfitecBackContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Usuario> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Name=ConnectionStrings:DefaultConnection");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.ToTable("Usuario");

                entity.Property(e => e.Id)
                    .HasColumnName("id");

                entity.Property(e => e.PrimeiroNome)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("primeiroNome");

                entity.Property(e => e.UltimoNome)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ultimoNome");

                entity.Property(e => e.Email)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.DataNascimento)
                    .HasColumnName("dataNascimento");

                entity.Property(e => e.Escolaridade)
                    .HasConversion(
                        v => v.ToString(),
                        v => (EEscolaridade)Enum.Parse(typeof(EEscolaridade), v))
                    .HasColumnName("escolaridade");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
