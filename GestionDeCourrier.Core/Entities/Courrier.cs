using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionDeCourrier.Core.Constants;

namespace GestionDeCourrier.Core.Entities
{
    public class Courrier : EntityBase
    {
        [NotMapped]
        private string _flag;
        [NotMapped]
        private string _expediteurType;

        [ForeignKey("Utilisateur")]
        public int CreateurId { get; set; }

        public string? Reference { get; set; }
        public string? Commentaire { get; set; }
        public string? Objet { get; set; }
        public string Destinataire { get; set; }
        public string Expediteur { get; set; }
        public string ExpediteurType 
        {
            get { return _expediteurType;}
            set
            {
                if(Constant.ExpediteurType.Contains(value))
                    _expediteurType = value;
                else
                    throw new ArgumentException($"{value} n'est pas une valeur autorisé");
            }
        }
        public string Flag
        {
            get { return _flag;}
            set
            {
                if (Constant.Flag.Contains(value))
                    _flag = value;
                else
                    throw new ArgumentException($"{value} n'est pas une valeur autorisé");
            }
        }

        public virtual Utilisateur Createur { get; set; }
        public virtual ICollection<StatusCourrier> StatusCourriers { get; set; }

    }
}
