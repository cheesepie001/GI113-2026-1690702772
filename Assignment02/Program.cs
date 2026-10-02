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
            Console.WriteLine($"Forge Diamond Ores ==> Diamond Ingots : {Forge}");
            Console.WriteLine($"Recycle Diamond Ingots ==> Diamond Ores : {Recycle}");
            Console.Write($"Choose menu : ");
            char.TryParse(Console.ReadLine(), out char choice);

            if (choice != Forge && choice != Recycle && choice != 'F' && choice != 'R')
            {
                Console.WriteLine();
                Console.WriteLine($"Invalid choice. Please choose either '{Forge}' or '{Recycle}'.");

            }

            if (choice == Forge || choice == 'F' || (choice != Forge && choice != Recycle))
            {
                Console.WriteLine();
                Console.WriteLine($"You choose Forge Diamond Ores ==> Diamond Ingots");
                Console.WriteLine($"How many diamond ores do you want to forge?");
                Console.Write($"Enter number of diamond ores : ");
                bool oresInput = int.TryParse(Console.ReadLine(), out int inputOres);

                if (oresInput && inputOres > 0)
                {

                    int ingots = inputOres * 2;
                    Console.WriteLine();
                    Console.WriteLine($"You have forged Diamond Ores to {ingots} Diamond Ingots.");
                }
                else if (!oresInput || inputOres <= 0)
                {
                    Console.WriteLine();
                    Console.WriteLine($"Invalid input. Please enter a positive number of diamond ores.");
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine($"Invalid choice. Please choose either '{Forge}' or '{Recycle}'.");


                }
            }


                if (choice == Recycle || choice == 'R')
                {
                    Console.WriteLine();
                    Console.WriteLine($"You choose Recycle Diamond Ingots ==> Diamond Ores");
                    Console.WriteLine($"How many diamond ingots do you want to recycle?");
                    Console.Write($"Enter number of diamond ingots : ");
                    bool ingotsInput = int.TryParse(Console.ReadLine(), out int inputIngots);

                    if (ingotsInput && inputIngots > 0)
                    {
                        float ores = inputIngots * 0.25f;
                        Console.WriteLine($"You have recycled Diamond Ingots to {ores} Diamond Ores.");
                    }
                    else if (!ingotsInput || inputIngots <= 0)
                    {
                        Console.WriteLine();
                        Console.WriteLine($"Invalid input. Please enter a positive number of diamond ingots.");
                    }

                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine($"Invalid choice. Please choose either '{Forge}' or '{Recycle}'.");


                    }
                }
            }
        }
    }



