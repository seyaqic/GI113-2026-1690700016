/*
* Student ID : 1690700016
* Name       : Pranpriya Phetchuensakul
* Section    : 129A
* No.        : 10
* Course     : GI113 Computer Programming (GI)
*/


namespace Lab04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("+_+_+ NEW ADVENTURE +_+_+"); //Print ธรรมดา Title
            //Console.WriteLine("Name your hero: "); // WriteLine พิมพ์บรรทัดใหม่ Write พิมพ์ต่อบรรทัดเดิม
            //string playerName = Console.ReadLine(); // เมื่อผู้เล่นกรอกชื่อ จากนั้นชื่อจะเข้าไปเก็บใน playerName
            //Console.WriteLine($"\n\"Welcome, {playerName}, Your journey begins now...\"");
            //Console.Write("Choose difficulty (1-3): ");
            //string choice = Console.ReadLine();
            //int difficulty = Convert.ToInt32(Console.ReadLine()); //รับ input และเก็บใส่ choice
            //Console.WriteLine($"Difficulty set to {difficulty}.");

            //Console.WriteLine("+------------------------------+");
            //Console.WriteLine("|           RATE THIS LEVEL      |");
            //Console.WriteLine("+------------------------------+");
            //Console.WriteLine("Rate this level (0.0 - 5.0): ");
            //bool isValid = double.TryParse(Console.ReadLine(), out double rating);
            //Console.WriteLine($">> Valid input: {isValid}");
            //Console.WriteLine($">> Rating: {rating}");

            Console.WriteLine("-------------------------------+");
            Console.WriteLine("|        CHARACTER CREATION      |");
            Console.WriteLine("-------------------------------+");
            Console.WriteLine("Name your character: ");
            string charName = Console.ReadLine();
            Console.WriteLine("Choose your class (1-3): ");
            bool classValid = int.TryParse(Console.ReadLine(), out int classNum);
            Console.WriteLine("Starting luck (0.0-10.0): ");
            bool luckValid = double.TryParse(Console.ReadLine(), out double luckNum);
            Console.WriteLine($"\n{charName} the Class-{classNum} adventurer enters the dungeon. Luck: {luckNum}");

            Console.WriteLine("+------------------------------+");
            Console.WriteLine("|           ITEM SHOP            |");
            Console.WriteLine("+------------------------------+");
            Console.WriteLine("How many potions? ");
            bool isValid = int.TryParse(Console.ReadLine(), out int quantity);
            Console.WriteLine($">> Valid input: {isValid}");
            Console.WriteLine($">> Quantity: {quantity}");

            Console.WriteLine("+------------------------------+");
            Console.WriteLine("|            SET VOLUME          |");
            Console.WriteLine("+------------------------------+");
            Console.WriteLine("Set music volume (0.0 - 1.0): ");
            bool volumeValid = double.TryParse(Console.ReadLine(), out double volume);
            Console.WriteLine($">> Valid input: {volumeValid}");
            Console.WriteLine($">> Volume: {volume}");

            Console.WriteLine("+------------------------------+");
            Console.WriteLine("|         NEW SAVE FILE         |");
            Console.WriteLine("+------------------------------+");
            Console.WriteLine("Enter save name: ");
            string saveName = Console.ReadLine();
            Console.WriteLine("Choose save slot (1-3): ");
            bool slotValid = int.TryParse(Console.ReadLine(), out int slot);
            Console.WriteLine($"Save name: {saveName}");
            Console.WriteLine($">> Valid input: {slotValid}");
            Console.WriteLine($">> Slot: {slot}");
        }
    }
}
