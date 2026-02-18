using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.second_part
{
    public class Cheddar : Ingredient
    {
        public string Name => "Cheddar cheese";
        public int AgedForMonths { get; }

        public void UseMethodsFromBaseClass()
        {
            Console.WriteLine(PublicMethod());  
        }
    }
}
