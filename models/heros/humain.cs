using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heroes_VS_monster.models.Heros
{
    public class Humain : Heros
    {
        public Humain(string name) : base(name)
        {
            BonusRacialForce = 1;
            BonusRacialEndurance = 1;
            Pv = Endurance + ModEndurance;
            maxPv = Pv;
            race = "humain";
        }
    }
}
