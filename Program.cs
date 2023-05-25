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
            var herosPrincipal = new Nain("murgol");
            //Console.WriteLine($"nom : {herosPrincipal.nom}, race : {herosPrincipal.race}, force : {herosPrincipal.force}, Modificateur de force : {herosPrincipal.modForce}, Bonus racial de Force : {herosPrincipal.bonusRacialForce}, Endurance : {herosPrincipal.endurance}, Modificateur d'endurance : {herosPrincipal.modEndurance}, Bonus racial d'endurance : {herosPrincipal.bonusRacialEndurance}, PV : {herosPrincipal.pv} ({herosPrincipal.endurance}+{herosPrincipal.modEndurance})");
            Monstre[] monstres = GenererDesMonstres.GenereMonstre();
            //Console.WriteLine($"nom : {monstres[1].nom}, race : {monstres[1].race}, force : {monstres[1].force}, Modificateur de force : {monstres[1].modForce}, Bonus racial de Force : {monstres[1].bonusRacialForce}, Endurance : {monstres[1].endurance}, Modificateur d'endurance : {monstres[1].modEndurance}, Bonus racial d'endurance : {monstres[1].bonusRacialEndurance}, PV : {monstres[1].pv} ({monstres[1].endurance}+{monstres[1].modEndurance}), OR {monstres[1].piecesDOr}, CUIR {monstres[1].cuir}");
            Combat combat = new Combat();
            combat.Fight(herosPrincipal);
        }
    }
}