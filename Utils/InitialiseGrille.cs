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
        public void initPlateau(Personnage hero, Personnage[] ennemi)
        {
            int hauteurGrille = 15;
            int largeurGrille = 15;
            char[,] plateau = new char[largeurGrille, hauteurGrille];

            for (int i = 0; i < plateau.GetLength(0); i++)
            {
                for (int j = 0; j < plateau.GetLength(1); j++)
                {
                    // verifier si l'emplacement correspond au heros
                    if (i == hero.position[1] && j == hero.position[0])
                    {
                        plateau[i, j] = hero.token;
                    }

                    // verifier si l'emplacement correspond à un des monstres
                    for (int k=0;k<ennemi.Count() - 1; k++)
                    {
                        if (i == ennemi[k].position[1] && j == ennemi[k].position[0])
                        {
                            plateau[i, j] = ennemi[k].token;
                        }
                    }
                }
            }
        }
    }
}