using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRollGame.Game
{
    public class Dice
    {
        private readonly Random _random;
        private const int _sidesCount = 6;

        public Dice(Random random)
        {
            _random = random;
        }

        public int Roll()
        {
            return _random.Next(1, _sidesCount + 1);
        }

        public void Describe() => Console.WriteLine("This is a dice with 6 sides");
    }
}
