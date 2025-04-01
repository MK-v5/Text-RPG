using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRPG
{
    public class Entity
    {
        public string CharacterName { get; set; }
        public string ClassName { get; set; }
        public string RaceName { get; set; }
        //baseStats
        public int hitPoints { get; set; }
        public int skillPoints { get; set; }
        public int magicPoints { get; set; }
        public int strength { get; set; }
        public int defense { get; set; }
        public int agility { get; set; }
/*
        //raceStatMODS
        public int hitPointsMod { get; set; }
        public int skillPointsMod { get; set; }
        public int magicPointsMod { get; set; }
        //classStatMODS
        public int strengthMod { get; set; }
        public int defenseMod { get; set; }
        public int agilityMod { get; set; }
*/
    }
    public class Wolf : Entity
    {
        public Wolf (string rN, int HP, int SP, int MP)
        {
            RaceName = rN;
            hitPoints = HP;
            skillPoints = SP;
            magicPoints = MP;
        }
    }
    public class Knight : Entity 
    {
        public Knight(String cN, int STR, int SP, int MP)
        {

        }
    }
}