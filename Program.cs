using heroes_VS_monster.models;

namespace heroes_VS_monster
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Shorewood");
            Nain personnage = new Nain("murgol");
            Console.WriteLine($"nom : {personnage.Nom}, force : {personnage.Force}, Modificateur de force : {personnage.ModForce}, Bonus de Force : {personnage.BonusForce}, Endurance : {personnage.Endurance}, Modificateur d'endurance : {personnage.ModEndurance}, Bonus d'endurance : {personnage.BonusEndurance}, PV : {personnage.Pv}");
        }
    }
}