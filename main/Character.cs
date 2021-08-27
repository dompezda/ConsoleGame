using main.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main
{
    abstract public class Character 
    {
        public double HealthPoints;
        public int Dmg;
        public double Armor;
        
    }
    public class MainCharacter : Character
    {
        private static MainCharacter mainCharacter;
        private MainCharacter()
        {

        }
        public static MainCharacter GetMainCharacterInstance()
        {
            if (mainCharacter == null)
            {
                mainCharacter = new MainCharacter();
            }
            return mainCharacter;
        }
        public double Luck;
        public int x;
        public int y;
        public char Letter='P';
        public int Score;
        public int MaxHealth;
        public  List<Item> Inventory;
        public int SizeOfInventory;
        public int NumberOfPotions;



        public void InventoryChecker(Item Item)
        {

            SizeOfInventory = Inventory.Count;
            
                for (int i = 0; i < SizeOfInventory; i++)
                {
                    if (Item.UniqueID == Inventory[i].UniqueID)
                    {
                        Console.WriteLine("Juz masz przedmiot tego typu: " + Inventory[i].Name);
                        Console.WriteLine("Czy chcesz go zamienic? (1=Tak,2=Nie)");
                        string decision;
                        decision = Console.ReadLine();
                    if (decision == "1")
                    {
                        if(Inventory[i].UniqueID==1)
                        {
                            Armor -= ((Armors)Inventory[i]).BonusArmor;
                        }
                        if (Inventory[i].UniqueID == 2)
                        {
                            Armor -= ((Armors)Inventory[i]).BonusArmor;
                        }
                        if (Inventory[i].UniqueID == 3)
                        {
                            Armor -= ((Armors)Inventory[i]).BonusArmor;
                        }
                        if (Inventory[i].UniqueID == 3)
                        {
                            Dmg -= ((Weapons)Inventory[i]).BonusDmg;
                        }
                        Inventory.Remove(Inventory[i]);
                        break;

                    }    }
                    
                }
                Inventory.Add(Item);
            if(Item.UniqueID==5)
            {
                NumberOfPotions++;
            }
            if (Item.UniqueID == 1)
            {
                Armor += ((Armors)Item).BonusArmor;
            }
            if (Item.UniqueID == 2)
            {
                Armor += ((Armors)Item).BonusArmor;
            }
            if (Item.UniqueID == 3)
            {
                Armor += ((Armors)Item).BonusArmor;
            }
            if (Item.UniqueID == 4)
            {
                Dmg += ((Weapons)Item).BonusDmg;
            }

        }
        public void ShowInventory()
        {
            if (Inventory == null)
            {
                Console.WriteLine("Masz pusty ekwipunek");
            }
            else
            {
                foreach (var item in Inventory)
                {
                    Console.WriteLine(item.Name);
                }
            }
        }
        
        public static void Stats(MainCharacter Player)
        {
            Console.WriteLine("Twoje zdrowie: "+Player.HealthPoints);
            Console.WriteLine("Twoje obrazenia: " + Player.Dmg);
            Console.WriteLine("Twoj pancerz: " + Player.Armor);
        }
        public void DamageTaken(int Damage,string Text)
        {
            Console.WriteLine(Text+" Trafia Cie w plecy");
            HealthPoints -= Damage;
            Console.WriteLine($"Zadaje Ci " + Damage + "obrazen, zostalo Ci " + HealthPoints + " pkt zdrowia, ale uciekles");

        }
        public void Heal(int Amount)
        {
            HealthPoints += Amount;
            Console.WriteLine("Uleczyles sie za {0}",Amount);
        }
        public void HealByPotion()
        {
            foreach (var item in Inventory)
            {
                
                if(item.UniqueID == 5)
                {
                        
                        int HealAmount = ((Potion)item).Power;
                        Heal(HealAmount);
                        NumberOfPotions -= 1;
                        Inventory.Remove(item);
                        break;
                }
            }
            if (NumberOfPotions == 0)
            {
                Console.WriteLine("Nie masz mikstur");
            }


        }
        public void GetState() 
        {
            if (MaxHealth * 0.75 < HealthPoints)
            {
                PlayerState CurrentState = new HighHpState();
                CurrentState.Handle();
            }
            if(MaxHealth*0.5<HealthPoints && MaxHealth*0.75>HealthPoints)
            {
                PlayerState CurrentState = new MediumHpState();
                CurrentState.Handle();
            }
            if (MaxHealth * 0.33 > HealthPoints)
            {
                PlayerState CurrentState = new LowHpState();
                CurrentState.Handle();
            }

        }


    }
    
}
