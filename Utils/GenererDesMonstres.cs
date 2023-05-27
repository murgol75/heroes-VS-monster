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
                    var nextMonstre = CreationDeMonstre.CreeMonstre();
                    if (nextMonstre.posX != 0 && nextMonstre.posY != 0)
                    {
                        int compteurErreur = 0;
                        for (int j=0;j<ennemis.Count()-1;j++)
                        {
                            if ((ennemis[j].posX-1 <= nextMonstre.posX && nextMonstre.posX <= ennemis[j].posX+1 ) && (ennemis[j].posY - 1 <= nextMonstre.posY && nextMonstre.posY <= ennemis[j].posY + 1))
                            {
                                compteurErreur += 1;
                            }
                        }
                        if (compteurErreur==0)
                        {
                            ennemis.Add(nextMonstre);
                            Console.WriteLine($"cuir : {ennemis[i].cuir}, endurance : {ennemis[i].endurance}, force : {ennemis[i].force}, nom : {ennemis[i].nom}, PO : {ennemis[i].piecesDOr}, posX : {ennemis[i].posX}, posY : {ennemis[i].posY}, pv : {ennemis[i].pv}, race : {ennemis[i].race}");
                            suivantMalPlace = false;
                        }
                        premierBienPlace = true;
                    }
                }
            }
            return ennemis.ToArray();
        }
    }
}
