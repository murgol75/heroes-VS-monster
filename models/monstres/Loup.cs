using heroes_VS_monster.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heroes_VS_monster.models.monstres
{
    public class Loup : Monstre
    {
        public Loup() : base()
        {
            cuir = dices.RollD(4);
            bonusRacialEndurance = 1;
            pv = endurance + modEndurance;
            race = "loup";
            token = 'L';
        }
    }
}
