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
            //TODO methode pour créer le perso en demandant à l'utilisateur
            var herosPrincipal = new Nain("murgol");
            Monstre[] monstres = GenererDesMonstres.GenereMonstre();
            Combat combat = new Combat();
            combat.Fight(herosPrincipal);
        }
    }
}