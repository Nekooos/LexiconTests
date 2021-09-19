using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaFighter
{
    class Battle
    {
        private Boolean isBattleOngoing;
        private Dice dice;

        public Battle()
        {
            dice = new Dice();
            isBattleOngoing = true;
        }

        public BattleLog StartBattle(Character player)
        {
            Character enemy = CreateEnemy();
            BattleLog battleLog = new BattleLog(player.ToString(), enemy.ToString());
            Console.WriteLine($"{player.ToString()}\nVS\n\n {enemy.ToString()}");

            while (isBattleOngoing)
            {
                Round round = new Round(player, enemy);
                String roundLog = (round.startRound());
                Console.WriteLine(roundLog);
                battleLog.addRound(roundLog);

                if (player.Health <= 0)
                {
                    isBattleOngoing = false;
                    Console.WriteLine($"{player.Name} Died\n");
                    battleLog.addRound($"{player.Name} Died\n");
                } 
                else if(enemy.Health <= 0)
                {
                    isBattleOngoing = false;
                    Console.WriteLine($"{enemy.Name} Died\n");
                    battleLog.addRound($"{enemy.Name} Died\n");
                    player.Gold = player.Gold + enemy.Gold;
                }
                
            }

            return battleLog;
        }

        private Character CreateEnemy()
        {
            int strength = dice.RollDice(1, 4);
            int health = dice.RollDice(6, 12);
            int gold = dice.RollDice(5, 10);
            Character enemy = new Character("enemy", health, strength, gold);
            enemy.Weapon = new Weapon("Hands", 0, 0);
            enemy.Armor = new Armor("Cloth", 0, 0);
            return enemy;
        }
    }
}
