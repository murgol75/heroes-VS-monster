﻿using System;
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
            nom = "";
            race = "";
            token = ' ';
            force = dices.Lancer4D6Garde3();
            bonusForce = 0;
            endurance = dices.Lancer4D6Garde3();
            bonusEndurance = 0;
            pv = 0;
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
        public int force { get; }

        private int bonusForce;

        public int bonusRacialForce { get; set; }
        public int modForce => CalculModificateur(force + bonusRacialForce);  // méthode plus rapide que celle utilisée pour endurance (que j'ai laissée pour la comparaison)
        public int endurance { get; }

        private int bonusEndurance;

        public int bonusRacialEndurance { get; set; }
        public int modEndurance
        {
            get
            {
                return CalculModificateur(endurance + bonusRacialEndurance);
            }
        }
        public int pv { get; set; } 

                public int maxPv;

        public string nom { get; set; }

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
            int degats = dices.RollD(4) + modForce;
            cible.pv -= degats;
            Console.WriteLine($"{nom} frappe {cible.nom} et fait {degats} dégâts.  {cible.nom} ne possède plus que {cible.pv} PV");

        }

    }
}
