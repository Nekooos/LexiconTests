using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaFighter
{
    class Shop
    {
        List<IEquipment> equipmentList;

        public Shop()
        {
            equipmentList = addEquipmentToShop();
        }

        private List<IEquipment> addEquipmentToShop()
        {
            Weapon axe = new Weapon("Axe", 3, 10);
            Weapon broadSword = new Weapon("Sword of a 1000 Truths", 4, 20);
            Armor chainMail = new Armor("Chain Mail", 3, 10);
            Armor plate = new Armor("Plate", 4, 20);

            List<IEquipment> equipmentList = new List<IEquipment>()
            {
                axe,
                chainMail,
                broadSword,
                plate
            };
            return equipmentList;
        }

        public List<IEquipment> EquipmentList
        {
            get => equipmentList;
        }
    }
}
