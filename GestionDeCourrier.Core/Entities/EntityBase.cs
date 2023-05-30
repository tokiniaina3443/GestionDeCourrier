using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeCourrier.Core.Entities
{
    [NotMapped]
    public abstract class EntityBase
    {
        [Key]
        public int Id { get; set; }
    }
}
