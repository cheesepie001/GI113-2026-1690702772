using System;

namespace project129C
{
    internal class Program
    {
        static void Main(string[] args)
        {

        //งาน PART A


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



            //งาน PART B

            string roleName = "Wizard";          
            Char rank = 'B';                   
            int level = 14;                       
            int maxHp = 100;
            float attackPower = 14.3f;          
            double critMultiplier = 1.2;          
            bool isMagic = true;                 

            //ประกาศตัวแปร6ตัว
            Console.WriteLine("===== Wizard STATUS: INITIAL =====");
            Console.WriteLine($"Name: {mobName}");
            Console.WriteLine($"Rank: {rank}");
            Console.WriteLine($"HP: {maxHp}");
            Console.WriteLine($"Attack power:  {attackPower}");
            Console.WriteLine($"CritMultiplier: {critMultiplier}");
            Console.WriteLine($"Is Magic: {isMagic}");

            string roleName = "Sword Man";          
            Char rank = 'D';                   
            int level = 5;                       
            int maxHp = 130;
            float attackPower = 9.9f;          
            double critMultiplier = 1.5;          
            bool isMagic = false;                 

            //ประกาศตัวแปร6ตัว
            Console.WriteLine("===== Sword Man STATUS: INITIAL =====");
            Console.WriteLine($"Name: {roleName}");
            Console.WriteLine($"Rank: {rank}");
            Console.WriteLine($"HP: {maxHp}");
            Console.WriteLine($"Attack power:  {attackPower}");
            Console.WriteLine($"CritMultiplier: {critMultiplier}");
            Console.WriteLine($"Is Magic: {isMagic}");

             string roleName = "Doctor";          
            Char rank = 'D';                   
            int level = 3;                       
            int maxHp = 100;
            float attackPower = 7.3f;          
            double critMultiplier = 1.5;          
            bool isMagic = false;                 

            //ประกาศตัวแปร6ตัว
            Console.WriteLine("===== Doctor STATUS: INITIAL =====");
            Console.WriteLine($"Name: {roleName}");
            Console.WriteLine($"Rank: {rank}");
            Console.WriteLine($"HP: {maxHp}");
            Console.WriteLine($"Attack power:  {attackPower}");
            Console.WriteLine($"CritMultiplier: {critMultiplier}");
            Console.WriteLine($"Is Magic: {isMagic}");

             string roleName = "Priest";          
            Char rank = 'B';                   
            int level = 10;                       
            int maxHp = 105;
            float attackPower = 10.1f;          
            double critMultiplier = 1.2;          
            bool isMagic = true;                 

            //ประกาศตัวแปร6ตัว
            Console.WriteLine("===== Priest STATUS: INITIAL =====");
            Console.WriteLine($"Name: {roleName}");
            Console.WriteLine($"Rank: {rank}");
            Console.WriteLine($"HP: {maxHp}");
            Console.WriteLine($"Attack power:  {attackPower}");
            Console.WriteLine($"CritMultiplier: {critMultiplier}");
            Console.WriteLine($"Is Magic: {isMagic}");
        }
    }
}
