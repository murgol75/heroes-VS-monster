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
        public Monstre() : base()
        {
            nom = Name_Generator.GenerateRandomName(race);
            posX = dices.RollD(30)-1; // -1 car la position sera utilisée comme index
            posY = dices.RollD(30)-1;
            isDead = false; // me servira à mettre un X dans la grille là où le monstre est mort
            isHidden = true; // tant qu'il est caché il n'apparait pas dans la grille
        }


    }
}
