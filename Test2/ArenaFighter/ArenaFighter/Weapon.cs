using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaFighter
{
    class Weapon : IEquipment
    {
        private String name;
        private int damage;
        private int cost;

        public Weapon(String name, int damage, int cost)
        {
            this.name = name;
            this.damage = damage;
            this.cost = cost;
        }

        public String Name
        { 
            get => name; 
            set => name = value;
        }
        public int Damage
        {
            get => damage;
            set => damage = value;
        }

        public int Cost
        {
            get => cost;
            set => cost = value;
        }
    }
}
