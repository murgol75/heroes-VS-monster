using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heroes_VS_monster.models
{
    public class Nain : heros
    {
        public Nain(string name) : base(name)
        {
            BonusEndurance = 2;
        }
    }
}
