using System.Text.Json.Serialization;
using System.Text.Json;

namespace ConsoleRPG
{
    class Program
    {
        public static Menu menu = new Menu();
        public static Combat combat = new();
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            string Credits = @"
            Developer: M.k. Somna

            Sources:
            - https://github.com/s325909/CSharp-Console-RPG/blob/main/ConsoleRPG/ConsoleRPG/Program.cs
            - https://www.youtube.com/watch?v=ISCYD7YPSf4
            - https://www.youtube.com/watch?v=qAWhGEPMlS8
            
            special thanks:
            - kornee (Achternaam)
            - Summer (Achternaam?)
            - Niek Melet
            - Marinus (Achternaam)
            - Rudo (Achternaam)
            - Mike Oomen
            ";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(Credits);
            Thread.Sleep(750);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(12, 16);
            Console.WriteLine("Please press anything");
            Console.ReadKey();
            menu.RunMainMenu();
            //combat.RunCombat();
            Console.ResetColor();
        }
    }
}