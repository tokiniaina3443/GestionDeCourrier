using GestionDeCourrier.Core.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeCourrier.DAL
{
    public class ApplicationDbContext : IdentityDbContext<Utilisateur>
    {
        DbSet<Utilisateur> Utilisateurs { get; set; }
        DbSet<Role> Roles { get; set; }
        DbSet<Courrier> Courriers { get; set; }
        DbSet<StatusCourrier> StatusCourriers { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<StatusCourrier>()
                .HasOne(p => p.Actionneur)
                .WithMany(b => b.StatusCourriers)
                .HasForeignKey(p => p.ActionneurId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
