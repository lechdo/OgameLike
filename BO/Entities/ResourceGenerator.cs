﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO.Entities
{
    public abstract class ResourceGenerator : Building
    {
        public List<Resource> ResourceBySecond
        {
            get { throw new NotImplementedException(); }
        }
    }
}