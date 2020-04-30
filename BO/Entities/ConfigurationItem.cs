using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO.Entities
{
    class ConfigurationItem
    {
        // clé de l'élément de l'enumération
        public int? Key { get; set; }

        // appelation de l'élément de l'enumération
        public string Name { get; set; }

        // valeur de l'attribut "Name" de l'élément de l'énumération
        public string Text { get; set; }

    }
}
