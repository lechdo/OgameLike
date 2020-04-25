using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO.Validators
{
    class DatetimeNotBeyondNow : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            bool result = true;
            DateTime dateTime;

            if (DateTime.TryParse(value.ToString(), out dateTime))
            {
                if (dateTime > DateTime.Now)
                {
                    result = false;
                }
            }


            return result;
        }
    }
}
