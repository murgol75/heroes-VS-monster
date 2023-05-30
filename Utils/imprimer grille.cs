using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heroes_VS_monster.Utils
{
    public class imprimer_grille
    {
        public static void affichePlateau(char[,] grille)
        {
            Console.Clear();
            Console.Write("╔");
            for (int i = 1; i <= grille.GetLength(0); i++)
            {
                Console.Write("═");

            }
            Console.WriteLine("╗");
            for (int i = 0; i < grille.GetLength(1); i++)
            {
                Console.Write("║");
                for (int j = 0; j < grille.GetLength(0); j++)
                {
                    Console.Write(grille[j, i]);
                }
                Console.WriteLine("║");
            }
            Console.Write("╚");
            for (int i = 1; i <= grille.GetLength(0); i++)
            {
                Console.Write("═");

            }
            Console.WriteLine("╝");
        }

    }
}
