using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heroes_VS_monster
{
    internal class Name_Generator
    {
        private static readonly string[] WolfNames = { "John", "Jane", "Michael", "Emily", "William", "Olivia", "Wolfen" };
        
        private static readonly Random random = new Random();

        public static string GenerateRandomName()
        {
            string Name = WolfNames[random.Next(WolfNames.Length)];
            return Name;
        }
    }
}
