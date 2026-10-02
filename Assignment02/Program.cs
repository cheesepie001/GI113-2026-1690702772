namespace Assignment02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"================== Forge! ===================");
            Console.WriteLine($"|     Welcome to the Golden Backsmith       |");
            Console.WriteLine($"=============================================");
            Console.WriteLine();
            Console.WriteLine($"What are you looking to do today?");
            Console.WriteLine();

            char Forge = 'f';
            char Recycle = 'r';
            Console.WriteLine($"Forge Ores ==> Ingots : {Forge}");
            Console.WriteLine($"Recycle Ingots ==> Ores : {Recycle}");
            Console.Write($"Choose f or r: ");
            bool userinput = char.TryParse(Console.ReadLine(), out char choice);

            if (choice == Forge || choice == Recycle)
            {


                int demonOre = 1;
                int angleOre = 2;

                Console.WriteLine();
                Console.WriteLine($"Demonite : {demonOre}");
                Console.WriteLine($"Anglelite : {angleOre}");
                Console.Write($"Which type of ore/ingot would you like to forge/recycle? : ");
                bool userinput2 = int.TryParse(Console.ReadLine(), out int oreType);

                if (oreType == demonOre && choice == Forge)
                {
                    Console.WriteLine();
                    Console.Write($"How many ores would you like to forge? : ");
                    bool userinput4 = int.TryParse(Console.ReadLine(), out int forgeAmount);

                    if (userinput4 != false)
                    {
                        double demonIngots = forgeAmount * 0.5;
                        Console.WriteLine($"You have successfully forged {demonIngots} Demon Ingots!");
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number.");
                    }
                }
                else if (oreType == demonOre && choice == Recycle)
                {
                    Console.WriteLine();
                    Console.Write($"How many ingots would you like to recycle? : ");
                    bool userinput5 = int.TryParse(Console.ReadLine(), out int recycleAmount);
                    if (userinput5 != false)
                    {
                        double recycleOres = recycleAmount * 1.3;
                        Console.WriteLine($"You have successfully recycled {recycleOres} Ores!");
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number.");
                    }
                }
                //else
                //{
                    //Console.WriteLine();
                    //Console.WriteLine("Invalid input. Please enter 1 for Demonite or 2 for Anglelite.");
                //}
                if (oreType == angleOre && choice == Forge)
                {
                    Console.WriteLine();
                    Console.Write($"How many ores would you like to forge? : ");
                    bool userinput6 = int.TryParse(Console.ReadLine(), out int forgeAmount);

                    if (userinput6 != false)
                    {
                        double angleIngots = forgeAmount * 0.5;
                        Console.WriteLine($"You have successfully forged {angleIngots} Angle Ingots!");
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number.");
                    }
                }
                else if (oreType == angleOre && choice == Recycle)
                {
                    Console.WriteLine();
                    Console.Write($"How many ingots would you like to recycle? : ");
                    bool userinput7 = int.TryParse(Console.ReadLine(), out int recycleAmount);
                    if (userinput7 != false)
                    {
                        double recycleOres = recycleAmount * 1.3;
                        Console.WriteLine($"You have successfully recycled {recycleOres} Ores!");
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number.");
                    }


                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Invalid input. Please enter 1 for Demonite or 2 for Anglelite.");
                }


            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Invalid input. Please enter f for forge or r for recycle.");
            }
        }
    }
}

