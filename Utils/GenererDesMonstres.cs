using heroes_VS_monster.models.monstres;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heroes_VS_monster.Utils
{
    public class GenererDesMonstres
    {
        public static Monstre[] GenereMonstre()
        {
            int nombreDeMonstres = 10;
            List<Monstre> ennemis = new List<Monstre>();
            
            
            bool premierBienPlace = false;
            while (!premierBienPlace)
            {
                Monstre monstre = new Monstre();
                if (monstre.posX != 0 && monstre.posY != 0)
                    {
                    ennemis.Add(monstre);
                    premierBienPlace = true;
                    }
            }

            for (int i=1;i<nombreDeMonstres;i++)
            {
                bool suivantMalPlace = true;
                while (suivantMalPlace)
                {
                    Monstre nextMonstre = new Monstre();
                    if (nextMonstre.posX != 0 && nextMonstre.posY != 0)
                    {
                        int compteur = 0;
                        for (int j=0;j<ennemis.Count()-1;j++)
                        {
                            // verifier position de Nextmonstre par rapport à ennemi[j]
                            // posX NM-posX enJ 

                            // si abs(X NM - Xenj) <3 && abs(Y NM - Yenj) <3 alors pas bon  ... bon, l'idée c'est qu'en fait le monstre ne doit pas etre adjacent OOO
                            //                                                                                                                                    OXO
                            //                                                                                                                                    OOO

                            if (Math.Abs(nextMonstre.posX - ennemis[j].posX) >2)
                            {
                                //suivantMalPlace = true; // partir sur un compteur +1 si mal placé
                            }
                        }



                        ennemis.Add(nextMonstre);
                        premierBienPlace = true;
                    }
                }

                //instancier le monstre
                Monstre monstre = new Monstre();
                //verifier si le mob n'est pas en 00
                if (monstre.posX!=0 && monstre.posY!=0)




                //verifier si le mob n'est pas en 00 puis boucler pour verifier s'il n'est pas à 2 cases d'un autre
                ennemis.Add(CreationDeMonstre.CreeMonstre());
            }
            return ennemis.ToArray();


        }

    }
}
