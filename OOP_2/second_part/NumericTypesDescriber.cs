using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_2.second_part
{
    public static class NumericTypesDescriber
    {
        public static string Describe(object someObject)
        {
            if (someObject is int)
            {
                return "Int of value 5";
            } else if (someObject is double)
            {
                return "Double of value 5.6";
            }
            else if (someObject is decimal)
            {
                return "Decimal of value 5.7";
            }
            else
            {
                return null;
            }
        }
    }
}

