/*
 * Student ID : 1690700016
 * Name       : Pranpriya Phetchuensakul
 * Section    : 129A
 * No.        :
 * Course     : GI113 Computer Programming (GI)
 */

using static System.Net.Mime.MediaTypeNames;

namespace Lab03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int MaxLevel = 10;

            var bossName = "Kirin";    //ต้องประกาศด้วย var ห้ามเขียน string ตรง ๆ
            var rank = "S";            //ต้องประกาศด้วย var ห้ามเขียน char ตรง ๆ
            int level = 7;
            int maxHp = 240;
            int currentHp = 115;       //คำตั้งต้นของ Lab นี้คือ HP "หลังโดนโจมตี" จาก Lab 2 แล้ว ไม่ใช่ 175
            float attackPower = 42.5f;
            double critMultiplier = 1.75;
            bool isBoss = true;
            // output แสดงค่าตัวแปร
            Console.WriteLine("===== KIRIN SAVE CONVERTER =====");
            Console.WriteLine($"Name : {bossName}\nRank : {rank}\nLevel : {level} / {MaxLevel}\nHP : {currentHp} / {maxHp}" +
                $"\nAttack Power : {attackPower}\nCritical Multiplier : {critMultiplier}\nIs Boss : {isBoss}");

            // ทำ Implicit int -> double
            Console.WriteLine("\n----- Implicit Conversion: HP as double -----");
            double currentHpDouble = currentHp;    // Int ->> Double แปลงแบบไม่ cast ใส่คำได้เลย
            Console.WriteLine($"HP (double): {currentHpDouble}");

            // ทำ Implicit หลังจากคำนวณเปอร์เซ็นต์ ที่ผลลัพธ์มีทศนิยม
            Console.WriteLine("\n----- Exact HP Percent (no integer truncation) -----");
            double hpPercent = currentHpDouble * 100 / maxHp;    //int หาร int จากนั้นแปลงผลลัพธ์การคำนวณเป็น double เพื่อเก็บทศนิยม
            Console.WriteLine($"HP Percent (exact): {hpPercent}%");

            // ทำ Explicit โดยการ Casting (float) AttackPower ->> int
            Console.WriteLine("\n----- Explicit Cast: Attack Power -> Display Int -----");
            int attackInt = (int)attackPower;    // แปลงข้อมูลโดยการ Cast syntax: (ชนิดที่ต้องการแปลง)ชื่อตัวแปรที่อยากแปลง
            Console.WriteLine($"Attack Power (int cast): {attackInt}");

            Console.WriteLine("\n----- Cast vs Convert: Crit Multiplier -----");
            int critCast = (int)critMultiplier;
            int critConvert = Convert.ToInt32(critMultiplier);
            Console.WriteLine($"Crit Multiplier (int cast): {critCast}");
            Console.WriteLine($"Crit Multiplier (Convert rounded): {critConvert}");
        }
    }
}