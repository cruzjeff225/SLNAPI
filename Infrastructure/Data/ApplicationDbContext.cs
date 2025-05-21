using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<Persona> Personas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Persona>().Property(p => p.Nombre)
                .IsRequired()
                .HasMaxLength(100);
            modelBuilder.Entity<Persona>().Property(p => p.Apellido)
                .IsRequired()
                .HasMaxLength(100);
            modelBuilder.Entity<Persona>().Property(p => p.FechaNacimiento)
                .IsRequired();
            modelBuilder.Entity<Persona>().Property(p => p.Telefono)
                .IsRequired()
                .HasMaxLength(20);
            modelBuilder.Entity<Persona>().Property(p => p.DUI)
                .IsRequired()
                .HasMaxLength(10);
        }
    }
}
