using System;

// ชื่อ - นามสกุล: นายปรมัตถ์ เชื้อเมืองพาน
// Section: 129C
// รหัสนักศึกษา: 1690702772
// เลขที่: N / A

namespace project129C
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string bossName = "Kirin";          // string เอาไว้เก็บข้อความตัวอักษร "..."
            Char rank = 'S';                    // char เอาไว้เก็บตัวอักษรตัวตวเดียวใน '.'
            int level = 7;                       // int เอาไว้เก็บจำนวนเต็มบวก,เต็มลบ,0
            int maxHp = 240;
            int currentHP = 175;
            float attackPower = 42.5f;          // เอาไว้เก็บตัวเลขที่มีทศนิยม และต้องลงท้ายด้วยf
            double critMultiplier = 1.75;          // เอาไว้เก็บตัวเลขที่มีทศนิยม เก็บได้มากกว่า float
            bool isBoss = true;                 // เอาไว้เก็บค่า จริง , เท็จ true false

            //ประกาศตัวแปร6ตัว
            Console.WriteLine("===== BOSS STATUS: INITIAL =====");
            Console.WriteLine($"Name: {bossName}");
            Console.WriteLine($"Rank: {rank}");
            Console.WriteLine($"HP: {currentHP} / {maxHp}");
            Console.WriteLine($"Attack power:  {attackPower}");
            Console.WriteLine($"CritMultiplier: {critMultiplier}");
            Console.WriteLine($"Is Boss: {isBoss}");

            Console.WriteLine();
            //คำนวณเปอร์เซ็น
            int hpPercent = currentHP * 100 / maxHp;
            Console.WriteLine($"Hp Percent {hpPercent}%");
            Console.WriteLine();
            Console.WriteLine("Kirin takes 60 damage!" );
            Console.WriteLine();
            // ลด HP 60 หน่วย
            Console.WriteLine();
            Console.WriteLine("===== BOSS STATUS: AFTER DAMAGE =====");
            Console.WriteLine($"HP; {currentHP} / {maxHp}");
            hpPercent = currentHP * 100 / maxHp;

            Console.WriteLine();
            string roleName1 = "Wizard";                                  //งาน PART B
            Char rank1 = 'B';                   
            int level1 = 14;                       
            int maxHp1 = 100;
            float attackPower1 = 14.3f;          
            double critMultiplier1 = 1.2;          
            bool isMagic1 = true;                 

            Console.WriteLine("===== Wizard STATUS: INITIAL =====");
            Console.WriteLine($"Name: {roleName1}");
            Console.WriteLine($"Rank: {rank1}");
            Console.WriteLine($"HP: {maxHp1}");
            Console.WriteLine($"Attack power:  {attackPower1}");
            Console.WriteLine($"CritMultiplier: {critMultiplier1}");
            Console.WriteLine($"Is Magic: {isMagic1}");

            Console.WriteLine();
            string roleName2 = "Sword Man";          
            Char rank2 = 'D';                   
            int level2 = 5;                       
            int maxHp2 = 130;
            float attackPower2 = 9.9f;          
            double critMultiplier2 = 1.5;          
            bool isMagic2 = false;                 

            Console.WriteLine("===== Sword Man STATUS: INITIAL =====");
            Console.WriteLine($"Name: {roleName2}");
            Console.WriteLine($"Rank: {rank2}");
            Console.WriteLine($"HP: {maxHp2}");
            Console.WriteLine($"Attack power:  {attackPower2}");
            Console.WriteLine($"CritMultiplier: {critMultiplier2}");
            Console.WriteLine($"Is Magic: {isMagic2}");

            Console.WriteLine();
            string roleName3 = "Doctor";          
            Char rank3 = 'D';                   
            int level3 = 3;                       
            int maxHp3 = 100;
            float attackPower3 = 7.3f;          
            double critMultiplier3 = 1.5;          
            bool isMagic3 = false;                 

            Console.WriteLine("===== Doctor STATUS: INITIAL =====");
            Console.WriteLine($"Name: {roleName3}");
            Console.WriteLine($"Rank: {rank3}");
            Console.WriteLine($"HP: {maxHp3}");
            Console.WriteLine($"Attack power:  {attackPower3}");
            Console.WriteLine($"CritMultiplier: {critMultiplier3}");
            Console.WriteLine($"Is Magic: {isMagic3}");

            Console.WriteLine();
            string roleName4 = "Priest";          
            Char rank4 = 'B';                   
            int level4 = 10;                       
            int maxHp4 = 105;
            float attackPower4 = 10.1f;          
            double critMultiplier4 = 1.2;          
            bool isMagic4 = true;                 

            Console.WriteLine("===== Priest STATUS: INITIAL =====");
            Console.WriteLine($"Name: {roleName4}");
            Console.WriteLine($"Rank: {rank4}");
            Console.WriteLine($"HP: {maxHp4}");
            Console.WriteLine($"Attack power:  {attackPower4}");
            Console.WriteLine($"CritMultiplier: {critMultiplier4}");
            Console.WriteLine($"Is Magic: {isMagic4}");
        }
    }
}
