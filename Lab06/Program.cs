// ชื่อ - นามสกุล: นายปรมัตถ์ เชื้อเมืองพาน
// Section: 129C
// รหัสนักศึกษา: 1690702772
// เลขที่: 23

namespace Lab06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int lives = 0;

            //if (true)
            // {

            // }

            // if (lives <= 0) // ใส่เงื่อนไขที่ต้องการตรวจสอบ
            //{
            // โค้ดที่จะทำงานเมื่อเงื่อนไขเป็นจริง
            // Console.WriteLine("Game Over!");
            // }
            // else
            // {
            //     Console.WriteLine("Keep Fighting!");
            // }

            // ถ้าเป็นเท็จจะข้ามมาบรรทัดนี้ทันที
            // Console.WriteLine("Continue Code!");

            //  bool hasKey = true;
            //int level = 12;
            // Console.Write("Your level 1-99: ");
            // bool isValidInput = int.TryParse(Console.ReadLine(), out int level);


            // if (!isValidInput || level < 1 || level > 99)
            //  {
            //    Console.WriteLine("Invalid input.");
            //  }
            // else if (level >= 10 && hasKey )
            //  {
            //     Console.WriteLine("Boss floor unlocked.");
            //  }
            //  else if (level >= 5)
            //  {
            //    if (hasKey == true)
            //   {
            //     Console.WriteLine("The door opens.");
            //   }
            //  else
            //  {
            //      Console.WriteLine("The door stays shut find a key.");
            //  }
            //  }
            // else
            // {
            //     Console.WriteLine("The door stays shut.");
            //  }

            //  bool isPosioned = true;
            //  if (isPosioned == true)
            //  {
            //     Console.WriteLine("You are poisoned!");
            // }
            // else if (isPosioned == false)
            //  {
            //     Console.WriteLine("You are safe.");
            int heroHp = 100;
            int monHp = 100;
            int heroAtk = 20;
            int monAtk = 15;
            int heroSkillheal = 10;
            int heroSkillatk = 40;

            Console.WriteLine("====Welcome to Simmulate Battle Field====");
            Console.WriteLine("====Battle begins!====");
            Console.WriteLine("Hero vs Monster");
            Console.WriteLine();
            Console.WriteLine("1. Attack");
            Console.WriteLine("2. Use Skill");
            Console.WriteLine("3. Heal");
            Console.WriteLine();
            Console.Write("Choose your action 1-3: ");

            bool userInput = int.TryParse(Console.ReadLine(), out int action);

            if (!userInput || action < 1 || action > 3)
            {
                if (userInput || action < 1 || action > 3)
                {
                    Console.WriteLine("Invalid input. Please choose a valid action.");
                }
                else
                {
                    Console.WriteLine(" Please choose a number 1 2 or 3");
                }
            }
            else if (action == 1)
            {
                monHp -= heroAtk;
                Console.WriteLine($"Hero attacks! Monster takes {heroAtk} damage. Monster HP: {monHp}");
            }
            else if (action == 2)
            {
                monHp -= heroSkillatk;
                Console.WriteLine($"Hero uses skill! Monster takes {heroSkillatk} damage. Monster HP: {monHp}");
            }
            else if (action == 3)
            {
                heroHp += heroSkillheal;
                Console.WriteLine($"Hero heals! Hero gains {heroSkillheal} HP. Hero HP: {heroHp}");
            }
            Console.WriteLine();
            Console.WriteLine("==============================================");
            Console.WriteLine("Monster Turn");
            Console.WriteLine($"Hero HP: {heroHp}");
            heroHp -= monAtk;
            Console.WriteLine($"Monster attacked you: {heroHp}");
            Console.WriteLine("==============================================");

            Console.WriteLine();
            Console.WriteLine("1. Attack");
            Console.WriteLine("2. Use Skill");
            Console.WriteLine("3. Heal");
            Console.WriteLine();
            Console.Write("Choose your action 1-3: ");

            bool userInput2 = int.TryParse(Console.ReadLine(), out int action2);

            if (!userInput2 || action2 < 1 || action2 > 3)
            {
                if (userInput2 || action2 < 1 || action2 > 3)
                {
                    Console.WriteLine("Invalid input. Please choose a valid action.");
                }
                else
                {
                    Console.WriteLine(" Please choose a number 1 2 or 3");
                }
            }
            else if (action2 == 1)
            {
                monHp -= heroAtk;
                Console.WriteLine($"Hero attacks! Monster takes {heroAtk} damage. Monster HP: {monHp}");
            }
            else if (action2 == 2)
            {
                monHp -= heroSkillatk;
                Console.WriteLine($"Hero uses skill! Monster takes {heroSkillatk} damage. Monster HP: {monHp}");
            }
            else if (action2 == 3)
            {
                heroHp += heroSkillheal;
                Console.WriteLine($"Hero heals! Hero gains {heroSkillheal} HP. Hero HP: {heroHp}");

            }
            if (monHp <= 0)
            {
                Console.WriteLine();
                Console.WriteLine("==============================================");
                Console.WriteLine("Monster is defeated! You win!");
                Console.WriteLine("==============================================");
            }
            else if (heroHp <= 0)
            {
                Console.WriteLine();
                Console.WriteLine("==============================================");
                Console.WriteLine("Game Over!");
                Console.WriteLine("==============================================");
            }
            Console.WriteLine();
            Console.WriteLine("==============================================");
            Console.WriteLine("Monster Turn");
            Console.WriteLine($"Hero HP: {heroHp}");
            heroHp -= monAtk;
            Console.WriteLine($"Monster attacked you: {heroHp}");
            Console.WriteLine("==============================================");

            Console.WriteLine();
            Console.WriteLine("1. Attack");
            Console.WriteLine("2. Use Skill");
            Console.WriteLine("3. Heal");
            Console.WriteLine();
            Console.Write("Choose your action 1-3: ");

            bool userInput3 = int.TryParse(Console.ReadLine(), out int action3);

            if (!userInput3 || action3 < 1 || action3 > 3)
            {
                if (userInput3 || action3 < 1 || action3 > 3)
                {
                    Console.WriteLine("Invalid input. Please choose a valid action.");
                }
                else
                {
                    Console.WriteLine(" Please choose a number 1 2 or 3");
                }
            }
            else if (action3 == 1)
            {
                monHp -= heroAtk;
                Console.WriteLine($"Hero attacks! Monster takes {heroAtk} damage. Monster HP: {monHp}");
            }
            else if (action3 == 2)
            {
                monHp -= heroSkillatk;
                Console.WriteLine($"Hero uses skill! Monster takes {heroSkillatk} damage. Monster HP: {monHp}");
            }
            else if (action3 == 3)
            {
                heroHp += heroSkillheal;
                Console.WriteLine($"Hero heals! Hero gains {heroSkillheal} HP. Hero HP: {heroHp}");

            }
            if (monHp <= 0)
            {
                Console.WriteLine();
                Console.WriteLine("==============================================");
                Console.WriteLine("Monster is defeated! You win!");
                Console.WriteLine("==============================================");
            }
            else if (heroHp <= 0)
            {
                Console.WriteLine();
                Console.WriteLine("==============================================");
                Console.WriteLine("Game Over!");
                Console.WriteLine("==============================================");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("==============================================");
                Console.WriteLine("Monster Turn");
                Console.WriteLine($"Hero HP: {heroHp}");
                heroHp -= monAtk;
                Console.WriteLine($"Monster attacked you: {heroHp}");
                Console.WriteLine("==============================================");

                Console.WriteLine();
                Console.WriteLine("1. Attack");
                Console.WriteLine("2. Use Skill");
                Console.WriteLine("3. Heal");
                Console.WriteLine();
                Console.Write("Choose your action 1-3: ");

                bool userInput4 = int.TryParse(Console.ReadLine(), out int action4);

                if (!userInput4 || action4 < 1 || action4 > 3)
                {
                    if (userInput4 || action4 < 1 || action4 > 3)
                    {
                        Console.WriteLine("Invalid input. Please choose a valid action.");
                    }
                    else
                    {
                        Console.WriteLine(" Please choose a number 1 2 or 3");
                    }
                }
                else if (action4 == 1)
                {
                    monHp -= heroAtk;
                    Console.WriteLine($"Hero attacks! Monster takes {heroAtk} damage. Monster HP: {monHp}");
                }
                else if (action4 == 2)
                {
                    monHp -= heroSkillatk;
                    Console.WriteLine($"Hero uses skill! Monster takes {heroSkillatk} damage. Monster HP: {monHp}");
                }
                else if (action4 == 3)
                {
                    heroHp += heroSkillheal;
                    Console.WriteLine($"Hero heals! Hero gains {heroSkillheal} HP. Hero HP: {heroHp}");

                }
                if (monHp <= 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("==============================================");
                    Console.WriteLine("Monster is defeated! You win!");
                    Console.WriteLine("==============================================");
                }
                else if (heroHp <= 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("==============================================");
                    Console.WriteLine("Game Over!");
                    Console.WriteLine("==============================================");
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("==============================================");
                    Console.WriteLine("Game Over! Monster is run away!");
                    Console.WriteLine("==============================================");
                }
            }
        }
    }
}
