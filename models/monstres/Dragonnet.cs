using heroes_VS_monster.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heroes_VS_monster.models.monstres
{
    public class Dragonnet : Monstre
    {
        public Dragonnet() : base()
        {
            piecesDOr = dices.RollD(6);
            cuir = dices.RollD(4);
            bonusRacialEndurance = 1;
            pv = endurance + modEndurance;
            race = "dragonet";
        }
    }
}
