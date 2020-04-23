using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Resource : IDbEntity
    {
        public string Name { get; set; }

        public int? LastQuantity { get; set; }

        public DateTime LastUpdate { get; set; }

    }
}
