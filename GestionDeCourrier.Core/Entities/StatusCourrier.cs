using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionDeCourrier.Core.Constants;

namespace GestionDeCourrier.Core.Entities
{
    public class StatusCourrier : EntityBase
    {
        private string _status;
        [ForeignKey("Courrier")]
        public int CourrierId { get; set; }
        public string ActionneurId { get; set; }
        public string Status
        {
            get { return _status; }
            set
            {
                if(Constant.StatusType.Contains(value))
                    _status = value;
                else
                    throw new ArgumentException($"{value} n'est pas une valeur autorisé");
            }
        }
        public string? Coursier { get; set; }
        public string? Receptionniste { get; set; }
        public DateTime Period { get; set; }

        public virtual Courrier Courrier { get; set; }
        public virtual Utilisateur Actionneur { get; set; }
    }
}
