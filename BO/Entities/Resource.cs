using BO.Validators;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BO.Entities
{
    public class Resource : IDbEntity
    {
        [StringLength(20, MinimumLength = 5)]
        public string Name { get; set; }

        [Range(minimum: 0, maximum: int.MaxValue, ErrorMessage = "LastQuantity doit ête positif")]
        public int? LastQuantity { get; set; }

        [DatetimeNotBeyondNow]
        public DateTime LastUpdate { get; set; }

    }
}
