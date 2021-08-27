using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main.BattleTypes
{
    public class SkeletonFight :FightStrategy
    {
        public override void Fight(MainCharacter Player, Enemy Opponent)
        {
            Random Attrib = new Random();
            int Los = Attrib.Next(1, 5);
            Opponent.HealthPoints -= Player.Dmg;
            if (Opponent.HealthPoints > 0)
            {
                if (Los == 1)
                {
                    if (Opponent.Dmg < Player.Armor)
                    {
                        Player.HealthPoints -= 1;
                    }
                    else
                        Player.HealthPoints -= (Opponent.Dmg - Player.Armor);
                }
            }
            else
            {
                Console.WriteLine("Skeleton chybil");
            }
        }
    }
}
