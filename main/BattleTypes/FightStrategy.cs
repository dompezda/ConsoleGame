using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main.BattleTypes
{
    public abstract class FightStrategy
    {
        public abstract void Fight(MainCharacter Player, Enemy Opponent);
    }
}
