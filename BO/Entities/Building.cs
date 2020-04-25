using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO.Entities
{
    public abstract class Building : IDbEntity
    {
        [StringLength(20, MinimumLength = 5)]
        public string Name { get; set; }

        [Range(minimum: 0, maximum: int.MaxValue, ErrorMessage = "Level doit ête strictement positif")]
        public int? Level { get; set; }


        public int? CellNb
        {
            get { return Level + 1; }
        }

        public List<Resource> TotalCost
        {
            get { throw new NotImplementedException(); }

        }

        public List<Resource> NextCost
        {
            get { throw new NotImplementedException(); }
        }

        
    }
}
