using heroes_VS_monster.models.Heros;
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
        public static Monstre[] GenereMonstre(int nombreDeMonstres, int[] dimension)
        {
            List<Monstre> ennemis = new List<Monstre>();

            // il doit d'office y avoir au moins 1 monstre, donc je l'installe d'office, histoire de pouvoir checker avec les autres après
            bool premierBienPlace = false;
            while (!premierBienPlace)
            {
                var monstre = CreationDeMonstre.CreeMonstre(dimension);

                if (monstre.position[1] != 0 && monstre.position[0] != 0)
                {
                
                    ennemis.Add(monstre);
                    premierBienPlace = true;
                }
            }

            
                
                for (int i = 1; i < nombreDeMonstres; i++) // cette boucle for crèe les monstres manquants i est utilisé nulle part
                {
                    bool suivantBienPlace = false;
                    while (!suivantBienPlace)
                    {
                        var nextMonstre = CreationDeMonstre.CreeMonstre(dimension);

                        if (nextMonstre.position[1] != 0 && nextMonstre.position[0] != 0) // cette 
                        {
                            int compteurErreur = 0;
                            for (int j = 0; j < ennemis.Count() ; j++) // cette boucle sert à faire le tour de tous les monstres existants pour les comparer à celui que je viens de créer.  j est l'index du monstre de la liste valide
                            {
                                if ((Math.Abs(ennemis[j].position[1] - nextMonstre.position[1]) < 3) && (Math.Abs(ennemis[j].position[0] - nextMonstre.position[0]) < 3))
                                {
                                    compteurErreur += 1;
                                }
                            }
                            if (compteurErreur == 0)
                            {
                                ennemis.Add(nextMonstre);
                                suivantBienPlace = true;
                            }
                        }
                    }
                    for (int t=0;t<ennemis.Count();t++)
                    {

                    }
                }

            return ennemis.ToArray();
        }
    }
}
