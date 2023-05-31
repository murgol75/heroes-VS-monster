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
        public Dragonnet(int[] dimension) : base(dimension)
        {
            piecesDOr = dices.RollD(1,6);
            cuir = dices.RollD(1,4);
            BonusRacialEndurance = 1;
            Pv = Endurance + ModEndurance;
            race = "dragonet";
            token = 'D';
        }
    }
}
