using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Dog
    {
        public string Name;
        public string Breed;
        public int Weight;

        public Dog(string name, string breed, int weight)
        {
            Name = name;
            Breed = breed;
            Weight = weight;
        }

        public Dog(string name, int weight)
        {
            Name = name;
            Weight = weight;
            Breed = "mixed-breed";
        }

        public string Describe()
        {
            string sizeDescription;

            if (Weight < 5)
                sizeDescription = "tiny";
            else if (Weight >= 5 && Weight < 30)
                sizeDescription = "medium";
            else
                sizeDescription = "large";

            return $"This dog is named {Name}, it's a {Breed}, and it weighs {Weight} kilograms, so it's a {sizeDescription} dog.";
        }
    }
}
