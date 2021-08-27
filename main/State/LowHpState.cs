using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main.State
{
    class LowHpState : PlayerState
    {
        public override void Handle() 
        {
            Console.WriteLine("niski poziom zdrowia");
        }
    }
}
