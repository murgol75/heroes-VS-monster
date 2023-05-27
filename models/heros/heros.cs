using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heroes_VS_monster.models.heros
{
    public class heros : Personnage
    {
        public heros(string name) : base()
        {
            nom = name;
            token = 'H';
        }

        
    }
}
