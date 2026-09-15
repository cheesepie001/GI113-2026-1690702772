// ชื่อ - นามสกุล: นายปรมัตถ์ เชื้อเมืองพาน
// Section: 129C
// รหัสนักศึกษา: 1690702772
// เลขที่: 23

using System.Runtime.ConstrainedExecution;

namespace Lab05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Game title Sub-title
            Console.WriteLine("==Test==");
            Console.WriteLine("Hero vs Monster");

            // Hero stat input HP, ATK, DEF
            Console.Write("Hero Health: ");
            bool heroHpOk = int.TryParse(Console.ReadLine(), out int heroHp);
            Console.Write("Hero Attack: ");
            bool heroAtkOk = int.TryParse(Console.ReadLine(), out int heroAtk);
            Console.Write("Hero Defense: ");
            bool heroDefOk = int.TryParse(Console.ReadLine(), out int heroDef);

            // Monster stat input
            Console.Write("Monster Health: ");
            bool monHpOk = int.TryParse(Console.ReadLine(), out int monHp);
            Console.Write("Monster Attack: ");
            bool monAtkOk = int.TryParse(Console.ReadLine(), out int monAtk);
            Console.Write("Monster Defense: ");
            bool monDefOk = int.TryParse(Console.ReadLine(), out int monDef);

            // input validation
            bool isHeroInputValid = heroHpOk && heroAtkOk && heroDefOk;
            bool isMonsterInputValid = monHpOk && monAtkOk && monDefOk;
            Console.WriteLine($"\nHERO STATUS VALID: {isHeroInputValid}");
            Console.WriteLine($"\nMONSTER STATUS VALID: {isMonsterInputValid}");

            Console.WriteLine($"[HERO]     HP: {heroHp}, ATK: {heroAtk}, DEF: {heroDef}");
            Console.WriteLine($"[MONSTER]  HP: {monHp}, ATK: {monAtk}, DEF: {monDef}");

            //bool allIntValid = isHeroInputValid && isMonsterInputValid;

            // Compile assignment :+= จำลองสถานการณ์ผู้เล่นดื่มโพชั่น
            int potionHeal = 8;
            //heroHp = hero + potionHeal;
            heroHp += potionHeal;
            Console.WriteLine($"\nHero drinks a potion, healed {potionHeal} HP. Hero HP Now: {heroHp}");

            // Arithmetic + การโจมตีธรรมดา
            int normDmg = Math.Max(0, heroAtk - monDef); //ความแรงการโจมตีขึ้นอยู่กับค่าป้องกันของศัตรู
            Console.WriteLine($"\nNormal Attack Damage: {normDmg} DMG");

            // Precedence การโจมตีพิเศษ
            int pwrDmg = Math.Max(0, (heroAtk * 2) - monDef); // โจมตีคูณ 2 จะใส่ () หรือไม่ก็ได้เพราะทำคูณก่อน
            Console.WriteLine($"Power Attack would deal: {pwrDmg} DMG");

            // Random' Simple percent of critical chance.
            Random crit = new Random();
            int roll = crit.Next(1, 101); //ต้อง+1ค่ามากสุดเสมอ
            bool isCrit = roll <= 90;
            int critDmg = normDmg + Convert.ToInt32(isCrit) * normDmg;
            Console.WriteLine($"\nCritical hit roll: {roll} (Critical: {isCrit})");
            Console.WriteLine($"If Critical, normal attack would instead deal: {critDmg} DMG");
        }
    }
}
