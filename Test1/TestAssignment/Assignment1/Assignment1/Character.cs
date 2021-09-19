using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Character
    {
        private string name;
        private int strength;
        private int health;
        private int luck;

        public Character(string inputName)
        {
            name = inputName;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Strength
        {
            get { return strength; }
            set { strength = value; }
        }

        public int Health
        {
            get { return health; }
            set { health = value; }
        }

        public int Luck
        {
            get { return luck; }
            set { luck = value; }
        }
    }
}
