using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main.State
{
    class HighHpState : PlayerState
    {
        public override void Handle()
        {
            Console.WriteLine("zdrowie powyzej 75%");
        }
    }
}
