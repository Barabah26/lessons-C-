using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.second_part
{
    public class Ingredient
    {
        public int PublicField;

        public string PublicMethod() =>
            "This is a PUBLIC in the Ingredient class.";
        private string _publicMethod() =>
            "This is a PRIVATE in the Ingredient class.";
        protected string publicMethod() =>
            "This is a PROTECTED in the Ingredient class.";
    }
}
