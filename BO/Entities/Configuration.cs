using BO.Entities.Configurations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO.Entities
{
    public class Configuration
    {
        // éléments nécéssaires :

        // config de systeme solaire : nb systemes + nb planetes.
        public GameConfiguration GameConfiguration { get; set; }

        // config planetes : liste type de resources et liste types de buildings.
        public PlanetConfiguration PlanetConfiguration { get; set; }
    }
}
