using heroes_VS_monster.models;
using heroes_VS_monster.models.Heros;
using heroes_VS_monster.models.monstres;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heroes_VS_monster.Utils
{
    public class Combat
    {
        public void Fight(Personnage joueur, Personnage monstre)
        {
            Console.WriteLine($"rencontre avec : {monstre.Nom} le {monstre.race}");
            while (!joueur.isDead && !monstre.isDead)
            {
                joueur.Frappe(monstre);
                if (monstre.Pv <= 0)
                {
                    joueur.piecesDOr += monstre.piecesDOr;
                    joueur.cuir += monstre.cuir;
                    Console.WriteLine($"{joueur.Nom} a vaincu {monstre.Nom} le {monstre.race}.  ses PV reviennent à {joueur.maxPv} et il possède maintenant {joueur.piecesDOr} PO et {joueur.cuir} cuirs");
                    monstre.isDead = true;
                    joueur.Pv = joueur.maxPv;
                    
                }
                if (!monstre.isDead)
                {
                    monstre.Frappe(joueur);
                    if (joueur.Pv <= 0)
                    {
                        Console.WriteLine($"{joueur.Nom} a été vaincu par {monstre.Nom} le {monstre.race}. Il récupère les {joueur.piecesDOr} PO et les {joueur.cuir} cuirs que {joueur.Nom} possédait");
                        joueur.isDead = true;
                    }
                }
                Console.ReadKey();
            }
        }

    }
}
