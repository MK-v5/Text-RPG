using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using ConsoleRPG.Classes.Characters;

namespace ConsoleRPG.Classes.Functions;

class Menu
{
    //Combat com = new Combat();
    //Encounter e = new Encounter();
    //Game g = new Game();
    //Inventory inventory = new Inventory();
    //Wolf wolf = new Wolf("Wolf", 40, 15, 10);
    //Cat cat = new Cat("Cat",10, 30, 15);
    //Fox fox = new Fox("Fox", 15, 30, 40);
    //Dragon dragon = new Dragon("Dragon", 40, 15, 10);
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
        //for loop used for the displaying of logo
        for(int i = 0; i < Logo.Length; i++)
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
            if(i == selectedIndex)
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
        }while (keyPressed != ConsoleKey.Enter);
        return selectedIndex;
    }
    public void RunMainMenu()
    {
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
                ChooseRace();
                break;
            case 1:
                displaySelected();
                Thread.Sleep(200);
                RunLoadGame();
                break;
                break;
            case 2:
                displaySelected();
                Thread.Sleep(200);
                Environment.Exit(0);
                break;
        }
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
        MenuCreate(options, "please Choose a race:", lText, fText);
        int selectedIndex = Run();
        //options
        switch (selectedIndex)
        {
            case 0:
                
                displaySelected();
                Thread.Sleep(250);
                ChooseClass();
                break;
            case 1:

                displaySelected();
                Thread.Sleep(250);
                ChooseClass();
                break;
            case 2:
  
                displaySelected();
                Thread.Sleep(250);
                ChooseClass();
                break;
            case 3:

                displaySelected();
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
        MenuCreate(options, "please Choose a Class:", lText, fText);
        int selectedIndex = Run();
        //Options
        switch (selectedIndex)
        {
            case 0:
                displaySelected();
                Thread.Sleep(250);
                //g.Scenario1_k();
                RunPauseMenu();
                break;
            case 1:
                displaySelected();
                Thread.Sleep(250);
                RunPauseMenu();
                break;
            case 2:
                displaySelected();
                Thread.Sleep(250);
                RunPauseMenu();
                break;
            case 3:
                displaySelected();
                Thread.Sleep(250);
                RunPauseMenu();
                break;
        }
    }
    public void RunPauseMenu()
    {
        Console.Clear();
        string logo = @"
                        [][][][][]  [][][][][]  []      []  [][][][][]
                        []          []      []  [][]  [][]  []
                        []  [][][]  [][][][][]  []  []  []  [][][][]
                        []      []  []      []  []      []  []
                        [][][][][]  []      []  []      []  [][][][][]
                            ";
        string[] lText = { logo };
        string form = @"";
        string[] fText = { form };
        string prompt = "Options:";
        string[] options = { "Shop", "Inventory", "Dungeon", "Save", "MainMenu" };
        MenuCreate(options, prompt, lText, fText);
        int selectedIndex = Run();
        switch (selectedIndex)
        {
            case 0:
                displaySelected();
                Thread.Sleep(250);
                RunShop();
                break;
            case 1:
                displaySelected();
                Thread.Sleep(250);
                RunInventory();
                break;
            case 2:
                displaySelected();
                Thread.Sleep(250);
                //com.RunCombat();
                //e.EnCounTER();
                break;
            case 3:
                displaySelected();
                Thread.Sleep(250);
                RunSaveTo();
                break;
            case 4:
                displaySelected();
                Thread.Sleep(250);
                RunMainMenu();
                break;
        }
    }
    void RunSaveTo()
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
        MenuCreate(options, prompt, lText, fText);
        int selectedIndex = Run();
        switch (selectedIndex)
        {
            case 0:
                Program.currentSave = 1;
                Program.SaveGame(this);
                displaySelected();
                Thread.Sleep(250);
                RunPauseMenu();
                break;
            case 1:
                Program.currentSave = 2;
                Program.SaveGame(this);
                displaySelected();
                Thread.Sleep(250);
                RunPauseMenu();
                break;
            case 2:
                Program.currentSave = 3;
                Program.SaveGame(this);
                displaySelected();
                RunPauseMenu();
                Thread.Sleep(250);
                break;
            case 3:
                Program.currentSave = 4;
                Program.SaveGame(this);
                displaySelected();
                Thread.Sleep(250);
                RunPauseMenu();
                break;
            case 4:
                displaySelected();
                Thread.Sleep(250);
                RunPauseMenu();
                break;
        }
    }
    void RunLoadGame()
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
        MenuCreate(options, "please Choose a save:", lText, fText);
        int selectedIndex = Run();
        switch (selectedIndex)
        {
            case 0:
                Program.currentSave = 1;
                displaySelected();
                Thread.Sleep(250);
                Program.LoadSave();
                RunPauseMenu();
                break;
            case 1:
                Program.currentSave = 2;
                displaySelected();
                Thread.Sleep(250);
                Program.LoadSave();
                RunPauseMenu();
                break;
            case 2:
                Program.currentSave = 3;
                displaySelected();
                Thread.Sleep(250);
                Program.LoadSave();
                RunPauseMenu();
                break;
            case 3:
                Program.currentSave = 4;
                displaySelected();
                Thread.Sleep(250);
                Program.LoadSave();
                RunPauseMenu();
                break;
            case 4:
                displaySelected();
                Thread.Sleep(250);
                RunMainMenu();
                break;
        }
    }
    void RunShop()
    {
        Console.Clear();
        string logo = @"
                        [][][][][]  []      []  [][][][][]  [][][][][]
                        []          []      []  []      []  []      []
                        [][][][][]  [][][][][]  []      []  [][][][][]
                                []  []      []  []      []  []
                        [][][][][]  []      []  [][][][][]  []
                            ";
        string[] lText = { logo };
        string form = @"";
        string[] fText = { form };
        string prompt = "Options:";
        string[] options = { "Weapons", "Armours", "Items", "Back" };
        MenuCreate(options, prompt, lText, fText);
        int selectedIndex = Run();
        switch (selectedIndex)
        {
            case 0:
                RunWeaponSection();
                displaySelected();
                Thread.Sleep(250);
                break;
            case 1:
                RunArmourSection();
                displaySelected();
                Thread.Sleep(250);
                break;
            case 2:
                RunItemsSection();
                displaySelected();
                Thread.Sleep(250);
                break;
            case 3:
                displaySelected();
                Thread.Sleep(250);
                RunPauseMenu();
                break;
        }
    }
    void RunWeaponSection()
    {

    }
    void RunArmourSection()
    {

    }
    void RunItemsSection()
    {

    }
    void RunDungeons()
    {

    }
    void RunInventory()
    {
        Console.Clear();
        string logo = @"
                        []  []      []  []      []  [][][][][]  [][][][][]  [][][][][] [][][][][]  []      []          
                            [][]    []  []      []  []              []      []      [] []      []    []  []
                        []  []  []  []    []  []    [][][][]        []      []      [] [][][][][]      []
                        []  []    [][]    []  []    []              []      []      [] []    []        []
                        []  []      []      []      [][][][][]      []      [][][][][] []      []      []
                            ";
        string[] lText = { logo };
        string form = @"";
        string[] fText = { form };
        string prompt = "Options:";
        string[] options = { "Weapon", "Armour", "Items", "Back" };
        MenuCreate(options, prompt, lText, fText);
        int selectedIndex = Run();
        switch (selectedIndex)
        {
            case 0:
                Console.WriteLine("Weapons");
                displaySelected();
                Thread.Sleep(250);
                break;
            case 1:
                Console.WriteLine("Armoury");
                displaySelected();
                Thread.Sleep(250);
                break;
            case 2:
                Console.WriteLine("Items");
                displaySelected();
                Thread.Sleep(250);
                break;
            case 3:
                displaySelected();
                Thread.Sleep(250);
                RunPauseMenu();
                break;
        }
    }
    void RunInvWeapons()
    {
        Console.Clear();
        string logo = @"
                        [][][][][]
                            ";
        string[] lText = { logo };
        string form = @"";
        string[] fText = { form };
        string prompt = "Options:";
        string[] options = { "Weapon", "Armour", "Items", "Back" };
        MenuCreate(options, prompt, lText, fText);
        int selectedIndex = Run();
        switch (selectedIndex)
        {
            case 0:
                Console.WriteLine("Weapons");
                displaySelected();
                Thread.Sleep(250);
                break;
            case 1:
                Console.WriteLine("Armoury");
                displaySelected();
                Thread.Sleep(250);
                break;
            case 2:
                Console.WriteLine("Items");
                displaySelected();
                Thread.Sleep(250);
                break;
            case 3:
                displaySelected();
                Thread.Sleep(250);
                RunPauseMenu();
                break;
        }
    }
    void RunInvArmour()
    {
        Console.Clear();
        string logo = @"
                        [][][][][]
                            ";
        string[] lText = { logo };
        string form = @"";
        string[] fText = { form };
        string prompt = "Options:";
        string[] options = { "fadsjlkfdajsl",  "asldkfjl;aksdfj;l", "afdlj" };
        MenuCreate(options, prompt, lText, fText);
        int selectedIndex = Run();
        switch (selectedIndex)
        {
            case 0:
                Console.WriteLine("Weapons");
                displaySelected();
                Thread.Sleep(250);
                break;
            case 1:
                Console.WriteLine("Armoury");
                displaySelected();
                Thread.Sleep(250);
                break;
            case 2:
                Console.WriteLine("Items");
                displaySelected();
                Thread.Sleep(250);
                break;
            case 3:
                displaySelected();
                Thread.Sleep(250);
                RunPauseMenu();
                break;
        }
    }
    void RunInvItems()
    {
        Console.Clear();
        string logo = @"
                        []  [][][][][]  [][][][][]         
                                []      []        
                        []      []      [][][][]
                        []      []      []      
                        []      []      [][][][][]
                            ";
        string[] lText = { logo };
        string form = @"";
        string[] fText = { form };
        string prompt = "Options:";
        string[] options = { "Weapon", "Armour", "Items", "Back" };
        MenuCreate(options, prompt, lText, fText);
        int selectedIndex = Run();
        switch (selectedIndex)
        {
            case 0:
                Console.WriteLine("Weapons");
                displaySelected();
                Thread.Sleep(250);
                break;
            case 1:
                Console.WriteLine("Armoury");
                displaySelected();
                Thread.Sleep(250);
                break;
            case 2:
                Console.WriteLine("Items");
                displaySelected();
                Thread.Sleep(250);
                break;
            case 3:
                displaySelected();
                Thread.Sleep(250);
                RunPauseMenu();
                break;
        }
    }
}