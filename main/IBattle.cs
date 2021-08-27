using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main
{
    public interface IBattle
    {
        void ZombieFight(MainCharacter character, Enemy Opponent);
        void VampireFight(MainCharacter character, Enemy Opponent);
        void SkeletonFight(MainCharacter character, Enemy Opponent);
        void GhoulFight(MainCharacter character, Enemy Opponent);
    }
}
