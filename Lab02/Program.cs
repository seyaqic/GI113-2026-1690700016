/*
 * Student ID : 1690700016
 * Name       : Pranpriya Phetchuensakul
 * Section    : 129A
 * No.        :
 * Course     : GI113 Computer Programming (GI)
 */

using static System.Net.Mime.MediaTypeNames;

namespace Lab02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string bossName = "Kirin";
            char rank = 'S';
            int level = 7;
            int maxHp = 240;
            int currentHp = 175;
            float attackPower = 42.5f;
            double critMultiplier = 1.75;
            bool isBoss = true;

            Console.WriteLine("===== BOSS STATUS: INITIAL =====");
            Console.WriteLine($"Name: {bossName}");
            Console.WriteLine($"Rank: {rank}");
            Console.WriteLine($"Level: {level}");
            Console.WriteLine($"HP: {currentHp}/{maxHp}");
            Console.WriteLine($"Attack Power: {attackPower}");
            Console.WriteLine($"Crit Multiplier: {critMultiplier}");
            Console.WriteLine($"Is Boss: {isBoss}");
            Console.WriteLine();

            int hpPercent = currentHp * 100 / maxHp;
            Console.WriteLine($"HP Percent: {hpPercent}%");
            Console.WriteLine();
            Console.WriteLine("Kirin takes 60 damage!");
            Console.WriteLine();

            int damage = 60;
            int newHp = currentHp - damage;
            int newHpPercent = newHp * 100 / maxHp;
            Console.WriteLine($"===== BOSS STATUS: AFTER DAMAGE =====");
            Console.WriteLine($"HP; {newHp} / {maxHp}");
            Console.WriteLine($"HP Percent: {newHpPercent}%");

            string knightName = "Aon";
            char knightRank = 'A';
            int knightLevel = 10;
            int knightMaxHp = 300;
            float knightAttackPower = 55.5f;
            double knightCritMultiplier = 1.50;
            bool knightIsAlive = true;

            Console.WriteLine("===== CHARACTER 1 =====");
            Console.WriteLine($"Name: {knightName}");
            Console.WriteLine($"Rank: {knightRank}");
            Console.WriteLine($"Level: {knightLevel}");
            Console.WriteLine($"Max HP: {knightMaxHp}");
            Console.WriteLine($"Attack Power: {knightAttackPower}");
            Console.WriteLine($"Crit Multiplier: {knightCritMultiplier}");
            Console.WriteLine($"Is Alive: {knightIsAlive}");
            Console.WriteLine();
            
            string mageName = "Marn";
            char mageRank = 'B';
            int mageLevel = 8;
            int mageMaxHp = 180;
            float mageAttackPower = 35.5f;
            double mageCritMultiplier = 2.00;
            bool mageIsAlive = true;

            Console.WriteLine("===== CHARACTER 2 =====");
            Console.WriteLine($"Name: {mageName}");
            Console.WriteLine($"Rank: {mageRank}");
            Console.WriteLine($"Level: {mageLevel}");
            Console.WriteLine($"Max HP: {mageMaxHp}");
            Console.WriteLine($"Attack Power: {mageAttackPower}");
            Console.WriteLine($"Crit Multiplier: {mageCritMultiplier}");
            Console.WriteLine($"Is Alive: {mageIsAlive}");
            Console.WriteLine();

            string archerName = "Ball";
            char archerRank = 'A';
            int archerLevel = 9;
            int archerMaxHp = 220;
            float archerAttackPower = 48.5f;
            double archerCritMultiplier = 1.75;
            bool archerIsAlive = true;

            Console.WriteLine("===== CHARACTER 3 =====");
            Console.WriteLine($"Name: {archerName}");
            Console.WriteLine($"Rank: {archerRank}");
            Console.WriteLine($"Level: {archerLevel}");
            Console.WriteLine($"Max HP: {archerMaxHp}");
            Console.WriteLine($"Attack Power: {archerAttackPower}");
            Console.WriteLine($"Crit Multiplier: {archerCritMultiplier}");
            Console.WriteLine($"Is Alive: {archerIsAlive}");
            Console.WriteLine();

            string healerName = "Earth";
            char healerRank = 'C';
            int healerLevel = 7;
            int healerMaxHp = 160;
            float healerAttackPower = 25.5f;
            double healerCritMultiplier = 1.25;
            bool healerIsAlive = true;

            Console.WriteLine("===== CHARACTER 4 =====");
            Console.WriteLine($"Name: {healerName}");
            Console.WriteLine($"Rank: {healerRank}");
            Console.WriteLine($"Level: {healerLevel}");
            Console.WriteLine($"Max HP: {healerMaxHp}");
            Console.WriteLine($"Attack Power: {healerAttackPower}");
            Console.WriteLine($"Crit Multiplier: {healerCritMultiplier}");
            Console.WriteLine($"Is Alive: {healerIsAlive}");
            Console.WriteLine();
        }
    }
}