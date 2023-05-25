using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heroes_VS_monster.models.heros
{
    public class Nain : heros
    {
        public Nain(string name) : base(name)
        {
            bonusRacialEndurance = 2;
            nom = name;
            pv = endurance + modEndurance+100;
            maxPv = pv;
            race = "nain";
        }
    }
}
