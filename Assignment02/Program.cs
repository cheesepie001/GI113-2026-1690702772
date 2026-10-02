// ชื่อ - นามสกุล: นายปรมัตถ์ เชื้อเมืองพาน
// Section: 129C
// รหัสนักศึกษา: 1690702772
// เลขที่: 23

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
            Console.WriteLine($"*******************************************************************************\r\n* .88888.           dP       dP                                               *\r\n*d8'   `88          88       88                                               *\r\n*88        .d8888b. 88 .d888b88 .d8888b. 88d888b.                             *\r\n*88   YP88 88'  `88 88 88'  `88 88ooood8 88'  `88                             *\r\n*Y8.   .88 88.  .88 88 88.  .88 88.  ... 88    88                             *\r\n* `88888'  `88888P' dP `88888P8 `88888P' dP    dP                             *\r\n*ooooooooooooooooooooooooooooooooooooooooooooooooo                            *\r\n*                                                                             *\r\n* 888888ba                    dP                           oo   dP   dP       *\r\n* 88    `8b                   88                                88   88       *\r\n*a88aaaa8P' .d8888b. .d8888b. 88  .dP  .d8888b. 88d8b.d8b. dP d8888P 88d888b. *\r\n* 88   `8b. 88'  `88 88'  `\"\" 88888\"   Y8ooooo. 88'`88'`88 88   88   88'  `88 *\r\n* 88    .88 88.  .88 88.  ... 88  `8b.       88 88  88  88 88   88   88    88 *\r\n* 88888888P `88888P8 `88888P' dP   `YP `88888P' dP  dP  dP dP   dP   dP    dP *\r\n*ooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooo*\r\n*******************************************************************************");
            Console.WriteLine();
            Console.WriteLine($"What are you looking to do today?");
            Console.WriteLine();

            char Forge = 'f';
            char Recycle = 'r';
            Console.WriteLine($"Forge Ores ==> Ingots : {Forge}");
            Console.WriteLine($"Recycle Ingots ==> Ores : {Recycle}");
            Console.Write($"Choose menu : ");
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

                    if (userinput4 != false && forgeAmount > 0 )
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

                    if (userinput5 != false && recycleAmount > 0)
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

                    if (userinput6 != false && forgeAmount > 0)
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

                    if (userinput7 != false && recycleAmount > 0)
                    {
                        double recycleOres = recycleAmount * 1.3;
                        Console.WriteLine($"You have successfully recycled {recycleOres} Ores!");
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number.");
                    }


                }
                else if (oreType != demonOre && oreType != angleOre)
                {
                    Console.WriteLine();
                    Console.WriteLine("Invalid input. Please enter 1 for Demonite or 2 for Anglelite.");
                }


            }
            
        }
    }
}

