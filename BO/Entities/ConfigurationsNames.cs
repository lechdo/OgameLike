using BO.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BO.Entities
{
    // enumération des configuration pour pouvoir les serialiser dans la classe "configuration"
    // reprend la liste des différentes classes configuration qui ne sont pas directement persistées.
    // exploitation de l'annotation CustomNameAttribute créée pour les resources.
    public enum ConfigurationsNames
    {
        [CustomNameAttribute(Name = "PlanetConfiguration")]
        PlanetConfiguration,

        [CustomNameAttribute(Name = "GameConfiguration")]
        GameConfiguration,

    }
}
