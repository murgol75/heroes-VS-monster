using heroes_VS_monster.models;
using heroes_VS_monster.models.heros;
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
            Console.WriteLine($"rencontre avec : {monstre.nom} le {monstre.race}");
            while (!joueur.isDead && !monstre.isDead)
            {
                joueur.Frappe(monstre);
                if (monstre.pv <= 0)
                {
                    joueur.piecesDOr += monstre.piecesDOr;
                    joueur.cuir += monstre.cuir;
                    Console.WriteLine($"{joueur.nom} a vaincu {monstre.nom} le {monstre.race}.  ses PV reviennent à {joueur.maxPv} et il possède maintenant {joueur.piecesDOr} PO et {joueur.cuir} cuirs");
                    monstre.isDead = true;
                    joueur.pv = joueur.maxPv;
                    
                }
                if (!monstre.isDead)
                {
                    monstre.Frappe(joueur);
                    if (joueur.pv <= 0)
                    {
                        Console.WriteLine($"{joueur.nom} a été vaincu par {monstre.nom} le {monstre.race}. Il récupère les {joueur.piecesDOr} PO et les {joueur.cuir} cuirs que {joueur.nom} possédait");
                        joueur.isDead = true;
                    }
                }
                Console.ReadKey();
            }
        }

    }
}
