/*
* Student ID : 1690700016
* Name       : Pranpriya Phetchuensakul
* Section    : 129A
* No.        : 10
* Course     : GI113 Computer Programming (GI)
*/


namespace Lab05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ===> BATTLE MAGE <=== ");
            Console.WriteLine("Hero vs. Monsters -- Fight Calculator ");

            // User input of hero stats
            Console.WriteLine("Hero HP: ");
            bool isHeroHp = int.TryParse(Console.ReadLine(), out int heroHp);
            Console.WriteLine("Hero ATK: ");
            bool isHeroAtk = int.TryParse(Console.ReadLine(), out int heroAtk);
            Console.WriteLine("Hero Defence: ");
            bool isHeroDef = int.TryParse(Console.ReadLine(), out int heroDef);

            //User input of monster stats
            Console.WriteLine("Monster HP: ");
            bool isMonsterHp = int.TryParse(Console.ReadLine(), out int monsterHp);
            Console.WriteLine("Monster ATK: ");
            bool isMonsterAtk = int.TryParse(Console.ReadLine(), out int monsterAtk);
            Console.WriteLine("Monster Defence: ");
            bool isMonsterDef = int.TryParse(Console.ReadLine(), out int monsterDef);

            // Check if all inputs are valid
            bool allHeroValid = isHeroHp && isHeroAtk && isHeroDef;
            bool allMonsterValid = isMonsterHp && isMonsterAtk && isMonsterDef;
            Console.WriteLine($"Stats Validation: Hero: {allHeroValid}, Monster: {allMonsterValid}");
            Console.WriteLine($"[HERO] HP: {heroHp}, ATK: {heroAtk}, DEF: {heroDef}");
            Console.WriteLine($"[MONSTER] HP: {monsterHp}, ATK: {monsterAtk}, DEF: {monsterDef}");

            // Before fighting: Hero drinks a potion (Compound Assignment)
            int potionHeal = 8;
            // 1. heroHp = heroHp + potionHeal;
            /*2.*/ heroHp += potionHeal; //แนะนำแบบนี้ คำนวณเหมือนกัน 1 = 1+2
            Console.WriteLine($"\nHero drinks a potion, Healing {potionHeal}. health is now {heroHp}.");

            // คำนวณ damage normal attack (Arithmetic + Math)
            int normalDamage = Math.Max(0, heroAtk - monsterDef);
            Console.WriteLine($"Normal Attack deal: {normalDamage} DMG");

            // คำนวณ power attack (Predence ลำดับคำนวณ คูณ ก่อนที่จะ ลบ)
            int powerDamage = Math.Max(0, (heroAtk * 2) - monsterDef); // เรียงลำดับ * มาก่อน - ไม่จำเป็นต้องมี ( )
            Console.WriteLine($"Power Attack deal: {powerDamage} DMG");

            //คำนวณ monster attack
            int counterDamage = Math.Max(0, monsterAtk - heroDef);
            Console.WriteLine($"Monster Counter Attack deal: {counterDamage} DMG");

            // คำนวณ Cri Chance
            Random rng = new Random();
            int roll = rng.Next(1, 101); // Random Cri 1-100
            bool isCrit = roll <= 10; // 10%
            int critDamage = normalDamage + Convert.ToInt32(isCrit) * normalDamage; // โอกาส 10% ติดคริ เลขได้1 ไม่ติดได้ 0
            Console.WriteLine($"Critial hit roll: {roll} (critical: {isCrit})");
            Console.WriteLine($"Normal Attack would deal Critical: {critDamage} DMG");
        }
    }
}
