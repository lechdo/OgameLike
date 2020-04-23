using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Planet : IDbEntity
    {
        public string Name { get; set; }

        public int? CaseNb { get; set; }

        public List<Resource> Resources {get; set;}

        public List<Building> Buildings { get; set; }

    }
}
