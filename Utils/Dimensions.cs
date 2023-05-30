using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace heroes_VS_monster.Utils
{
    public class Dimensions
    {
        public int[] dimensionTableau()
        {
            int[] dimension = new int[2];
            bool a = true;
            bool b = true;
            do
            {
                Console.WriteLine("définissez la hauteur du tableau");
                a = int.TryParse(Console.ReadLine(), out dimension[0]);
            } while (!a);
            do
            {
                Console.WriteLine("définissez la largeur du tableau");
                b = int.TryParse(Console.ReadLine(), out dimension[1]);
            } while (!b);


            return dimension;
        }
    }
}
