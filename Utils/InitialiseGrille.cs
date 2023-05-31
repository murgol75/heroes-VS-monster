using heroes_VS_monster.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heroes_VS_monster.Utils
{
    public class InitialiseGrille
    {
        public char[,] initPlateau(Personnage hero, Personnage[] ennemi, int[] dimension)
        {
            char[,] plateau = new char[dimension[0], dimension[1]];
            for (int i = 0; i < plateau.GetLength(0); i++)
            {
                for (int j = 0; j < plateau.GetLength(1); j++)
                {
                    for (int k = 0; k < ennemi.Count(); k++)
                    {
                        // verifier si l'emplacement correspond au heros
                        if (i == hero.position[0] && j == hero.position[1])
                        {
                            plateau[i, j] = hero.token;
                        }
                        // verifier si l'emplacement correspond à un des monstres
                        
                        else if (i == ennemi[k].position[0] && j == ennemi[k].position[1])       
                        {
                            if (!ennemi[k].isDead && !ennemi[k].isHidden)
                            {
                                plateau[i, j] = ennemi[k].token;
                            }
                            else
                            {
                                plateau[i, j] = ' ';
                            }
                            k = ennemi.Count();
                        }
                        // sinon mettre un espace blanc
                        else
                        {
                            plateau[i, j] = ' ';
                        }
                    }
                }
            }
            return plateau;
        }
    }
}