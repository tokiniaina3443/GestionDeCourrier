using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeCourrier.Core.Entities
{
    public class Utilisateur : IdentityUser
    {
        public string Nom { get; set; }
        public virtual ICollection<Courrier> Courriers { get; set; }
        public virtual ICollection<StatusCourrier> StatusCourriers { get; set; }
    }
}
