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
                // CreationDeMonstre.CreeMonstre()
                var monstre = CreationDeMonstre.CreeMonstre();
                
                if (monstre.position[1] != 0 && monstre.position[0] != 0)
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
                    var nextMonstre = CreationDeMonstre.CreeMonstre();
                    //Console.WriteLine($"monstre : posX {nextMonstre.posX}, posY {nextMonstre.posY}");

                    if (nextMonstre.position[1] != 0 && nextMonstre.position[0] != 0)
                    {
                        int compteurErreur = 0;
                        for (int j=0;j<ennemis.Count()-1;j++)
                        {
                            //Console.WriteLine($"ennemi{j} : posX {ennemis[j].posX}, posY {ennemis[j].posY}");
                            if ((ennemis[j].position[1]-2 <= nextMonstre.position[1] && nextMonstre.position[1] <= ennemis[j].position[1] + 2 ) && (ennemis[j].position[0] - 2 <= nextMonstre.position[0] && nextMonstre.position[0] <= ennemis[j].position[0] + 2))  //TODO ça c'est de la merde, à refaire 
                            {
                                compteurErreur += 1;
                                //Console.WriteLine(compteurErreur);
                            }
                        }
                        if (compteurErreur==0)
                        {
                            ennemis.Add(nextMonstre);
                            Console.WriteLine($"posX : {ennemis[i].position[1]}, posY : {ennemis[i].position[0]}, nom : {ennemis[i].nom}");
                            suivantMalPlace = false;
                        }
                        premierBienPlace = true;  //suivant ou premier ??
                    }
                }
            }
            return ennemis.ToArray();
        }
    }
}
