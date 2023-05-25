using heroes_VS_monster.models;
using heroes_VS_monster.models.monstres;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heroes_VS_monster.Utils
{
    public class CreationDeMonstre
    {
        private static readonly Random random = new Random();

        /// <summary>
        /// création de monstre
        /// </summary>
        /// <param name="ennemi">le nom de variable de l'ennemi</param>
        /// <returns>un monstre</returns>
        public static Monstre CreeMonstre()
        {
            int rencontreAleatoire = random.Next(1, 4);
            Monstre monstre;
            switch (rencontreAleatoire)
            {
                case 1:
                    monstre = new Loup();
                    break;
                case 2:
                    monstre = new Orque();
                    break;
                default:
                    monstre = new Dragonnet();
                    break;
            }
            return monstre;
        }
        // tester plus tard si this is loup ou quoi
    }
}
