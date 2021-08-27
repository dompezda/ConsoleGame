using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main
{
    public abstract class Item
    {
        public string Name;
        public int UniqueID;
       
    }
    class Armors :Item
    {
        public int BonusArmor;
       

    }
    class Weapons :Item
    {
        public int BonusDmg;
        
    }
    public class Potion:Item
    {
        public int Power;
    }
    
}
