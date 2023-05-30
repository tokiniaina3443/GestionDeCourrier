using GestionDeCourrier.Core.Entities;
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
    public class ApplicationDbContext : DbContext
    {
        DbSet<Utilisateur> Utilisateurs { get; set; }
        DbSet<Courrier> Courriers { get; set; }
        DbSet<StatusCourrier> StatusCourriers { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {
        }
    }
}
