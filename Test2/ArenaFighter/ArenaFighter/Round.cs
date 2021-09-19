using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaFighter
{
    class Round
    {
        private Character player;
        private Character enemy;

        public Round(Character player, Character enemy)
        {
            this.player = player;
            this.enemy = enemy;
        }

        public String startRound()
        {
            int playerDamage = player.attack(player.Weapon.Damage) - enemy.Armor.Protection;
            int enemyDamage = enemy.attack(player.Weapon.Damage) - player.Armor.Protection;
            enemy.Health = enemy.Health - playerDamage;
            player.Health = player.Health - enemyDamage;
            return logRound(playerDamage, enemyDamage);
        }

        private String logRound(int playerDamage, int enemyDamage)
        {
            return $"{player.Name} deals {playerDamage} damage to {enemy.Name} \n" +
            $"{enemy.Name} deals {enemyDamage} damage to {player.Name}\n";
        }
    }
}
