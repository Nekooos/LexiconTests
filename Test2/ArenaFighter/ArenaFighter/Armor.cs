using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaFighter
{
    class Armor : IEquipment
    {
        private String name;
        private int protection;
        private int cost;

        public Armor(String name, int protection, int cost)
        {
            this.name = name;
            this.protection = protection;
            this.cost = cost;
        }

        public String Name
        {
            get => name;
            set => name = value;
        }

        public int Protection
        {
            get => protection;
            set => protection = value;
        }

        public int Cost
        {
            get => cost;
            set => cost = value;
        }
    }
}
