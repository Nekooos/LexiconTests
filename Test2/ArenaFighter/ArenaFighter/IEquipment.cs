using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaFighter
{
    interface IEquipment
    {
        public string Name { get; set; }

        public int Cost { get; set; }
    }
}
