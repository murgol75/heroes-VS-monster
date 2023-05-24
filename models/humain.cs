using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heroes_VS_monster.models
{
    public class humain : heros
    {
        public humain(string name) : base(name)
        {
            BonusForce = 1;
            BonusEndurance = 1;
        }
    }
}
