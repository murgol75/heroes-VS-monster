using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heroes_VS_monster.Utils
{
    internal class Name_Generator
    {
        private static readonly string[] wolfNames = { "Jethro", "Ralph", "Beacon", "Buck", "Shepherd", "Dust", "Killer", "Chewy", "Echo", "Splinter", "Rover", "Dane", "Havoc", "Chase", "Bud", "Brawn", "Dash", "Blitzen", "Dawn", "Acadia", "Ivory", "Aurora", "Rogue", "Precious", "Myth", "Indigo", "Juno", "Chronis", "Alexis", "Kenya", "Pandora", "Beauty", "Myth", "Coral", "Maple", "Codex" };
        private static readonly string[] orcNames = { "Zivu Thunderbrass", "Kekzorm Hellbones", "Gahlmekk Grimchest", "Gorralzunk Dreamwatch", "Grornakar Sourslayer", "Sulgos Skulltooth", "Thrungudar Rockflesh", "Hargur Wardeath", "Trerl Starkfeast", "Gultech Firesteel", "Rangumm Sharpmask", "Hirnzadomm Wildedge", "Thigech Madmane", "Mige'gald Quickcleaver", "Gretturl Thunderhammer", "Hathagdorm Brightbattle", "Gornuch Burningchampion", "Rink Stonechewer", "Isukk Wildblade", "Brodath Firemight", "Kumgu Rapidslayer", "Tewdum Wrathcleaver", "Zehka Laughingbinder", "Masazlir Bittermarch", "Zestrontim Deadseeker", "Ehne Wrathtwist", "Arne Wrathmight", "Sadvaste Stonewind", "Tomdu Burningmight", "Setraszor Wolfmask", "Komtu Frostmarch", "Farnir Deadmask", "Momzit Wildsnarl", "Rihki Brightslayer", "Fehkethy Stormlock", "Tosi Dualkill", "Zula Keenmask", "Gengu Lonehunter", "Gose Keenchest", "Erurdes Twintaker" };
        private static readonly string[] dragonNames = { "Brogon, Protecteur Du Ciel", "Gronod, Le Géant", "Chodeon, Le Maladroit", "Oimmaiss, Le Prudent", "Rumbig, Le Titan", "Nelzrar, Le Lent", "Nombyn, Protecteur Du Ciel", "Tozisdeir, Maître De Glace", "Chelbocrirth, Seigneur Des Verts", "Geomerra, Le Silencieux", "Oirruss, L'Élu", "Riervass, Le Silencieux", "Roirrurth, Le Fou", "Coseo, Le Maigre", "Ulled, Le Fou", "Ceoghu, Le Bruyant", "Xondrien, Maître Du Feu", "Choidreintarth, Le Grincheux", "Boirvassion, Le Titan", "Aervaintiass, Tueur De Lapins", "Sonneor, Champion Du Ciel", "Fravnath, La Rédemptrice", "Qiormai, La Juvénile", "Aimmoth, Mangeur De Tous", "Yrmol, La Silencieuse", "Fellul, Mangeur De Tous", "Vyrsyrth, La Juvénile", "Heghintot, La Rapide", "Vyrmenelth, Protectrice De La Vie", "Gethyre, Dame Des Bleus" };

        private static readonly Random random = new Random();
        
        
        public static string GenerateRandomName(string raceDuMonstre)
        {
            string[] listeDeNom;
            switch (raceDuMonstre)
            {
                case "loup":
                    listeDeNom = wolfNames;
                    break;
                case "orque":
                    listeDeNom = orcNames;
                    break;
                default:
                    listeDeNom = dragonNames;
                    break;

            }
            string Name = listeDeNom[random.Next(listeDeNom.Length)];
            return $"\"{Name}\"";
        }
    }
}
