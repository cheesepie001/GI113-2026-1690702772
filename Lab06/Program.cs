namespace Lab06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lives = 0;

            if (true)
            {

            }

            if (lives <= 0) // ใส่เงื่อนไขที่ต้องการตรวจสอบ
            {
                // โค้ดที่จะทำงานเมื่อเงื่อนไขเป็นจริง
                Console.WriteLine("Game Over!");
            }
            else
            {
                Console.WriteLine("Keep Fighting!");
            }

            // ถ้าเป็นเท็จจะข้ามมาบรรทัดนี้ทันที
            Console.WriteLine("Continue Code!");

            bool hasKey = true;
            //int level = 12;
            Console.Write("Your level 1-99: ");
            bool isValidInput = int.TryParse(Console.ReadLine(), out int level);


            if (!isValidInput || level < 1 || level > 99)
            {
                Console.WriteLine("Invalid input.");
            }
            else if (level >= 10 && hasKey )
            {
                Console.WriteLine("Boss floor unlocked.");
            }
            else if (level >= 5)
            {
                if (hasKey == false)
                {
                    Console.WriteLine("The door opens.");
                }
                else
                {
                    Console.WriteLine("The door stays shut find a key.");
                }
            }
            else
            {
                Console.WriteLine("The door stays shut.");
            }

            bool isPosioned = true;
            if (isPosioned == true)
            {
                Console.WriteLine("You are poisoned!");
            }
            else if (isPosioned == false)
            {
                Console.WriteLine("You are safe.");
            }
        }
    }
}
