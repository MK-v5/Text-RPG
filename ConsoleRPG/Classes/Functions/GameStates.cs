using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRPG
{
    class GameStates
    {
        enum states 
        {
            Null,
            World,
            Credits,
            Combat,
            Paused,
            CharacterSelect,
            CharacterSheet,
            GameOver
        }
    }
}
