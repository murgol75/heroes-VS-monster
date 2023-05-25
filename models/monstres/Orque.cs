using heroes_VS_monster.Utils;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heroes_VS_monster.models.monstres
{
    public class Orque : Monstre
    {
        public Orque() : base()
        {
            piecesDOr = dices.RollD(6);
            bonusRacialForce = 1;
            pv = endurance + modEndurance;
            race = "orque";
        }



    }
}
