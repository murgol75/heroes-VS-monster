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
        public void Fight(Personnage joueur)
        {
            // generer les monstress
            Monstre[] monstres = GenererDesMonstres.GenereMonstre();

            // boucle while combat de 0 à 9
            int monstresMorts = 0;
            string etatJoueur = "vivant";
            while (monstresMorts < monstres.Length)
            {
                string etatMonstre = "vivant";

                Console.WriteLine($"rencontre N°{monstresMorts + 1} : {monstres[monstresMorts].nom} le {monstres[monstresMorts].race}");
                while (etatMonstre == "vivant" && etatJoueur == "vivant")
                {
                    joueur.Frappe(monstres[monstresMorts]); //TODO transformer ceci en méthode
                    if (monstres[monstresMorts].pv <= 0)
                    {
                        joueur.piecesDOr += monstres[monstresMorts].piecesDOr;
                        joueur.cuir += monstres[monstresMorts].cuir;
                        Console.WriteLine($"{joueur.nom} a vaincu {monstres[monstresMorts].nom} le {monstres[monstresMorts].race}.  ses PV reviennent à {joueur.maxPv} et il possède maintenant {joueur.piecesDOr} PO et {joueur.cuir} cuirs");
                        monstresMorts += 1;
                        etatMonstre = "mort";
                        joueur.pv = joueur.maxPv;
                    }
                    if (etatMonstre == "vivant")
                    {
                        monstres[monstresMorts].Frappe(joueur);
                        if (joueur.pv <= 0)
                        {
                            Console.WriteLine($"{joueur.nom} a été vaincu par {monstres[monstresMorts].nom} le {monstres[monstresMorts].race}. {monstres[monstresMorts].nom} récupère les {joueur.piecesDOr} PO et les {joueur.cuir} cuirs que {joueur.nom} possédait");
                            etatJoueur = "mort";
                            monstresMorts = monstres.Length;
                        }
                    }

                    Console.WriteLine();
                }
                Console.WriteLine("----------------------------------------------------------------------------------------");


            }
            if (etatJoueur == "vivant")
            {
                Console.WriteLine($"{joueur.nom} le {joueur.race} est victorieux après avoir terassé les {monstres.Length} monstres qui se sont attaqués à lui");
                Console.WriteLine($"{joueur.nom} le {joueur.race} possède maintenant {joueur.piecesDOr} PO {joueur.cuir} cuirs");

            }
        }

    }
}
