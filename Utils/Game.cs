using heroes_VS_monster.models.Heros;
using heroes_VS_monster.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using heroes_VS_monster.models.monstres;

namespace heroes_VS_monster.Utils
{
    public class Game
    {
        
        public static void Jeu (Personnage hero, Personnage[] ennemi, int[] dimension, int nbMonstre)
        {
            int comptemp = 0;
            while (!hero.isDead && comptemp!=nbMonstre) //compter le nombre de monstres.isDead 
            {
                // vérifier si le perso est adjacent au monstre et si oui, on affiche le monstre
                CheckRencontre Verif = new();
                Verif.adjacent(hero,ennemi,nbMonstre);

                InitialiseGrille plateau = new ();

                char[,] tab = plateau.initPlateau(hero, ennemi, dimension);
                imprimer_grille.affichePlateau(tab);

                
                
                // bouger le perso
                ((Heros)hero).mouvementHeros(hero, dimension);

                
                // verifier si monste apparu et si oui baston
                Verif.devoile(hero, ennemi, nbMonstre);

                //compter les morts
                comptemp = 0;
                for (int i=0;i<nbMonstre;i++)
                {
                    if (ennemi[i].isDead)
                    {
                        comptemp += 1;
                    }
                }
                


            }

            if (!hero.isDead)
            {
                Console.WriteLine($"{hero.Nom} le {hero.race} est victorieux après avoir terassé les {nbMonstre} monstres qui se sont attaqués à lui");
                Console.WriteLine($"{hero.Nom} le {hero.race} possède maintenant {hero.piecesDOr} PO {hero.cuir} cuirs");
            }

        }
    }
}
