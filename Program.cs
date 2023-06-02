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
            int NbrMonstres;
            bool b;
            do
            {
                Console.WriteLine($"Combien de monstres voulez-vous ? (maximum {monstresMax})");
            } while (b = int.TryParse(Console.ReadLine(), out NbrMonstres) && (NbrMonstres>monstresMax || NbrMonstres < 0));
            Monstre[] ennemis = GenererDesMonstres.GenereMonstre(NbrMonstres,plateau); // générer tous les monstres 

            // debut du combat, l'idée c'est de tout gerer à partir de "Game.jeu"
            Game Jouons = new Game();
            Jouons.Jeu(herosPrincipal, ennemis, plateau, NbrMonstres);

            
            
            
        }
    }
}
