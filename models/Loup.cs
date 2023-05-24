using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heroes_VS_monster.models
{
    public class Loup : Monstre
    {
        public Loup() : base()
        {
            Cuir = dices.RollD(4);
            BonusEndurance = 1;
        }
    }
}
