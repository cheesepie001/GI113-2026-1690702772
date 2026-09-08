namespace Lab04
{
    // ชื่อ - นามสกุล: นายปรมัตถ์ เชื้อเมืองพาน
    // Section: 129C
    // รหัสนักศึกษา: 1690702772
    // เลขที่: 23


    internal class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("+---------------+");
            // Console.WriteLine("| New Adventure |");
            //  Console.WriteLine("+---------------+");

            //  Console.WriteLine("Name your Hero:");
            // Console.Write(">>> ");
            // string playerName = Console.ReadLine();

            //  Console.WriteLine($"Welcome, {playerName} your journey begins..");

            // Console.WriteLine("+------------------+");
            // Console.WriteLine("| DIFFCULTY SELECT |");
            // Console.WriteLine("+------------------+");
            // Console.WriteLine("choose diffculty 1-3: ");
            // int difficulty = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine($"\n\"Diffculty {difficulty} selected. Good luck out there..\"");

            // Console.WriteLine("+------------------+");
            // Console.WriteLine("|     ITEM SHOP    |");
            // Console.WriteLine("+------------------+");
            //  Console.WriteLine("How Many potions? ");
            // bool isValid = int.TryParse(Console.ReadLine(), out int quantity);
            // Console.WriteLine($"Valid input: {isValid}");
            // Console.WriteLine($"Quantity: {quantity}");


            //Console.WriteLine("+--------------------+");
            // Console.WriteLine("| CHARACTOR CREATION |");
            // Console.WriteLine("+--------------------+");
            // Console.WriteLine($"{playerName}");
            // string charName = Console.ReadLine();
            //  Console.WriteLine("Choose a class (1-3): ");
            // bool classOk = int.TryParse(Console.ReadLine(), out int classNum);
            // Console.WriteLine("Starting luck (o.0-10.0): ");
            // bool luckOk = double.TryParse(Console.ReadLine(), out double Luck);
            // Console.WriteLine($"{charName} the Class-{classNum} adventurer enters the dungeon. Luck: {luck}");

            Console.WriteLine("+------------------------------+");
            Console.WriteLine("|      CHARACTER CREATION       |");
            Console.WriteLine("+------------------------------+");
            Console.Write("Name your character: ");
            string charName = Console.ReadLine();
            Console.Write("Choose a class (1-3): ");
            bool classOk = int.TryParse(Console.ReadLine(), out int classNum);
            Console.Write("Starting luck (0.0-10.0): ");
            bool luckOk = double.TryParse(Console.ReadLine(), out double luck);
            Console.WriteLine($"{charName} the Class-{classNum} adventurer enters the dungeon. Luck: {luck}");

            Console.WriteLine("+------------------------------+");
            Console.WriteLine("|           ITEM SHOP           |");
            Console.WriteLine("+------------------------------+");
            Console.Write("How many potions? ");
            bool quantityOk = int.TryParse(Console.ReadLine(), out int quantity);
            Console.WriteLine($"Valid input: {quantityOk}");
            Console.WriteLine($"Quantity: {quantity}");

            Console.WriteLine("+------------------------------+");
            Console.WriteLine("|          SET VOLUME           |");
            Console.WriteLine("+------------------------------+");
            Console.Write("Set music volume (0.0-1.0): ");
            bool volumeOk = double.TryParse(Console.ReadLine(), out double volume);
            Console.WriteLine($"Valid input: {volumeOk}");
            Console.WriteLine($"Volume: {volume}");

            Console.WriteLine("+------------------------------+");
            Console.WriteLine("|         NEW SAVE FILE         |");
            Console.WriteLine("+------------------------------+");
            Console.Write("Enter save name: ");
            string saveName = Console.ReadLine();
            Console.Write("Choose save slot (1-3): ");
            bool slotOk = int.TryParse(Console.ReadLine(), out int slot);
            Console.WriteLine($"Save name: {saveName}");
            Console.WriteLine($"Valid input: {slotOk}");
            Console.WriteLine($"Slot: {slot}");
        }
    }
}
