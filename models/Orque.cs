using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heroes_VS_monster.models
{
    public class Orque : Monstre
    {
        public Orque() : base()
        {
            PiecesDor = dices.RollD(6);
            BonusForce = 1;
        }



    }
}
