using BO.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO.Entities
{
    public enum ResourceNames
    {
        [CustomName(Name = "énergie")]
        Energy,
        [CustomName(Name = "acier")]
        Steel,
        [CustomName(Name = "uranium")]
        Uranium,
        [CustomName(Name = "oxygène")]
        Oxygen
    }
}
