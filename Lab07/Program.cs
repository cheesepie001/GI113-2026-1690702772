// ชื่อ - นามสกุล: นายปรมัตถ์ เชื้อเมืองพาน
// Section: 129C
// รหัสนักศึกษา: 1690702772
// เลขที่: 23

namespace Lab07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  int command = 1;

            //switch (command)
            //{
            // case 1 :
            //ใส่โค้ดที่ต้องการ
            //  break;
            // case 2 :
            //ใส่โค้ดที่ต้องการ
            //  break;
            // default:
            // Console.WriteLine("Invalid command");
            //ถ้าไม่ตรงซัก case จะทำงานแทน
            // break;


            const int MonsterHp = 10;

            Console.Write("Monster Defense: ");
            int.TryParse(Console.ReadLine(), out int monsterDefense);
            Console.WriteLine($"A Slime appears! HP {MonsterHp}, DEF {monsterDefense}");

            Console.WriteLine("=== BATTLE MENU ===");
            Console.WriteLine("1) Attack");
            Console.WriteLine("2) Fire Magic");
            Console.WriteLine("3) Defend");
            Console.WriteLine("4) Run");
            Console.Write("Choose (1-4): ");
            int.TryParse(Console.ReadLine(), out int command);

            switch (command)
            {
                case 1:
                    Console.WriteLine("Hero swings the sword!");
                    break;
                case 2:
                    Console.WriteLine("Hero casts Fire!");
                    break;
                case 3:
                    Console.WriteLine("Hero raises the shield.");
                    break;
                case 4:
                    Console.WriteLine("Hero looks for a way out...");
                    break;
                default:
                    Console.WriteLine("Hero hesitates. Invalid command!");
                    break;
            }

            int power = command switch
            {
                1 => 12,
                2 => 18,
                _ => 0
            };
            int damage = Math.Max(0, power - monsterDefense);
            Console.WriteLine($"Damage: {damage}");

            string rating = damage switch
            {
                >= 12 => "Critical hit!",
                >= 5 => "Solid hit.",
                > 0 => "Scratch.",
                _ => "No damage."
            };
            Console.WriteLine($"Rating: {rating}");

            string monsterStatus = damage >= MonsterHp ? "DEFEATED" : "still standing";
            Console.WriteLine($"Slime: {monsterStatus}");

            Console.Write("Really run away? (y/n): ");
            string answer = Console.ReadLine();

            switch (answer)
            {
                case "y":
                case "Y":
                    Console.WriteLine("You escaped!");
                    break;
                case "n":
                case "N":
                    Console.WriteLine("You stay and fight.");
                    break;
                default:
                    Console.WriteLine("Please type y or n.");
                    break;
            }



            // Part B
            const int MonsterHp1 = 10;

            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Monster Defense: ");
            int.TryParse(Console.ReadLine(), out int monsterDefense1);
            Console.WriteLine($"A Slime appears! HP {MonsterHp1}, DEF {monsterDefense1}");

            Console.WriteLine("=== BATTLE MENU ===");
            Console.WriteLine("1) Attack");
            Console.WriteLine("2) Fire Magic");
            Console.WriteLine("3) Defend");
            Console.WriteLine("4) Run");
            Console.WriteLine("5) Thunder Magic");
            Console.Write("Choose (1-5): ");
            int.TryParse(Console.ReadLine(), out int command1);

            switch (command1)
            {
                case 1:
                    Console.WriteLine("Hero swings the sword!");
                    break;
                case 2:
                    Console.WriteLine("Hero casts Fire!");
                    break;
                case 3:
                    Console.WriteLine("Hero raises the shield.");
                    break;
                case 4:
                    Console.WriteLine("Hero looks for a way out...");
                    break;
                case 5:
                        Console.WriteLine("Hero casts Thunder!");
                    break;
                default:
                    Console.WriteLine("Hero hesitates. Invalid command!");
                    break;
            }

            int power1 = command switch
            {
                1 => 12,
                2 => 18,
                5 => 20,
                _ => 0
            };
            int damage1 = Math.Max(0, power - monsterDefense);
            Console.WriteLine($"Damage: {damage}");

            string rating1 = damage switch
            {
                >= 12 => "Critical hit!",
                >= 5 => "Solid hit.",
                > 0 => "Scratch.",
                _ => "No damage."
            };
            Console.WriteLine($"Rating: {rating}");

            string monsterStatus1 = damage >= MonsterHp ? "DEFEATED" : "still standing";
            Console.WriteLine($"Slime: {monsterStatus}");

            Console.Write("Really run away? (y/n): ");
            string answer1 = Console.ReadLine();

            switch (answer1)
            {
                case "y":
                case "Y":
                    Console.WriteLine("You escaped!");
                    break;
                case "n":
                case "N":
                    Console.WriteLine("You stay and fight.");
                    break;
                default:
                    Console.WriteLine("Please type y or n.");
                    break;
            }

        }
        }
    }
    

