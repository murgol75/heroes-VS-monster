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
            Console.WriteLine("etape 1 check");
            Personnage herosPrincipal = creationPerso.CreePerso(); // Créer une instance de la classe CreationPerso étape 2 
            Console.WriteLine("etape 2 check");
            // définir la taille de la map
            Dimensions taillePlateau = new Dimensions();
            Console.WriteLine("etape 3 check");
            int[] plateau = taillePlateau.dimensionTableau();
            Console.WriteLine("etape 4 check");
            
            int monstresMax = ((plateau[0]* plateau[1])/27)*2;
            Console.WriteLine("etape 5 check");
            int NbrMonstres;
            Console.WriteLine("etape 6 check");
            bool b;
            Console.WriteLine("etape 7 check");
            do
            {
                Console.WriteLine($"Combien de monstres voulez-vous ? (maximum {monstresMax})");
            } while (b = int.TryParse(Console.ReadLine(), out NbrMonstres) && (NbrMonstres>monstresMax || NbrMonstres < 0));
            Console.WriteLine("etape 8 check");
            Monstre[] ennemis = GenererDesMonstres.GenereMonstre(NbrMonstres,plateau); // générer tous les monstres 
            Console.WriteLine("etape 9 check");

            // debut du combat, l'idée c'est de tout gerer à partir de "Game.jeu"
            Game Jouons = new Game();
            Game.Jeu(herosPrincipal, ennemis, plateau, NbrMonstres);

            
            
            
        }
    }
}