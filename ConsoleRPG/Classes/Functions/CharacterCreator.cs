using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRPG
{
    class CharacterCreator
    {
        Menu ccMenu = new Menu();
        Entity Thing = new Entity();
        void CreateCharacter()
        {

        }
        public void ChooseRace()
        {
            //values for menuOptions
            string logo = @"
                        [][][][][]  [][][][][]  [][][][][]  [][][][][]
                        []      []  []      []  []          []
                        [][][][][]  [][][][][]  []          [][][][]
                        []    []    []      []  []          []
                        []      []  []      []  [][][][][]  [][][][][]
                            ";
            string[] lText = { logo };
            string form = @"";
            string[] fText = { form };
            string[] options = { "Wolf", "Cat", "Fox", "Dragon" };
            ccMenu.MenuCreate(options, "please Choose a race:", lText, fText);
            int selectedIndex = ccMenu.Run();
            //options
            switch (selectedIndex)
            {
                case 0:
                    Thing.RaceName = "Wolf";
                    Thing.hitPoints = 40;
                    Thing.skillPoints = 15;
                    Thing.magicPoints = 10;
                    ccMenu.displaySelected();
                    Thread.Sleep(250);
                    ChooseClass();
                    break;
                case 1:
                    Thing.RaceName = "Cat";
                    Thing.hitPoints = 10;
                    Thing.skillPoints = 30;
                    Thing.magicPoints = 15;
                    ccMenu.displaySelected();
                    Thread.Sleep(250);
                    ChooseClass();
                    break;
                case 2:
                    Thing.RaceName = "Fox";
                    Thing.hitPoints = 15;
                    Thing.skillPoints = 30;
                    Thing.magicPoints = 40;
                    ccMenu.displaySelected();
                    Thread.Sleep(250);
                    ChooseClass();
                    break;
                case 3:
                    Thing.RaceName = "Dragon";
                    Thing.hitPoints = 30;
                    Thing.skillPoints = 15;
                    Thing.magicPoints = 10;
                    ccMenu.displaySelected();
                    Thread.Sleep(250);
                    ChooseClass();
                    break;
            }
        }
        public void ChooseClass()
        {
            //values for MenuOptions
            string logo = @"
                        [][][][][]  []          [][][][][]  [][][][][]  [][][][][]
                        []          []          []      []  []          []
                        []          []          [][][][][]  [][][][][]  [][][][][]
                        []          []          []      []          []          []
                        [][][][][]  [][][][][]  []      []  [][][][][]  [][][][][]
                            ";
            string[] lText = { logo };
            string form = @"";
            string[] fText = { form };
            string[] options = { "Knight", "Rogue", "Mage", "Berserk" };
            ccMenu.MenuCreate(options, "please Choose a Class:", lText, fText);
            int selectedIndex = ccMenu.Run();
            //Options
            switch (selectedIndex)
            {
                case 0:
                    Thing.ClassName = "Knight";
                    Thing.strength = 15;
                    Thing.defense = 30;
                    Thing.agility = 10;
                    ccMenu.displaySelected();
                    Thread.Sleep(250);
                    ccMenu.RunPauseMenu();
                    break;
                case 1:
                    Thing.ClassName = "Rogue";
                    Thing.strength = 15;
                    Thing.defense = 10;
                    Thing.agility = 40;
                    ccMenu.displaySelected();
                    Thread.Sleep(250);
                    ccMenu.RunPauseMenu();
                    break;
                case 2:
                    Thing.ClassName = "Mage";
                    Thing.strength = 10;
                    Thing.defense = 10;
                    Thing.agility = 15;
                    ccMenu.displaySelected();
                    Thread.Sleep(250);
                    ccMenu.RunPauseMenu();
                    break;
                case 3:
                    Thing.ClassName = "Berserker";
                    Thing.strength = 40;
                    Thing.defense = 15;
                    Thing.agility = 10;
                    ccMenu.displaySelected();
                    Thread.Sleep(250);
                    ccMenu.RunPauseMenu();
                    break;
            }
        }
    }
}