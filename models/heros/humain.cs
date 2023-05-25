using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heroes_VS_monster.models.heros
{
    public class humain : heros
    {
        public humain(string name) : base(name)
        {
            bonusRacialForce = 1;
            bonusRacialEndurance = 1;
            pv = endurance + modEndurance;
            maxPv = pv;
            race = "humain";
        }
    }
}
