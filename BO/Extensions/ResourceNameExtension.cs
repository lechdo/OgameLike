using BO.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BO.Extensions
{
    public static class ResourceNameExtension
    {
        // paramètre value est l'énumération visée.
        public static string  GetName(this Enum value)
        {
            CustomNameAttribute[] attributes = (CustomNameAttribute[])value
                // récupération du type pour exploiter son contenu : type CustomNameAttribute
                .GetType()
                // récupération du champs "value" dans le CustomNameAttribute grâce au tostring de value : Champs CustomNAmeAttribute.Value
                .GetField(value.ToString())
                // récupération de la liste des attributs customs de ce champs, il n'y en a qu'un name.
                .GetCustomAttributes(typeof(CustomNameAttribute), false);

            // renvoie le Name du  1er et seul champ : Value
            return attributes[0].Name;
        }

    }
}
