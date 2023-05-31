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
        public Loup(int[] dimension) : base(dimension)
        {
            cuir = dices.RollD(1,4);
            BonusRacialEndurance = 1;
            Pv = Endurance + ModEndurance;
            race = "loup";
            token = 'L';
        }
    }
}
