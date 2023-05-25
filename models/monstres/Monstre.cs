using heroes_VS_monster.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heroes_VS_monster.models.monstres
{
    public class Monstre : Personnage
    {
        public Monstre() : base()
        {
            nom = Name_Generator.GenerateRandomName(race);
        }

        
    }
}
