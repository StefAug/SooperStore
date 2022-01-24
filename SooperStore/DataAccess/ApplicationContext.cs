using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
        }
        public DbSet<Developer> Developers { get; set; }
        public DbSet<Cos> Cos { get; set; }
        public DbSet<Produs> Produse { get; set; }
        public DbSet<Rol> Rols { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<UserRol> UserRols { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserRol>()
                .HasKey(bc => new { bc.IdUser, bc.IdRol });
            modelBuilder.Entity<UserRol>()
                .HasOne(bc => bc.User)
                .WithMany(b => b.UserRols)
                .HasForeignKey(bc => bc.IdUser);
            modelBuilder.Entity<UserRol>()
                .HasOne(bc => bc.Rol)
                .WithMany(c => c.UserRols)
                .HasForeignKey(bc => bc.IdRol);

            modelBuilder.Entity<Produs>()
            .HasOne<Cos>(s => s.Cos)
            .WithMany(g => g.Produse)
            .HasForeignKey(s => s.IdCos);

            modelBuilder.Entity<User>()
            .HasOne<Cos>(s => s.Cos)
            .WithOne(ad => ad.User)
            .HasForeignKey<Cos>(ad => ad.IdUser);
        }

    }
}
