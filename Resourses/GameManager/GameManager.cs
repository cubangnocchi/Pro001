using System;
using Resourses.Visual;
using Resourses.Logic;
using Resourses.Tools;
using Pro001;
using Spectre.Console;

namespace Resourses.GameManager;

public partial class GameManager
{
    public static void MainMenue()
    {
        Menue mainMenue = 
        new("Main Menue", 
            ['1', '2', 'i', 'x'],
            ["New Game", "Load Game", "Information", "Exit"],
            [NewGame, LoadGame, Information, Program.CloseAplication]);
        

            

        while(true)
        {
            Program.ClearConsole();

            mainMenue.Print();
            mainMenue.OptionLoop();
        }

        
    }

    public static void NewGame()
    {
        //Somewhere.SelectCharacter

        

    }

    public static void LoadGame()
    {
        Program.Sorry();
    }

    public static void Information()
    {

    }
}