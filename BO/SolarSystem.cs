using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class SolarSystem : IDbEntity
    {
        public string Name { get; set; }

        public List<Planet> Planets { get; set; }

    }
}
