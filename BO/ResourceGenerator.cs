using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public abstract class ResourceGenerator : Building
    {
        public List<Resource> ResourceBySecond()
        {
            throw new NotImplementedException();
        }
    }
}
