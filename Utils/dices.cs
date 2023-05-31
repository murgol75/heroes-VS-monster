using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heroes_VS_monster.Utils
{
    public class dices 
    {
        private static Random random = new Random();

        /// <summary>
        /// methode pour lancer les D : genre lancer(3,6) lancera 3D6 
        /// </summary>
        /// <param name="nbre">nombre de dés</param>
        /// <param name="face">nombre de faces</param>
        /// <returns>la somme de tous les dés</returns>
        public static int RollD(int nbre,int face)
        {
            int somme = 0;
            for (int i=0; i < nbre;i++)
            {
                somme+=random.Next(1, face + 1);
            }
            return somme;
        }

        /// <summary>
        /// methode pour lancer les des pour generer les caracs
        /// </summary>
        /// <returns>les 3 plus haut résultats de 4 dés lancés</returns>
        public static int Lancer4D6Garde3() 
        {
            int[] jetDeDes = new int[4];
            for (int i = 0; i < 4; i++)
            {
                jetDeDes[i] = RollD(1,6);
            }
            return jetDeDes.Sum() - jetDeDes.Min();
        }
        /// <summary>
        /// lance des dés, et n'en garde que quelques un
        /// </summary>
        /// <param name="nombre">le nombre de dés à lancer</param>
        /// <param name="faces">le nombre de faces</param>
        /// <param name="garde">le nombre de dés à garder</param>
        /// <returns></returns>
        public List<int> RollDice(int nombre, int faces, int garde)
        {
            Random random = new Random();
            List<int> results = new List<int>();

            // Lancer les dés
            for (int i = 0; i < nombre; i++)
            {
                int roll = random.Next(1, faces + 1);
                results.Add(roll);
            }

            // Trier les résultats du plus grand au plus petit
            results.Sort((x, y) => y.CompareTo(x));

            // Conserver les Z meilleurs résultats
            if (garde < results.Count)
            {
                results = results.Take(garde).ToList();
            }

            return results;
        }

    }
}
