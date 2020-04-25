using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO.Entities
{
    public class SolarSystem : IDbEntity
    {
        [StringLength(20, MinimumLength = 5)]
        public string Name { get; set; }

        public List<Planet> Planets { get; set; }

    }
}
