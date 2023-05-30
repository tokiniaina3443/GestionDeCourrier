using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeCourrier.Core.Constants
{
    public static class Constant
    {
        public static List<string> Flag 
        {
            get
            {
                return new List<string>
                {
                    "normal", "important", "urgent"
                };
            } 
        }

        public static List<string> ExpediteurType
        {
            get
            {
                return new List<string>
                {
                    "interne", "externe"
                };
            }
        }

        public static List<string> StatusType
        {
            get
            {
                return new List<string>
                {
                    "reçu", "en livraison", "transféré", "livré"
                };
            }
        }
    }
}
