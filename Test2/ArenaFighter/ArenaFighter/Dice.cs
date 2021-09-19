using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaFighter
{
    class Dice
    {
        private Random random;
        public Dice()
        {
            random = new Random();
        }

        public int RollDice(int min, int max)
        {
            return random.Next(min, max);
        }

        public int RollDice(int min, int max, Character character)
        {
            int ranomizedvalue = random.Next(min, max);
            Console.WriteLine($"{character.Name} rolls {ranomizedvalue}");
            return ranomizedvalue;
        }
    }
}
