using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.second_part
{
    public class Pizza
    {
        private List<Ingredient> _ingredients = new List<Ingredient>();

        public void AddIngredient(Ingredient ingredient) =>
            _ingredients.Add(ingredient);

        public string Describe() =>
            $"This is a pizza with {string.Join(", ", _ingredients)}";

    }
}
