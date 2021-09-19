using System;
using System.Collections.Generic;

namespace ArenaFighter
{
    class Character
    {
        private String name;
        private int health;
        private int strength;
        private Weapon weapon;
        private Armor armor;
        private int gold;
        private Dice dice;

        public Character(String name, int health, int strength, int gold)
        {
            this.name = name;
            this.health = health;
            this.strength = strength;
            this.gold = gold;
            dice = new Dice();
        }

        public int Health
        {
            get => health;
            set => health = value;
        }

        public int Strength
        {
            get => strength;
            set => strength = value;
        }

        public String Name
        {
            get => name;
            set => name = value;
        }

        public int Gold
        {
            get => gold;
            set => gold = value;
        }

        public Weapon Weapon
        {
            get => weapon;
            set => weapon = value;
        }

        public Armor Armor
        {
            get => armor;
            set => armor = value;
        }

        public int attack(int weaponDamage)
        {
            return dice.RollDice(1, 6) + weaponDamage;
        }

        public int rollForInitiative(int weather)
        {
            return dice.RollDice(1, 6) - weather;
        }

        public override string ToString()
        {
            return $"name: {name} \n" +
                   $"Strength: {strength} \n" +
                   $"Health: {health} \n" +
                   $"Weapon: {weapon.Name} \n" +
                   $"Armor: {armor.Name} \n" +
                   $"Gold: {gold} \n";
        }
    }
}
