using heroes_VS_monster.models.heros;
using heroes_VS_monster.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heroes_VS_monster.Utils
{
    public class Game
    {
        public void Jeu (Personnage hero, Personnage[] ennemi)
        {
            InitialiseGrille.initPlateau(hero, ennemi[]);
        }
    }
}
