using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using heroes_VS_monster.Utils;

namespace heroes_VS_monster.models
{
    public class Personnage
    {
        public Personnage()
        {
            Nom = "";
            race = "";
            token = ' '; // la lettre qui symbolise la créature à l'affichage
            Force = dices.Lancer4D6Garde3();
            Endurance = dices.Lancer4D6Garde3();
            Pv = 0;
            maxPv = 0;
            piecesDOr = 0;
            cuir = 0;
            position[0] = 0;
            position[1] = 0;
            isDead = false; // pour savoir si le monstre a été tué
            isHidden = true; // pour savoir si le monstre a été caché
        }
        public bool isDead;
        public bool isHidden;
        public int Force { get; }


        public int BonusRacialForce { get; set; }
        public int ModForce => CalculModificateur(Force + BonusRacialForce);  // méthode plus rapide que celle utilisée pour endurance (que j'ai laissée pour la comparaison)
        public int Endurance { get; }


        public int BonusRacialEndurance { get; set; }
        public int ModEndurance
        {
            get
            {
                return CalculModificateur(Endurance + BonusRacialEndurance);
            }
        }
        public int Pv { get; set; } 

                public int maxPv;

        public string Nom { get; set; }

        public string race;
        public char token;

        public int piecesDOr { get; set; }
        public int cuir { get; set; }

        public int[] position { get; set; } = new int[2];

        public int CalculModificateur(int carac)
        {
            switch (carac)
            {
                case < 5:
                    return -1;
                    //break;  pas besoin de break car j'ai fais un return
                case < 10:
                    return 0;
                case < 15:
                    return 1;
                default:
                    return 2;
            }
        }
        public void Frappe(Personnage cible)
        {
            int degats = dices.RollD(1,4) + ModForce;
            cible.Pv -= degats;
            Console.WriteLine($"{Nom} frappe {cible.Nom} et fait {degats} dégâts.  {cible.Nom} ne possède plus que {cible.Pv} PV");

        }

    }
}
