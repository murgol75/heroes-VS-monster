using heroes_VS_monster.models.monstres;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heroes_VS_monster.Utils
{
    public class GenererDesMonstres
    {
        public static Monstre[] GenereMonstre()
        {
            int nombreDeMonstres = 10;
            List<Monstre> ennemis = new List<Monstre>();
            for (int i=0;i<nombreDeMonstres;i++)
            {
                ennemis.Add(CreationDeMonstre.CreeMonstre());
            }
            return ennemis.ToArray();


        }

    }
}
