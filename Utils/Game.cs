using heroes_VS_monster.models.heros;
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
        
        public void Jeu (Personnage hero, Personnage[] ennemi, int[] dimension, int nbMonstre)
        {
            int monstresRestant = nbMonstre;
            int comptemp = 0;
            while (!hero.isDead && comptemp!=nbMonstre) //compter le nombre de monstres.isDead 
            {
                // vérifier si le perso est adjacent au monstre et si oui, on affiche le monstre
                CheckRencontre Verif = new CheckRencontre();
                Verif.adjacent(hero,ennemi,10);

                InitialiseGrille plateau = new InitialiseGrille();

                char[,] tab = plateau.initPlateau(hero, ennemi, dimension);
                imprimer_grille.affichePlateau(tab);

                
                
                // bouger le perso
                ((heros)hero).mouvementHeros(hero, dimension);

                
                // verifier si monste apparu et si oui baston
                Verif.devoile(hero, ennemi, 10);

                //compter les morts
                comptemp = 0;
                for (int i=0;i<nbMonstre;i++)
                {
                    if (ennemi[i].isDead)
                    {
                        comptemp += 1;
                    }
                }
                Console.WriteLine(comptemp);
                Console.ReadKey();


            }

            if (!hero.isDead)
            {
                Console.WriteLine($"{hero.nom} le {hero.race} est victorieux après avoir terassé les {nbMonstre} monstres qui se sont attaqués à lui");
                Console.WriteLine($"{hero.nom} le {hero.race} possède maintenant {hero.piecesDOr} PO {hero.cuir} cuirs");
            }

        }
    }
}
