using System;
using Resourses.Visual;
using Resourses.Logic;
using Pro001;
using Spectre.Console;

namespace Logic;

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

            mainMenue.Option(Caption.GetKey_asChar());
        }
    }

    public static void NewGame()
    {

    }

    public static void LoadGame()
    {
        
    }

    public static void Information()
    {

    }
}