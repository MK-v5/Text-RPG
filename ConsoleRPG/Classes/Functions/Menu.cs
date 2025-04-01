using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Net.NetworkInformation;

namespace ConsoleRPG
{
    public class Menu
    {
        Jsaves jS = new Jsaves();
        CharacterCreator creator;
        private int selectedIndex; //index to refrence where in the for-loop you are
        private string[] Options; //array for every option you can choose from
        private string Prompt; //string for a prompt everytime a new menu pops up
        private string[] Form; //form of the menu itself
        private string[] Logo; //menu logo
        //private bool Intro;
            //function to create Menus, will have to make a new menu each time

        //void to create a menu. you have to call upon this to create a new menu everytime
        public void MenuCreate(string[] options, string prompt, string[] logo, string[] form)
        {
            this.Prompt = prompt;
            this.Options = options;
            this.Logo = logo;
            this.Form = form;
        }
        //used to display every options by drawing the entire menu, clearing screen and redrawing menu when scrolling through options
        public void displayOptions()
        {
            Console.ResetColor();
            //for loop used for the displaying of logo
            for (int i = 0; i < Logo.Length; i++)
            {
                Console.WriteLine(Logo[i]);
            }
            Console.WriteLine(Prompt);
            Console.WriteLine("");
            //for loop used to display each option
            for (int i = 0; i < Options.Length; i++)
            {
                string currentOption = Options[i]; //string to index your current option
                string prefix; //adds a character of choice before a string
                string suffix; //adds a character of choice after a string
                Console.ResetColor();
                if (i == selectedIndex)
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.White;
                    prefix = "[ ";
                    suffix = " ]";
                }
                else
                {
                    Console.ResetColor();
                    prefix = "  ";
                    suffix = "  ";
                }
                Console.WriteLine($"{prefix}{currentOption}{suffix}");
                Console.ResetColor();
            }
        }
        //function used to see if you have selected an option (responsive visuals)
        public void displaySelected()
        {
            Console.Clear();
            for (int i = 0; i < Logo.Length; i++)
            {
                Console.WriteLine(Logo[i]);
            }
            Console.WriteLine(Prompt);
            Console.WriteLine("");
            for (int i = 0; i < Options.Length; i++)
            {
                string currentOption = Options[i];
                string prefix;
                string suffix;
                Console.ResetColor();
                if (i == selectedIndex)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.BackgroundColor = ConsoleColor.Black;
                    prefix = " [";
                    suffix = "] ";
                }
                else
                {
                    Console.ResetColor();
                    prefix = "  ";
                    suffix = "  ";
                }
                Console.WriteLine($"{prefix}{currentOption}{suffix}");
                Console.ResetColor();
            }
        }
        //keyboard controls
        public int Run()
        {
            selectedIndex = 0;
            ConsoleKey keyPressed; //checks if key is pressed
            do //it will always check if you pressed any 'arrow' keys while you haven't pressed 'enter' yet
            {
                Console.Clear();
                displayOptions();
                ConsoleKeyInfo KeyInfo = Console.ReadKey(true);
                keyPressed = KeyInfo.Key;
                if (keyPressed == ConsoleKey.UpArrow)
                {
                    selectedIndex--;
                }
                if (keyPressed == ConsoleKey.DownArrow)
                {
                    selectedIndex++;
                }
                if (selectedIndex > Options.Length - 1)
                {
                    selectedIndex = 0;
                }
                if (selectedIndex < 0)
                {
                    selectedIndex = Options.Length - 1;
                }
            } while (keyPressed != ConsoleKey.Enter);
            return selectedIndex;
        }
        public void RunMainMenu()
        {
            Console.ResetColor();
            string logo = @"
                        [][][][][]  []  [][][][][]  []          [][][][][]
                            []              []      []          []
                            []      []      []      []          [][][][]
                            []      []      []      []          []
                            []      []      []      [][][][][]  [][][][][]
                        ";
            string[] lText = { logo };
            string form = @"";
            string[] fText = { form };
            string[] options = { "New Game", "Load Game", "Quit" };
            string prompt = "Please select an option:";
            MenuCreate(options, prompt, lText, fText);
            int selectedIndex = Run();
            switch (selectedIndex)
            {
                case 0:
                    displaySelected();
                    Thread.Sleep(200);
                    creator = new CharacterCreator();
                    creator.ChooseRace();
                    break;
                case 1:
                    displaySelected();
                    Thread.Sleep(200);
                    jS.RunLoadGame();
                    break;
                case 2:
                    displaySelected();
                    Thread.Sleep(200);
                    Environment.Exit(0);
                    break;
            }
        }
        public void RunPauseMenu()
        {
            Console.Clear();
            string logo = @"
                        []      []  [][][][][]  []      []  []      []
                        [][]  [][]  []          [][]    []  []      []
                        []  []  []  [][][][]    []  []  []  []      []
                        []      []  []          []    [][]  []      []
                        []      []  [][][][][]  []      []  [][][][][]
                            ";
            string[] lText = { logo };
            string form = @"";
            string[] fText = { form };
            string prompt = "Options:";
            string[] options = { "Shop", "Inventory", "Save", "MainMenu" };
            MenuCreate(options, prompt, lText, fText);
            int selectedIndex = Run();
            switch (selectedIndex)
            {
                case 0:
                    displaySelected();
                    Thread.Sleep(250);
                    break;
                case 1:
                    displaySelected();
                    Thread.Sleep(250);
                    break;
                case 2:
                    displaySelected();
                    Thread.Sleep(250);
                    jS.RunSaveTo();
                    break;
                case 3:
                    displaySelected();
                    Thread.Sleep(250);
                    RunMainMenu();
                    break;
            }
        }
    }
}