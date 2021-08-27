using main.BattleTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main
{
    public class FightType
    {
        private FightStrategy fightStrategy;
        public void SetFightStrategy(FightStrategy fightStrategy)
        {
            this.fightStrategy = fightStrategy;
        }

        public void Fight(MainCharacter Player, Enemy Opponent)
        {
            fightStrategy.Fight(Player,Opponent);
        }
    }
}
