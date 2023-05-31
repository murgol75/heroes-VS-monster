using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heroes_VS_monster.models.Heros
{
    public class Nain : Heros
    {
        public Nain(string name) : base(name)
        {
            BonusRacialEndurance = 2;
            Nom = name;
            Pv = Endurance + ModEndurance;
            maxPv = Pv;
            race = "nain";
        }
    }
}
