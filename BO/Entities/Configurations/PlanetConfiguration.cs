using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO.Entities.Configurations
{
    public class PlanetConfiguration
    {

        // utilise la clé de l'enumération des resources
        public List<int> ResourceKinds { get; set; } = new List<int>();


        // TODO : idem, enumération des buildings à réaliser
        public List<int> PlanetBuildingKinds { get; set; } = new List<int>();

    }
}
