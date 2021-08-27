using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main
{
    class Event
    {

        MainCharacter Player;
        public Event(MainCharacter Char)
        {
            Player=Char;
        }

        
        public void EventRandom()
        {

            Zombie Zombie1 = (Zombie)MobFactory.MobCreator("zombie");
            
            Ghoul Ghoul1 = (Ghoul)MobFactory.MobCreator("ghoul");

            Bruxa Vampire1 = (Bruxa)MobFactory.MobCreator("bruxa");

            Skeleton Skeleton1 = (Skeleton)MobFactory.MobCreator("skeleton");

            Armors SteelArmor = new Armors();
            SteelArmor.BonusArmor = 2;
            SteelArmor.Name = "Pancerz Stalowy +2";
            SteelArmor.UniqueID = 1;
            Armors WoodenArmor = new Armors();
            WoodenArmor.BonusArmor = 1;
            WoodenArmor.Name = "Pancerz drewniany +1";
            WoodenArmor.UniqueID = 1;

            Armors SteelHelmet = new Armors();
            SteelHelmet.BonusArmor = 2;
            SteelHelmet.Name = "Helm Stalowy +2";
            SteelHelmet.UniqueID = 2;
            Armors WoodenHelmet = new Armors();
            WoodenHelmet.BonusArmor = 1;
            WoodenHelmet.Name = "Helm drewniany +1";
            WoodenHelmet.UniqueID = 2;

            Armors SteelPants = new Armors();
            SteelPants.BonusArmor = 2;
            SteelPants.Name = "Spodnie Stalowe +2";
            SteelPants.UniqueID = 3;
            Armors WoodenPants = new Armors();
            WoodenPants.BonusArmor = 1;
            WoodenPants.Name = "Spodnie drewniane +1";
            WoodenPants.UniqueID = 3;

            Potion HPpotion = new Potion();
            HPpotion.Power = 20;
            HPpotion.Name = "Mikstura zycia";
            HPpotion.UniqueID = 5;

            Weapons Dagger = new Weapons();
            Dagger.Name = "Sztylet niegodziwosci +1";
            Dagger.UniqueID = 4;
            Dagger.BonusDmg = 1;

            Weapons Sword = new Weapons();
            Sword.Name = "Miecz ze stali +2";
            Sword.UniqueID = 4;
            Sword.BonusDmg = 2;

            



            Random rnd = new Random();
            int EventNumber = rnd.Next(1, 8);
            Console.WriteLine("Numer eventu: {0}", EventNumber);
            Random rnd2 = new Random();
            
            Battle Battle = new Battle(Player);
           
            


            if (EventNumber == 1)
            {

                Zombie Opponent = Zombie1;
                int Escape = rnd2.Next(1, 100);
                Console.WriteLine("Zaatakowalo Cie Zombie");
                Console.WriteLine("Czy chcesz uciekac czy walczyc(1=walka,2=ucieczka)");
                string decision = Console.ReadLine();
                
                if (decision == "1")
                {
                    Battle.Fight(Player,Opponent);
                }
                if (decision == "2")
                {
                    if (Escape % 2 == 1)
                    {
                        Player.DamageTaken(Zombie1.Dmg, "Zombie Trafia ");
                        
                    }
                    if (Escape % 2 == 0)
                    {
                        Console.WriteLine("nie udalo sie uciec, czeka Cie walka");
                        Battle.Fight(Player,Opponent);
                    }
                }
                else
                {

                    Battle.Fight(Player, Opponent);
                }
            }
            if (EventNumber == 2)
            {
                int Escape = rnd2.Next(1, 100);
                Console.WriteLine("znalazles studnie zdrowia, czy chcesz sie z niej napic? (1-Tak,2-Nie)");
                string decision = Console.ReadLine();
                if (decision == "1")
                {
                    Random HealRNG = new Random();
                    int HealAmount = HealRNG.Next(5, 25);
                    Player.Heal(HealAmount);
                    if(Player.HealthPoints>Player.MaxHealth)
                    {
                        Player.HealthPoints = Player.MaxHealth;
                    }

                }
                else
                {
                   
                }
            }
            if(EventNumber==3)
            {
                Console.WriteLine("nic nie znalazles");
            }
            if(EventNumber==4)
            {
                int Escape = rnd2.Next(1, 100);
                var Opponent = Vampire1;


                Console.WriteLine("Zaatakowala Cie Bruxa");
                Console.WriteLine("Czy chcesz uciekac czy walczyc(1=walka,2=ucieczka)");
                string decision = Console.ReadLine();

                if (decision == "1")
                {
                    Battle.Fight(Player, Opponent);
                }
                if (decision == "2")
                {
                    if (Escape %2==0)
                    {
                        Player.DamageTaken(Vampire1.Dmg, "Bruxa Trafia ");
                        
                    }
                    if (Escape % 2 == 1)
                    {
                        Console.WriteLine("nie udalo sie uciec, czeka Cie walka");
                        Battle.Fight(Player, Opponent);
                    }
                }
                else
                {

                    Battle.Fight(Player, Opponent);
                }

            }
            if(EventNumber==5)
            {

                int Escape = rnd2.Next(1, 100);
                var Opponent = Ghoul1;


                Console.WriteLine("Zaatakowal Cie Ghoul");
                Console.WriteLine("Czy chcesz uciekac czy walczyc(1=walka,2=ucieczka)");
                string decision = Console.ReadLine();

                if (decision == "1")
                {
                    Battle.Fight(Player, Opponent);
                }
                if (decision == "2")
                {
                    if (Escape % 2 == 1)
                    {

                        Player.DamageTaken(Ghoul1.Dmg, "Ghoul trafia ");

                    }
                    if (Escape % 2 == 0)
                    {
                        Console.WriteLine("nie udalo sie uciec, czeka Cie walka");
                        Battle.Fight(Player, Opponent);
                    }
                }
                else
                {

                    Battle.Fight(Player, Opponent);
                }

            }
            if (EventNumber == 6)
            {
                int Escape = rnd2.Next(1, 2);

                var Opponent = Skeleton1;


                Console.WriteLine("Zaatakowal Cie Skeleton");
                Console.WriteLine("Czy chcesz uciekac czy walczyc(1=walka,2=ucieczka)");
                string decision = Console.ReadLine();

                if (decision == "1")
                {
                    Battle.Fight(Player, Opponent);
                }
                if (decision == "2")
                {
                    if (Escape % 2 == 0)
                    {
                        Player.DamageTaken(Skeleton1.Dmg, "Skeleton trafia ");
                    }
                    if (Escape % 2 == 1)
                    {
                        Console.WriteLine("nie udalo sie uciec, czeka Cie walka");
                        Battle.Fight(Player, Opponent);
                    }
                }
                else
                {

                    Battle.Fight(Player, Opponent);
                }
            }
            if (EventNumber == 7)
            {
                Console.WriteLine("Znalazles skrzynie");
                Console.WriteLine("Czy chcesz ja otworzyc? (1=tak,2=nie)");
                bool warunek = false;
                do
                {
                    string decision = Console.ReadLine();

                    if (decision == "1")
                    {
                        List<Item> Armory = new List<Item>
                    {
                        WoodenArmor,WoodenHelmet,WoodenPants,HPpotion

                    };
                        Random RndItem = new Random();
                        int a = Armory.Count();
                        int Value = RndItem.Next(1, a);
                        Item Drop = Armory[Value];
                        Console.WriteLine("Znalazles item: " + Armory[Value].Name);
                        Console.WriteLine("Czy chcesz Go zalozyc? (1=Tak, 2=Nie)");
                        decision = Console.ReadLine();
                        if (decision == "1")
                        {
                            Player.InventoryChecker(Drop);
                        };
                        warunek = true;
                    }
                    else if (decision == "2")
                    {
                        warunek = true;
                    }
                } while (warunek == false);
                

            }
            if (EventNumber == 8)
            {
                Console.WriteLine("Znalazles skrzynie");
                Console.WriteLine("Czy chcesz ja otworzyc? (1=tak,2=nie)");
                bool warunek = false;
                do
                {
                    string decision = Console.ReadLine();

                    if (decision == "1")
                    {
                        List<Item> Armory = new List<Item>
                    {
                        SteelArmor,SteelHelmet,SteelPants,HPpotion

                    };
                        Random RndItem = new Random();
                        int a = Armory.Count();
                        int Value = RndItem.Next(1, a);
                        Item Drop = Armory[Value];
                        Console.WriteLine("Znalazles item: " + Armory[Value].Name);
                        Console.WriteLine("Czy chcesz Go zalozyc? (1=Tak, 2=Nie)");
                        decision = Console.ReadLine();
                        if (decision == "1")
                        {
                            Player.InventoryChecker(Drop);
                        };
                        warunek = true;
                    }
                    else if (decision == "2")
                    {
                        warunek = true;
                    }
                } while (warunek == false);

                
            }

        }
    }
}
