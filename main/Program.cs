using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Text.RegularExpressions;
using System.Drawing;



namespace main
{

    class Program
    {
        static void Main(string[] args)
        {
            var Player = MainCharacter.GetMainCharacterInstance();
            Player.HealthPoints = 150;
            Player.Dmg = 5;
            Player.Armor = 7;
            Player.x = 7;
            Player.y = 7;
            Player.Score = 0;
            Player.MaxHealth = 150 ;
            Player.Inventory = new List<Item>();


            Console.WriteLine("Witamy serdecznie!");

            Potion HPpotion = new Potion();
            HPpotion.Power = 20;

            string[] mapFile = File.ReadAllLines("mapa.txt");
            foreach (string Line in mapFile)
            {
                Console.WriteLine(Line);
            }

            Move map = new Move(mapFile);

            map.Position(Player);
            Console.ReadKey();
        }

    }
}


    




   



       
   







