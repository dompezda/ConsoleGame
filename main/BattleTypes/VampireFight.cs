using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main.BattleTypes
{
    public class VampireFight :FightStrategy
    {
        public override void Fight(MainCharacter Player, Enemy Opponent)
        {
            Random Attrib = new Random();
            int Los = Attrib.Next(1, 5);
            if (Los == ((Bruxa)Opponent).Dodge)
            {
                Console.WriteLine("Bruxa uniknela ataku");
                Player.HealthPoints -= Opponent.Dmg;
            }
            else
            {
                Opponent.HealthPoints -= Player.Dmg;
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
}
