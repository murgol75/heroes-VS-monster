using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heroes_VS_monster.models
{
    public class Monstre : Personnage
    {
        public Monstre() : base()
        {
            Nom = Name_Generator.GenerateRandomName();
        }


    }
}
