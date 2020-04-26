using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO.Validators
{
    public class CustomNameAttribute : Attribute
    {
        public string Name { get; set; }
    }
}
