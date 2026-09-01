using System; 

namespace Lab03
{
    internal class Program
    {
        static void Main(string[] args)
        {
           const int MaxLevel = 10;

            var bossName = "Kirin";
            var rank = 'S';
            int level = 7;
            int maxHp = 240;
            int currentHp = 115;
            float attackPower = 42.5f;
            double critMultiplier = 1.75;
            bool isBoss = true;

            Console.WriteLine("===== KIRIN SAVE CONVERTER =====");
            Console.WriteLine($"Boss Name: {bossName}" +
                $"\nRank: {rank}" +
                $"\nLevel: {level}/{MaxLevel}" +
                $"\nMax HP: {maxHp}" +
                $"\nCurrent HP: {currentHp}" +
                $"\nAttack Power: {attackPower}" +
                $"\nCritical Multiplier: {critMultiplier}" +
                $"\nIs Boss: {isBoss}");
            // 1.Implicit Conversion int (HP) --> double
            Console.WriteLine("\n----- Implicit Conversion: HP as double -----");
            double currentHpDouble = currentHp;
            Console.WriteLine($"HP (double): {currentHpDouble}");

            // 2.Calculate Percentage
            Console.WriteLine("----- Exact HP Percent (no integer truncation) -----");
            double hpPercentExact = currentHpDouble * 100 / maxHp;
            Console.WriteLine($"HP Percent (exact): {hpPercentExact}%");

            // 3.Explicit float (attack Power) --> int
            Console.WriteLine("\n----- Explicit Conversion: Attack Power as int -----");
            int attackPowerInt = (int)attackPower;
            Console.WriteLine($"Attack Power (int): {attackPowerInt}");

            // 4.Cast vs. Convert double (critMultiplier) --> int
            Console.WriteLine("\n----- Cast vs Convert: Crit Multiplier -----");
            int critCast = (int)critMultiplier;
            int critConvert = Convert.ToInt32(critMultiplier);
            Console.WriteLine($"Critical Multiplier (cast): {critCast}");
            Console.WriteLine($"Critical Multiplier (convert): {critConvert}");

        }
    }
}
