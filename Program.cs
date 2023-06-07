using heroes_VS_monster.models;
using heroes_VS_monster.models.Heros;
using heroes_VS_monster.models.monstres;
using heroes_VS_monster.Utils;
using System;

namespace heroes_VS_monster
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Shorewood");

            CreationPerso creationPerso = new CreationPerso();  // Créer une instance de la classe CreationPerso étape 1
            Personnage herosPrincipal = creationPerso.CreePerso(); // Créer une instance de la classe CreationPerso étape 2 
            // définir la taille de la map
            Dimensions taillePlateau = new Dimensions();
            int[] plateau = taillePlateau.dimensionTableau();
            
            int monstresMax = ((plateau[0]* plateau[1])/27)*2;
            int nbrMonstres;
            //bool b; 
            do
            {
                Console.WriteLine($"Combien de monstres voulez-vous ? (maximum {monstresMax})");
            } while (int.TryParse(Console.ReadLine(), out nbrMonstres) && (nbrMonstres>monstresMax || nbrMonstres < 0));
            //} while (b = int.TryParse(Console.ReadLine(), out nbrMonstres) && (nbrMonstres>monstresMax || nbrMonstres< 0));  version mise avant, mais en fait dans ce cas-ci pas besoin de b= car le while renvoie déjà un booleen
            Monstre[] ennemis = GenererDesMonstres.GenereMonstre(nbrMonstres,plateau); // générer tous les monstres 

            // debut du combat, l'idée c'est de tout gerer à partir de "Game.jeu"
            //Game Jouons = new Game();
            //Jouons.Jeu(herosPrincipal, ennemis, plateau, nbrMonstres);
            Game.Jeu(herosPrincipal, ennemis, plateau, nbrMonstres); // cette ligne est mieux que les 2 précédentes et est permise car la méthode jeu est static et comme ça il n'y a rien de stocké




        }
    }
}
