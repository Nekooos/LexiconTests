using System;
using System.Collections.Generic;

namespace ArenaFighter
{
    class BattleLog
    {
        private String character;
        private String enemy;
        List<String> actions;

        public BattleLog(String character, String enemy)
        {
            this.character = character;
            this.enemy = enemy;
            actions = new List<String>();
        }

        public void addRound(String action)
        {
            actions.Add(action);
        }

        public String Character
        {
            get => character;
        }

        public String Enemy
        {
            get => enemy;
        }

        public List<String> Actions
        {
            get => actions;
        }

    }
}
