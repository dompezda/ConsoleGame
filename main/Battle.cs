using main.BattleTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main
{
    class Battle
    {
        MainCharacter Player;

        public Battle(MainCharacter Char)
        {
            Player = Char;

        }
        Random Attrib = new Random();
        public void Fight(MainCharacter Postac, Enemy Opponent)
        {


            while (Postac.HealthPoints > 0 && Opponent.HealthPoints > 0)
            {
                Postac.GetState();
                Console.WriteLine();
                Console.WriteLine("Trwa bitwa, co chesz zrobic(hit, run)");
                string decision = Console.ReadLine();
                int Los = Attrib.Next(1, 5);
                if (decision == "hit")
                {


                    if (Opponent.Opis == "Zombie")
                    {
                        FightType fightType = new FightType();
                        fightType.SetFightStrategy(new ZombieFight());
                        fightType.Fight(Player, Opponent);
                        //var s= ((Zombie)Opponent).SelfDmg;
                        //Opponent.HealthPoints -= (Player.Dmg + ((Zombie)Opponent).SelfDmg);
                        //Console.WriteLine("Zombie ulega rozkładowi, dodatkowy dmg "+s);
                        //if (Opponent.HealthPoints > 0)
                        //{
                        //    if (Opponent.Dmg < Player.Armor)
                        //    {
                        //        Player.HealthPoints -= 1;
                        //    }
                        //    else
                        //        Postac.HealthPoints -= (Opponent.Dmg - Player.Armor);

                        //}
                    }
                    if (Opponent.Opis == "Vampire")
                    {
                        FightType fightType = new FightType();
                        fightType.SetFightStrategy(new VampireFight());
                        fightType.Fight(Player, Opponent);
                        //if (Los == ((Bruxa)Opponent).Dodge)
                        //{
                        //    Console.WriteLine("Bruxa uniknela ataku");
                        //    Postac.HealthPoints -= Opponent.Dmg;
                        //}
                        //else
                        //{
                        //    Opponent.HealthPoints -= Player.Dmg;
                        //    if (Opponent.HealthPoints > 0)
                        //    {
                        //        if (Opponent.Dmg < Player.Armor)
                        //        {
                        //            Player.HealthPoints -= 1;
                        //        }
                        //        else
                        //            Postac.HealthPoints -= (Opponent.Dmg - Player.Armor);

                        //    }
                        //}
                    }
                    if (Opponent.Opis == "Ghoul")
                    {
                        FightType fightType = new FightType();
                        fightType.SetFightStrategy(new GhoulFight());
                        fightType.Fight(Player, Opponent);

                        //var l = ((Ghoul)Opponent).Lifesteal;
                        //Opponent.HealthPoints -= Player.Dmg;
                        //if (Opponent.HealthPoints > 0)
                        //{
                        //    if (Opponent.Dmg < Player.Armor)
                        //    {
                        //        Player.HealthPoints -= 1;
                        //    }
                        //    else
                        //        Postac.HealthPoints -= (Opponent.Dmg - Player.Armor);
                        //    Opponent.HealthPoints += ((Ghoul)Opponent).Lifesteal;

                        //    Console.WriteLine("Ghould uleczyl sie za "+l);

                        //}

                    }
                    if (Opponent.Opis == "Skeleton")
                    {
                        FightType fightType = new FightType();
                        fightType.SetFightStrategy(new SkeletonFight());
                        fightType.Fight(Player, Opponent);
                        //Opponent.HealthPoints -= Player.Dmg;
                        //if (Opponent.HealthPoints > 0)
                        //{
                        //    if (Los == 1)
                        //    {
                        //        if (Opponent.Dmg < Player.Armor)
                        //        {
                        //            Player.HealthPoints -= 1;
                        //        }
                        //        else
                        //            Postac.HealthPoints -= (Opponent.Dmg - Player.Armor);
                        //    }
                        //}
                        //else
                        //{
                        //    Console.WriteLine("Skeleton chybil");

                        //}


                    }
                }


                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Twoje hp: " + Postac.HealthPoints);
                Console.WriteLine("hp Wroga: " + Opponent.HealthPoints);
                if (decision == "run")
                {
                    Postac.DamageTaken(Opponent.Dmg * 3, "Przeciwnik");


                    break;

                }

                else
                {
                    Console.WriteLine();
                    Console.WriteLine("wpisz hit lub run");
                }



                if (Opponent.HealthPoints <= 0)
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Player.Score += Opponent.Score;
                }
                if (Postac.HealthPoints <= 0)
                {
                    Console.Clear();
                    Console.WriteLine("Gratuluje skonczyles gre");
                    Console.WriteLine("Twoj wynik to: " + Player.Score);
                    Console.Beep();
                    Environment.Exit(1);
                }



            }
        }
    }
}


 