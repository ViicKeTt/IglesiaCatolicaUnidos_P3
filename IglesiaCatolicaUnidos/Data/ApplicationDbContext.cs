using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;

namespace IglesiaCatolicaUnidos.Data
{
    public class ApplicationDbContext : IdentityDbContext<MyUsuario>
    {
        public DbSet<MyUsuario> USUARIOS { get; set; }
        public DbSet<Integrante> INTEGRANTES { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<MyUsuario>(entityTypeBuilder => {
                entityTypeBuilder.ToTable("Users");
                entityTypeBuilder.Property(u => u.MyUsuarioID).HasMaxLength(100).IsRequired();
                entityTypeBuilder.Property(u => u.NombreUsuario).HasMaxLength(50);
            });
        }
    }
    public class MyUsuario : IdentityUser
    {
        public Guid MyUsuarioID { get; set; }
        public string NombreUsuario { get; set; }
    }
}
