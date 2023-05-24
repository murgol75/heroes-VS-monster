using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heroes_VS_monster
{
    public class dices
    {
        private static Random random = new Random();

        // methode pour lancer 1D : genre lancer(6) lancera 1D6
        public static int RollD(int face)
        {
            return random.Next(1, face+1);
        }

        // methode pour lancer les des pour generer les caracs

        public static int Lancer4D6()
        {
            int[] jet = new int[4];
            for (int i = 0; i < 4; i++)
            {
                jet[i] = RollD(6);
            }
            return jet.Sum() - jet.Min();
        }

    }
}
