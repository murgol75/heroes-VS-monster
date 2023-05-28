using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heroes_VS_monster.Utils
{
    internal class imprimer_grille
    {
        static void affichePlateau(char[,] grille) // c'est dans la classe de déplacement du heros que j'appelle cette méthode
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
