using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main.BattleTypes
{
    public class ZombieFight :FightStrategy
    {
        public override void Fight(MainCharacter Player, Enemy Opponent)
        {
            var s = ((Zombie)Opponent).SelfDmg;
            Opponent.HealthPoints -= (Player.Dmg + ((Zombie)Opponent).SelfDmg);
            Console.WriteLine("Zombie ulega rozkładowi, dodatkowy dmg " + s);
            if (Opponent.HealthPoints > 0)
            {
                if (Opponent.Dmg < Player.Armor)
                {
                    Player.HealthPoints -= 1;
                }
                else
                    Player.HealthPoints -= (Opponent.Dmg - Player.Armor);
            }
        }
    }
}
