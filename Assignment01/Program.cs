/*
 * Student ID : 1690700016
 * Name       : Pranpriya Phetchuensakul
 * Section    : 129A
 * No.        : 10
 * Course     : GI113 Computer Programming (GI)
 */


namespace Assignment01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string GameTitle = "VALORANT AGENT PROFILE"; 

            var agentName = "Jett";
            var agentRole = "Duelist";

            string weaponName = "Vandal";
            char agentRank = 'A';
            int playerLevel = 25;
            float headshotRate = 32.75f;
            double combatScore = 87.65432;
            bool isUltimateReady = true;

            Console.WriteLine("+------------------------------+");
            Console.WriteLine($"|    {GameTitle}    |");
            Console.WriteLine("+------------------------------+");
            Console.WriteLine($"Agent Name  : {agentName}");
            Console.WriteLine($"Agent Role  : {agentRole}");
            Console.WriteLine($"Agent Rank  : {agentRank}");
            Console.WriteLine($"Selected Weapon : {weaponName}");
            Console.WriteLine($"Player Level   : {playerLevel}");
            Console.WriteLine($"Headshot Rate  : {headshotRate}%");
            Console.WriteLine($"Combat Score   : {combatScore}");
            Console.WriteLine($"Ultimate Ready : {isUltimateReady}");

            double levelAsDouble = playerLevel;

            Console.WriteLine();
            Console.WriteLine("|     AGENT DATA CONVERSION     |");

            Console.WriteLine($"Level as double (implicit): {levelAsDouble}");

            int scoreTruncated = (int)combatScore;
            int scoreRounded = Convert.ToInt32(combatScore);
            Console.WriteLine($"Combat Score cast (truncates)  : {scoreTruncated}");
            Console.WriteLine($"Combat Score Convert (rounds)  : {scoreRounded}");
        }
    }
}
