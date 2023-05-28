using heroes_VS_monster.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heroes_VS_monster.Utils
{
    internal class Deplacement_heros
    {
        static int[] mouvementHeros(Personnage heros, int hauteur, int largeur)
        {
            bool goodMove = false;
            char move = ' ';
            while (!goodMove)
            {
                move = Console.ReadKey().KeyChar;
                if (move == 'z' || move == 'q' || move == 's' || move == 'd')
                {
                    goodMove = true;
                    switch (move)
                    {
                        case 'z':
                            if (heros.position[0] != 0)
                            {
                                heros.position[0] -=1;
                            }
                            break;
                        case 's':
                            if (heros.position[1] != hauteur - 1)
                            {
                                heros.position[1] = heros.position[1] + 1;
                            }
                            break;
                        case 'q':
                            if (heros.position[0] != 0)
                            {
                                heros.position[0] = heros.position[0] - 1;
                            }
                            break;
                        case 'd':
                            if (heros.position[0] != largeur - 1)
                            {
                                heros.position[0] = heros.position[0] + 1;
                            }
                            break;
                        default:
                            goodMove = false;
                            Console.WriteLine("mauvais mouvement");
                            break;
                    }
                }
            }
            return heros.position;
        }
    }
}
