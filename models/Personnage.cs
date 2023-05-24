using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heroes_VS_monster.models
{
    public class Personnage
    {
        public Personnage()
        {
            
            Force = dices.Lancer4D6();
            BonusForce = 0;
            BonusEndurance = 0;
            Endurance = dices.Lancer4D6();
            Pv = Endurance+ModEndurance;
            PiecesDor = 0;
            Cuir = 0;
        }
        public int Force { get; }
        public int BonusForce { get; set; }
        public int ModForce
        {
            get
            {
                return CalculModificateur(Force + BonusForce);
            }
        }
        public int Endurance { get; }
        public int BonusEndurance { get; set; }
        public int ModEndurance
        {
            get
            {
                return CalculModificateur(Endurance + BonusEndurance);
            }
        }
        public int Pv { get; set; }
        public string Nom { get; set; }
        public int PiecesDor { get; set; }
        public int Cuir { get; set; }
        public int CalculModificateur(int carac)
        {
            switch (carac)
            {
                case < 5:
                    return -1;
                    break;
                case < 10:
                    return 0;
                    break;
                case < 15:
                    return 1;
                    break;
                default:
                    return 2;
                    break;
            }
        }
        public void Frappe(Personnage a, Personnage b)
        {
            int attaque = dices.RollD(4) + a.ModForce;
            b.Pv -= attaque;
            // voir si les PV sont à 0 ou moins
            // si oui est-ce que c'est un PJ ?
                // si oui : Game Over
                // si non : le PJ gagne le loot et reviens au max PV et le combat est fini, // si le PJ a tué 10 monstres, le jeu s'arrete, sinon on change de cible
            // si non on continue
            // ma décision (non ce n'est pas le bon endroit pour faire ça) c'est la création aléatoire du monstre sur base d'une table de rencontre : 1 = loup, 2 = orque, 3 = dragonnet, mais du coup, comment je fais pour le nom du monstre ?  prévoir aussi de dire : tu as tué le monstre N° x
        }
    }
}
