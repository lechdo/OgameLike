using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public abstract class Building : IDbEntity
    {
        public string Name { get; set; }

        public int? Level { get; set; }

        public int? CellNb()
        {
            throw new NotImplementedException();
        }

        public List<Resource> TotalCost()
        {
            throw new NotImplementedException();
        }

        public List<Resource> NextCost()
        {
            throw new NotImplementedException();
        }

    }
}
