using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeCourrier.Core.Entities
{
    public class Utilisateur : Personne
    {
        public string Identifiant { get; set; }
        public string MotDePasse { get; set; }
    }
}
