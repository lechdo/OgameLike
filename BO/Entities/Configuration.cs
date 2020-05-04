using BO.Entities.Configurations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO.Entities
{
    public class Configuration
    {
        // éléments nécéssaires :
        // config de systeme solaire : nb systemes + nb planetes.
        // config planetes : liste type de resources et liste types de buildings.

        // les 2 configs peuvent entrer dans une seule table, à condition que leur valeur ne soit pas construites sous forme objet
        // car 1 classe == une table au minimum.

        // chaque config est unique (écrasée si changée), donc on peut nommer une config par le nom de sa classe. le métier fera le reste.
        // son contenu doit alors être sérialisé dans un string. On obtient une table avec une clé et une valeur de contenu.

        // reste à gérer la génération de ce contenu. les instances doivent être stockées dans la db et sous format json.

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string Key { get; set; }

        public string Content { get; set; }

    }
}
