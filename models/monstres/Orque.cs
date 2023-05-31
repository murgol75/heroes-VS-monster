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
        public Orque(int[] dimension) : base(dimension)
        {
            piecesDOr = dices.RollD(1,6);
            BonusRacialForce = 1;
            Pv = Endurance + ModEndurance;
            race = "orque";
            token = 'O';
        }



    }
}
