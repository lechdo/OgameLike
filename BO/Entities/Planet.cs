using BO.Validators;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO.Entities
{
    public class Planet : IDbEntity
    {
        [StringLength(20, MinimumLength = 5)]
        public string Name { get; set; }

        [Range(minimum: 0, maximum: int.MaxValue, ErrorMessage = "CaseNb doit ête positif")]
        public int? CaseNb { get; set; }

        [ResourcesListValidator]
        public List<Resource> Resources {get; set;}

        [NotMapped]
        public List<Building> Buildings { get; set; }

        public Planet()
        {
            this.Resources = new List<Resource>();
            this.Buildings = new List<Building>();
        }
    }
}
