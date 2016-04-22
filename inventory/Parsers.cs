using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventory
{
    public static class Parsers
    {
        public static decimal ParseDecimal(string str)
        {
            decimal returnMe = 0;

            if (decimal.TryParse(str, out returnMe))
            {
                return returnMe;
            }

            return 0;
        }
    }
}
