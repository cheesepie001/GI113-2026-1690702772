// ชื่อ - นามสกุล: นายปรมัตถ์ เชื้อเมืองพาน
// Section: 129C
// รหัสนักศึกษา: 1690702772
// เลขที่: 23

namespace Assignment01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string GameTitle = "Dream Space Ocean"; 

            var heroName = "Lala";     
            var heroRank = 'B';         
            int heroDmg = 10;
            int heroMgi = 10;
            int heroDef = 10;
            int heroEvade = 3;
            float critRate = 10.5f;
            double critMultiplier = 100.5;  
            bool useMagic = true;


            Console.WriteLine($"+======================================================================+\r\n| ______                             ______                            |\r\n|(______)                           / _____)                           |\r\n| _     _ ____ _____ _____ ____    ( (____  ____  _____  ____ _____    |\r\n|| |   | / ___) ___ (____ |    \\    \\____ \\|  _ \\(____ |/ ___) ___ |   |\r\n|| |__/ / |   | ____/ ___ | | | |   _____) ) |_| / ___ ( (___| ____|   |\r\n||_____/|_|   |_____)_____|_|_|_|  (______/|  __/\\_____|\\____)_____)   |\r\n|                                          |_|                         |\r\n|                   _______                                            |\r\n|                  (_______)                                           |\r\n|                   _     _  ____ _____ _____ ____                     |\r\n|                  | |   | |/ ___) ___ (____ |  _ \\                    |\r\n|                  | |___| ( (___| ____/ ___ | | | |                   |\r\n|                   \\_____/ \\____)_____)_____|_| |_|                   |\r\n+======================================================================+");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($" ===================== {GameTitle} ===================== ");
            Console.WriteLine($"|Hero Name   : {heroName}");
            Console.WriteLine($"|Rank        : {heroRank}");
            Console.WriteLine($"|Damage      : {heroDmg}");
            Console.WriteLine($"|Magic       : {heroMgi}");
            Console.WriteLine($"|Defense     : {heroDef}");
            Console.WriteLine($"|Evade       : {heroEvade}");
            Console.WriteLine($"|Crit Rate   : {critRate}");
            Console.WriteLine($"|Crit DMG    : {critMultiplier}");
            Console.WriteLine($"|Magic DMG   : {useMagic}|");
            Console.WriteLine($" ============================================================= ");
            Console.WriteLine($"////////////////////////////////////\r\n//.--..-.   .---. .--..-.   .---. //\r\n//|-< | |__ | | | |-< | |__ | | | //\r\n//`--'`----'`-^-' `--'`----'`-^-' //\r\n////////////////////////////////////");

            Console.WriteLine();
            double heroDmgAsDouble = heroDmg; 
            Console.WriteLine($"Damage as double (implicit): {heroDmgAsDouble}");

            int critMultiplierAsInt = (int)critMultiplier;               
            int critRateAsInt = Convert.ToInt32(critRate);      
            Console.WriteLine($"Crit Rate cast (truncates)  : {critRateAsInt}");
            Console.WriteLine($"Crit Damage Convert (rounds)  : {critMultiplierAsInt}");
            Console.WriteLine($" ============================================================= ");
        }
    }
}
