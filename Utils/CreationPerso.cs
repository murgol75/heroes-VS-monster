using heroes_VS_monster.models;
using heroes_VS_monster.models.Heros;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace heroes_VS_monster.Utils
{
    public class CreationPerso
    {
        public Personnage CreePerso()
        {
            // demander au joueur le nom du personnage
            Console.Write("Quel est le nom du personnage ?");
            string persoName = Console.ReadLine();
            // demander au joueur la race du personnage
            string persoRace = "";
            do
            {
                Console.Write("Quel est la race du personnage (humain ou nain) ?");
                persoRace = Console.ReadLine();

            } while (persoRace != "humain" && persoRace != "nain");

            // créer le personnage
            Personnage herosPrincipal;
            switch (persoRace)
            {
                case "humain":
                    herosPrincipal = new Humain(persoName);
                    break;
                case "nain":
                    herosPrincipal = new Nain(persoName);
                    break;
                default:
                    herosPrincipal = new Humain(persoName);
                    break;
            }
            return herosPrincipal;
        }
        

    }
}
