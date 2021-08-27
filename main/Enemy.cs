using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main
{
    public class Enemy : Character
    {
        public int Score;
        public string Opis;
    }
    public class Ghoul : Enemy, IMobCreator
    {
        public double Lifesteal;
        public Ghoul()
        {
            this.HealthPoints = 20;
            this.Armor = 4;
            this.Dmg = 17;
            this.Lifesteal = this.Dmg * 0.1;
            this.Score = 20;
            this.Opis = "Ghoul";
        }
        public Enemy CreateMob()
        {
            return new Ghoul();
        }

    }
    public class Bruxa : Enemy, IMobCreator
    {
        public int Dodge;
        public Bruxa()
        {
            this.HealthPoints = 50;
            this.Armor = 2;
            this.Dmg = 15;
            this.Dodge = 1;
            this.Score = 50;
            this.Opis = "Vampire";
        }
        public Enemy CreateMob()
        {
            return new Bruxa();
        }

    }
    public class Skeleton : Enemy, IMobCreator
    {
        public double Miss;
        public Skeleton()
        {
            this.HealthPoints = 15;
            this.Armor = 0;
            this.Dmg = 14;
            this.Miss = 0.5;
            this.Opis = "Skeleton";
        }

        public Enemy CreateMob()
        {
            return new Skeleton();
        }
    }
    public class Zombie : Enemy, IMobCreator
    {
        public int SelfDmg;
        public Zombie()
        {
            this.HealthPoints = 35;
            this.Armor = 1;
            this.Dmg = 13;
            this.Score = 10;
            this.SelfDmg = 3;
            this.Opis = "Zombie";
        }
        public Enemy CreateMob()
        {
            return new Zombie();
        }
    }
}
