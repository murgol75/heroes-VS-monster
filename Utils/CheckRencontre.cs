using heroes_VS_monster.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heroes_VS_monster.Utils
{
    public class CheckRencontre
    {
        Combat baston = new Combat();
        public void adjacent(Personnage hero, Personnage[] monstre, int NombreDeMonstre)
        {
            for (int i=0;i<NombreDeMonstre;i++)
            {
                if (Math.Abs(hero.position[0] - monstre[i].position[0])==1 && Math.Abs(hero.position[1] - monstre[i].position[1]) == 1)
                {
                    monstre[i].isHidden = false;
                }
            }
        }
        public void devoile(Personnage hero, Personnage[] monstre, int NombreDeMonstre)
        {
            for (int i = 0; i < NombreDeMonstre; i++)
            {
                if (!monstre[i].isHidden)
                {

                    baston.Fight(hero, monstre[i]);
                }
            }
        }
    }
}
