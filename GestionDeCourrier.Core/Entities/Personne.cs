using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeCourrier.Core.Entities
{
    public class Personne : EntityBase
    {
        public string Nom { get; set; }
    }
}
