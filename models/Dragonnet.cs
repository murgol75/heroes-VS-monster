using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heroes_VS_monster.models
{
    public class Dragonnet : Monstre
    {
        public Dragonnet() : base()
        {
            PiecesDor = dices.RollD(6);
            Cuir = dices.RollD(4);
            BonusEndurance = 1;
        }



    }
}
