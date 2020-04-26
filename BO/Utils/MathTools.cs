using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO.Utils
{
    public class MathTools
    {
        public static  int? RecurrentAddition(Func<int?, int?> function, int? range)
        {
            int? result = null;

            for (int i = 0; i < range + 1; i++)
            {
                result += function.Invoke(i);
            }
            return result;
        }

    }
}
