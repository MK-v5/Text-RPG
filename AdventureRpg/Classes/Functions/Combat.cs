using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureRpg.Classes.Functions
{
    class Combat
    {
        Menu tMenu = new Menu();
        //bool yourTurn = true;
        int Damage = 10;
        int HP = 30;
        int EnemyDamage = 5;
        int EnemyHP = 50;
        int exp = 0;
        int lvl = 0;
        void UseAttack()
        {
            EnemyHP -= Damage;
            Console.WriteLine("=================================");
            Console.WriteLine("You did " + Damage + " To Enemy.");
            Console.WriteLine("=================================");
            Console.WriteLine("Enemy HP: " + EnemyHP);
            Console.WriteLine("=================================");
            Thread.Sleep(700);
            exp += 50;
            if (EnemyHP > 0)
            {
                EnemyTurn();
            }
            if (EnemyHP == 0)
            {
                Win();
            }
        }
        void LevelUp()
        {
            if (exp == 100)
            {
                lvl++;
                Console.WriteLine("Level UP!");
                Console.WriteLine("Level:" + lvl);
            }
        }
        void EnemyTurn()
        {
            EnemyAttack();
        }
        void EnemyAttack()
        {
            HP -= EnemyDamage;
            Console.WriteLine("=================================");
            Console.WriteLine("Enemy did " + EnemyDamage + " To you.");
            Console.WriteLine("=================================");
            Console.WriteLine("HP: " + HP);
            Console.WriteLine("=================================");
            Thread.Sleep(700);
            if (HP > 0)
            {
                //RunCombat();
            }
            if (HP == 0)
            {
                Fail();
            }
        }
        void Win()
        {
            Console.WriteLine("Congrations You Won Demo.");
            Thread.Sleep(1000);
            //tMenu.RunPauseMenu();
        }
        void Fail()
        {
            Console.WriteLine("You Lose Demo. :(");
            Thread.Sleep(1000);
            Environment.Exit(0);
        }
        void UseSkills()
        {
            Console.WriteLine("=================================");
            Console.WriteLine("You tried to flip but failed miserably.");
            Console.WriteLine("=================================");
            Thread.Sleep(700);
            EnemyTurn();
        }
        void UseMagic()
        {
            Console.WriteLine("=================================");
            Console.WriteLine("You tried to conjure a spell but your magic is currently too weak.");
            Console.WriteLine("=================================");
            Thread.Sleep(700);
            EnemyTurn();
        }
        void UseItems()
        {
            Console.WriteLine("=================================");
            Console.WriteLine("You were too poor to buy anything so now you're empty handed, broke.");
            Console.WriteLine("=================================");
            Thread.Sleep(700);
            EnemyTurn();
        }
        void EscapeEncounter()
        {
            Console.WriteLine("=================================");
            Console.WriteLine("Your forgort horw tor rurn.");
            Console.WriteLine("=================================");
            Thread.Sleep(700);
            EnemyTurn();
        }
            public void RunCombat()
            {
                string logo = @"
                        [][][][][]  []      []  [][][][][]  []      []  []      []
                        []          [][]    []  []          [][]  [][]    []  []
                        [][][][]    []  []  []  [][][][]    []  []  []      []
                        []          []    [][]  []          []      []      []
                        [][][][][]  []      []  [][][][][]  []      []      []
                        ";
                string[] lText = { logo };
                string form = @"";
                string[] fText = { form };
                string[] options = { "Attack", "Skills", "Magic", "Items", "Escape" };
                string prompt = "Enemy Appeared What would you Do? :";
                //tMenu.MenuCreate(options, prompt, lText, fText);
                int selectedIndex = tMenu.Run();
                switch (selectedIndex)
                {
                    case 0:
                        UseAttack();
                        tMenu.displaySelected();
                        Thread.Sleep(250);
                        break;
                    case 1:
                        UseSkills();
                        tMenu.displaySelected();
                        Thread.Sleep(250);
                        break;
                    case 2:
                        UseMagic();
                        tMenu.displaySelected();
                        Thread.Sleep(250);
                        break;
                    case 3:
                        UseItems();
                        tMenu.displaySelected();
                        Thread.Sleep(250);
                        break;
                    case 4:
                        EscapeEncounter();
                        tMenu.displaySelected();
                        Thread.Sleep(250);
                        break;
                }
            }
    }
}