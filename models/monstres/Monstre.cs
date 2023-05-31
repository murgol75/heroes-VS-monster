using heroes_VS_monster.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace heroes_VS_monster.models.monstres
{
    public class Monstre : Personnage
    {
        

        
        public Monstre(int[] dimension) : base()
        {
            Nom = Name_Generator.GenerateRandomName(race);

            position[0] = dices.RollD(1,dimension[0]) - 1; // -1 car la position sera utilisée comme index  // remplacer le 15 par la hauteur de la grille
            position[1] = dices.RollD(1,dimension[1]) - 1; // remplacer le 15 par la largeur de la grille
            isDead = false; // me servira à mettre un X dans la grille là où le monstre est mort
            isHidden = true; // tant qu'il est caché il n'apparait pas dans la grille

        }
    }

    
}
