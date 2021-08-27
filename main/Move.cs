using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace main
{
    public class Move
    {
        
        private char CurrentRoom = '0';
        private string[] map;

        public Move(string[] M)
        {
            map = M;
            
        }

        public void Position(MainCharacter Player)
        {
        MainCharacter.Stats(Player);
             Console.WriteLine();
        bool Motion = false;
        var Event = new Event(Player);


            int x = Player.x;
            int y = Player.y;
            char Wall = 'W';
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Jestes w pokoju o numerze {0}.", CurrentRoom);
            Console.WriteLine("Podaj kierunek w jaki chcesz sie udac (S,W,N,E)");
            Console.WriteLine("map(M),Ekwipunek(I),Wypij Miksture(P)");
            string a = Console.ReadLine();
            
            char HelpNumber = CurrentRoom;

            if (a == "M")
            {
                foreach (var Line in map)
                {
                    Console.WriteLine(Line);
                }
                Position(Player);
            }
            else if(a == "I")
            {
                Player.ShowInventory();
                foreach (var Line in map)
                {
                    Console.WriteLine(Line);
                }
                Position(Player);
            }
            else if(a=="P")
            {
                Player.HealByPotion();
                Position(Player);
            }
            else if(a == "E")
            {
                if (map[x][y + 2] != Wall)
                {

                    StringBuilder sb = new StringBuilder(map[x]);
                    HelpNumber = sb[y + 5];
                    sb[y + 5] = Player.Letter;
                    sb[y] = CurrentRoom;
                    CurrentRoom = HelpNumber;
                    map[x] = sb.ToString();
                    Player.y += 5;
                    Motion = true;
                    
                    foreach (var Line in map)
                    {
                        Console.WriteLine(Line);
                    }

                    if (Motion == true)
                    {
                        Event.EventRandom();
                    }

                    Position(Player);
                    
                  


                }

                else
                {
                    Console.WriteLine("Ruch niemozliwy do wykonania ");
                    
                    foreach (var Line in map)
                    {
                        Console.WriteLine(Line);
                    }
                    Position(Player);
                  
                    

                }
            }
            else if (a == "W")
            {
                if (map[x][y - 2] != Wall)
                {
                    StringBuilder sb = new StringBuilder(map[x]);
                    HelpNumber = sb[y - 5];
                    sb[y - 5] = Player.Letter;
                    sb[y] = CurrentRoom;
                    CurrentRoom = HelpNumber;
                    map[x] = sb.ToString();
                    Player.y -= 5;
                    
                    Motion = true;
                    
                    foreach (var Line in map)
                    {
                        Console.WriteLine(Line);
                    }

                    if (Motion == true)
                    {
                        Event.EventRandom();
                    }
                    Position(Player);


                }
                else
                {
                    Console.WriteLine("Ruch niemozliwy do wykonania ");
                    foreach (var Line in map)
                    {
                        Console.WriteLine(Line);
                    }
                    Position(Player);
                    
                }
            }

            else if (a == "S")
            {
                if (map[x + 2][y] != Wall)
                {
                    StringBuilder sb = new StringBuilder(map[x]);
                    StringBuilder sb2 = new StringBuilder(map[x + 5]);
                    HelpNumber = sb2[y];
                    sb2[y] = Player.Letter;
                    sb[y] = CurrentRoom;
                    CurrentRoom = HelpNumber;
                    map[x] = sb.ToString();
                    map[x + 5] = sb2.ToString();
                    Player.x += 5;
                    Motion = true;
                    
                    foreach (var Line in map)
                    {
                        Console.WriteLine(Line);
                    }

                    if (Motion == true)
                    {
                        Event.EventRandom();
                    }
                    Position(Player);
                }
                else
                {
                    Console.WriteLine("Ruch niemozliwy do wykonania ");
                   
                    foreach (var Line in map)
                    {
                        Console.WriteLine(Line);
                    }
                    Position(Player);
                }
            }

            else if (a == "N")
            {
                if (map[x - 2][y] != Wall)
                {
                    //map[x][y]=player z map[x-5][y]
                    StringBuilder sb = new StringBuilder(map[x]);
                    StringBuilder sb2 = new StringBuilder(map[x - 5]);
                    HelpNumber = sb2[y];
                    sb2[y] = Player.Letter;
                    sb[y] = CurrentRoom;
                    CurrentRoom = HelpNumber;
                    map[x] = sb.ToString();
                    map[x - 5] = sb2.ToString();
                    Player.x -= 5;
                    Motion = true;

                    foreach (var Line in map)
                    {
                        Console.WriteLine(Line);
                    }

                    if (Motion == true)
                    {
                        Event.EventRandom();
                    }
                    Position(Player);

                }
                else
                {
                    Console.WriteLine("Ruch niemozliwy do wykonania");

                    foreach (var Line in map)
                    {
                        Console.WriteLine(Line);
                    }
                    Position(Player);
                }
            }
            else
            {

                Console.WriteLine("zla wartosc");
                foreach (var Line in map)
                {
                    Console.WriteLine(Line);
                }
                Position(Player);
            }
            if(Motion==true)
            {
                Event.EventRandom();
            }
        } 

    };

}
       