using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main.BattleTypes
{
    public class GhoulFight :FightStrategy
    {
        public override void Fight(MainCharacter Player, Enemy Opponent)
        {
            var l = ((Ghoul)Opponent).Lifesteal;
            Opponent.HealthPoints -= Player.Dmg;
            if (Opponent.HealthPoints > 0)
            {
                if (Opponent.Dmg < Player.Armor)
                {
                    Player.HealthPoints -= 1;
                }
                else
                    Player.HealthPoints -= (Opponent.Dmg - Player.Armor);
                Opponent.HealthPoints += ((Ghoul)Opponent).Lifesteal;

                Console.WriteLine("Ghould uleczyl sie za " + l);

            }
        }
    }
}
