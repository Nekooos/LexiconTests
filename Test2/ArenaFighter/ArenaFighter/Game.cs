using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaFighter
{
    class Game
    {
        private Dice dice;
        private List<BattleLog> battleLogs;
        private Character player;
        private Boolean isDead;
        private Boolean isRetired;
        private Shop shop;
        private int battlesWon;

        public Game()
        {
            dice = new Dice();
            battleLogs = new List<BattleLog>();
            shop = new Shop();
        }
        public void Start()
        {
            List<List<String>> battleLogs = new List<List<String>>();
            player = createPlayer();

            while (!isDead && !isRetired)
            {
                int choice = showMenu();
                executeChoice(choice);
                isDead = isPlayerDead();
                
                if(isDead)
                {
                    break;
                }
                
                if(!isDead)
                {
                    battlesWon++;
                }
            }
        }

        private Character createPlayer()
        {
            Console.WriteLine("Enter a name for your character: ");
            String name = Console.ReadLine();
            int strength = dice.RollDice(1, 6);
            int health = dice.RollDice(12, 22);
            Character player = new Character(name, health, strength, 0);
            player.Weapon = new Weapon("Sword", 2, 0);
            player.Armor = new Armor("Leather", 2, 0);
            return player;
        }

        private int showMenu()
        {
            Console.WriteLine("1. Battle \n" +
                              "2. Shop \n" +
                              "3. Retire \n");
            Console.WriteLine("Enter a number: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        private int showShopMenu()
        {
            Console.WriteLine($"\nYou have {player.Gold} Gold to shop for. Battle to get more! \n");
            for(int i = 0; i < shop.EquipmentList.Count; i++) 
            {
                Console.WriteLine($"{i+1} {shop.EquipmentList.ElementAt(i).Name}: {shop.EquipmentList.ElementAt(i).Cost} gold \n");
            }
            Console.WriteLine($"{shop.EquipmentList.Count+1} Exit shop \n");
            Console.WriteLine("Enter a number: ");
            return Convert.ToInt32(Console.ReadLine())-1;
        }

        private void executeChoice(int choice)
        {
            switch (choice)
            {
                case 1:
                    Battle battle = new Battle();
                    BattleLog battleLog = battle.StartBattle(player);
                    battleLogs.Add(battleLog);
                    break;
                case 2:
                    int shopChoice = showShopMenu();
                    if(shopChoice < shop.EquipmentList.Count)
                    {
                        shopSelectedItem(shopChoice);
                    }
                    break;
                case 3:
                    isRetired = true;
                    showBattleLogs();
                    break;
            }          
        }

        private Boolean isPlayerDead()
        {
            if(player.Health <= 0)
            {
                Console.WriteLine($"\nGame Over. You won {battlesWon}!");
                showBattleLogs();
                return true;
            }
            return false;
        }

        private void showBattleLogs()
        {
            Console.WriteLine("Enter 1 if you want to replay all the Battles");
            int choice = Convert.ToInt32(Console.ReadLine());
            if(choice == 1)
            {
                replayBattleLogs();
            }
        }

        private void replayBattleLogs()
        {
            foreach(BattleLog battleLog in battleLogs)
            {
                Console.WriteLine($"{battleLog.Character} \n" +
                                  "VS" +
                                  $"{battleLog.Enemy} \n");
                foreach(String action in battleLog.Actions)
                {
                    Console.WriteLine(action);
                }
            }
        }

        private void shopSelectedItem(int shopChoice)
        {
            if (shopChoice < shop.EquipmentList.Count())
            {
                if (player.Gold >= shop.EquipmentList.ElementAt(shopChoice).Cost)
                {
                    if (shop.EquipmentList.ElementAt(shopChoice) is Weapon)
                    {
                        player.Weapon = (Weapon)shop.EquipmentList.ElementAt(shopChoice);
                        player.Gold = player.Gold - shop.EquipmentList.ElementAt(shopChoice).Cost;
                        Console.WriteLine($"\nYou bought {shop.EquipmentList.ElementAt(shopChoice).Name}\n");
                    }
                    else
                    {
                        player.Armor = (Armor)shop.EquipmentList.ElementAt(shopChoice);
                        player.Gold = player.Gold - shop.EquipmentList.ElementAt(shopChoice).Cost;
                        Console.WriteLine($"\nYou bought {shop.EquipmentList.ElementAt(shopChoice).Name}\n");
                    }
                }
                else
                {
                    Console.WriteLine("Not enough gold\n");
                }
            }
        }
    }
}
