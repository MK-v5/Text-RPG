using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Threading.Tasks;
using System.Reflection.Metadata.Ecma335;

namespace ConsoleRPG
{
    class Jsaves
    {
        //static Combat combat = new Combat();
        static Menu menu = new Menu();
        static CharacterCreator cc = new CharacterCreator();
        Entity en = new Entity();
        static Game game = new Game();
        static readonly JsonSerializerOptions jOptions = new() { DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull, WriteIndented = true };
        static string[] path = { "SaveData/playerSave1.Json", "SaveData/playerSave2.Json", "SaveData/playerSave3.Json", "SaveData/playerSave4.Json" };
        static public int currentSave = 0;
        public static void SaveGame(Entity EntSave)
        {
            if (!Directory.Exists("SaveData"))
            {
                Directory.CreateDirectory("SaveData");
            }
            string jsonString = JsonSerializer.Serialize(EntSave, jOptions);
            File.WriteAllText(path[currentSave], jsonString);
        }
        void LoadSave()
        {
            if (File.Exists(path[currentSave]) != false)
            {
                string allSaves = File.ReadAllText(path[currentSave]);
                menu = JsonSerializer.Deserialize<Menu>(allSaves);
            }
        }
        public void RunSaveTo()
        {
            Console.Clear();
            string logo = @"
                        [][][][][]  [][][][][]  []      []  [][][][][]
                        []          []      []  []      []  []
                        [][][][][]  [][][][][]    []  []    [][][][]
                                []  []      []    []  []    []
                        [][][][][]  []      []      []      [][][][][]
                            ";
            string[] lText = { logo };
            string form = @"";
            string[] fText = { form };
            string prompt = "Options:";
            string[] options = { $"Save1", "Save2", "Save3", "Save4", "Back" };
            menu.MenuCreate(options, prompt, lText, fText);
            int selectedIndex = menu.Run();
            switch (selectedIndex)
            {
                case 0:
                    currentSave = 0;
                    SaveGame(en);
                    menu.displaySelected();
                    Thread.Sleep(250);
                    menu.RunPauseMenu();
                    break;
                case 1:
                    currentSave = 1;
                    SaveGame(en);
                    menu.displaySelected();
                    Thread.Sleep(250);
                    menu.RunPauseMenu();
                    break;
                case 2:
                    currentSave = 2;
                    SaveGame(en);
                    menu.displaySelected();
                    Thread.Sleep(250);
                    menu.RunPauseMenu();
                    break;
                case 3:
                    currentSave = 3;
                    SaveGame(en);
                    menu.displaySelected();
                    Thread.Sleep(250);
                    menu.RunPauseMenu();
                    break;
                case 4:
                    menu.displaySelected();
                    Thread.Sleep(250);
                    menu.RunPauseMenu();
                    break;
            }
        }
        public void RunLoadGame()
        {
            string logo = @"
                        []          [][][][][]  [][][][][]  [][][][]
                        []          []      []  []      []  []      []
                        []          []      []  [][][][][]  []      []
                        []          []      []  []      []  []      []
                        [][][][][]  [][][][][]  []      []  [][][][]
                            ";
            string[] lText = { logo };
            string form = @"";
            string[] fText = { form };
            string[] options = { "save 1", "save 2", "save 3", "save 4", "Back" };
            menu.MenuCreate(options, "please Choose a save:", lText, fText);
            int selectedIndex = menu.Run();
            switch (selectedIndex)
            {
                case 0:
                    currentSave = 0;
                    menu.displaySelected();
                    Thread.Sleep(250);
                    LoadSave();
                    menu.RunPauseMenu();
                    break;
                case 1:
                    currentSave = 1;
                    menu.displaySelected();
                    Thread.Sleep(250);
                    LoadSave();
                    menu.RunPauseMenu();
                    break;
                case 2:
                    Jsaves.currentSave = 2;
                    menu.displaySelected();
                    Thread.Sleep(250);
                    LoadSave();
                    menu.RunPauseMenu();
                    break;
                case 3:
                    Jsaves.currentSave = 3;
                    menu.displaySelected();
                    Thread.Sleep(250);
                    LoadSave();
                    menu.RunPauseMenu();
                    break;
                case 4:
                    menu.displaySelected();
                    Thread.Sleep(250);
                    menu.RunMainMenu();
                    break;
            }
        }
    }
}
