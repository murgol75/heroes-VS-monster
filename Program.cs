using heroes_VS_monster.models;
using heroes_VS_monster.models.heros;
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
            //TODO définir le nombre de monstres
            Monstre[] ennemis = GenererDesMonstres.GenereMonstre(); // générer tous les monstres 
            // définir la taille de la map
            Dimensions taillePlateau = new Dimensions();
            int[] plateau = taillePlateau.dimensionTableau();
            
            // debut du combat, l'idée c'est de tout gerer à partir de "Game.jeu"
            Game Jouons = new Game();
            Jouons.Jeu(herosPrincipal, ennemis, plateau, 10);
        }
    }
}