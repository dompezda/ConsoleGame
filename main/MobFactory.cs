using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main
{
    public class MobFactory
    {
        public static IMobCreator MobCreator(string mobType)
        {
            IMobCreator result = null;
            if (mobType.ToLower().Equals("ghoul"))
            {
                result = new Ghoul();
            }
            if (mobType.ToLower().Equals("zombie"))
            {
                result = new Zombie();
            }
            if (mobType.ToLower().Equals("bruxa"))
            {
                result = new Bruxa();
            }
            if (mobType.ToLower().Equals("skeleton"))
            {
                result = new Skeleton();
            }
            return result;
        }
    }
}
