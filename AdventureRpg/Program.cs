using System;
using System.Diagnostics;
using System.IO;
using System.IO.Pipes;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;
using AdventureRpg.Classes;

namespace AdventureRpg
{
    class Program
    {
        //static Combat combat = new Combat();
        static Menu menu = new Menu();
        static Game game = new Game();
        static readonly JsonSerializerOptions jOptions = new() { DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull, WriteIndented = true };
        static string[] path = { "SaveData/playerSave1.Json", "SaveData/playerSave2.Json", "SaveData/playerSave3.Json", "SaveData/playerSave4.Json" };
        static public int currentSave = 0;
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            menu.RunMainMenu();
            //combat.RunCombat();
        }
        public static void SaveGame(Menu mSave)
        {
            if (!Directory.Exists("SaveData"))
            {
                Directory.CreateDirectory("SaveData");
            }
            string jsonString = JsonSerializer.Serialize(mSave, jOptions);
            File.WriteAllText(path[currentSave], jsonString);
        }
        public static void LoadSave()
        {
            if (File.Exists(path[currentSave]) != false)
            {
                string allSaves = File.ReadAllText(path[currentSave]);
                game = JsonSerializer.Deserialize<Game>(allSaves);
            }
        }
    }
}