using AdventureRpg.Classes;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Text.Json;
using System.Threading;
namespace AdventureRpg
{
    class Game
    {
        //Combat c = new Combat();
        Menu m = new Menu();
        public void Scenario1_k()
        {
            Console.Clear();
            Console.WriteLine("you are knight you ran from other knights you coward.");
            //c.RunCombat();
        }
        public void Scenario1_r()
        {
            Console.Clear();
            Console.WriteLine("you tried to be cool and quiet but came over as mute and clumsy.");
            //c.RunCombat();
        }
        public void Scenario1_m()
        {
            Console.Clear();
            Console.WriteLine("Magicless Mage.");
            //c.RunCombat();
        }
        public void Scenario1_b()
        {
            Console.Clear();
            Console.WriteLine("Golden Age.");
            //c.RunCombat();
        }
    }
}