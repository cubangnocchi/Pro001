using System;
using Spectre.Console;
using Resourses.Logic;
using Resourses.Visual;
namespace PRO001;

class MiniTest
{
    

    public static void Run()
    {
        
        //[i]-Creating Menue
        char[] optionKeys = ['1', '2', 'x'];
        string[] optionsNames = ["pre-made Maze", "generated Maze", "Exit"];
        Menue.OptionMethod[] optionMethods = new Menue.OptionMethod[]
        {
            PreMadeMaze,
            GeneratedMaze,
            Program.CloseAplication,
            
        };
        Menue MainMenue = new Menue("Main Menue", optionKeys, optionsNames, optionMethods);
        //[i]-Printing menue (pre Image visuals...)
        while(true)
        {
            MainMenue.Print();
            ConsoleKeyInfo keyInfo = Console.ReadKey(true);         
            char optionkey = keyInfo.KeyChar;
            MainMenue.Option(optionkey);
        }
        
        
        
    }

    

    public static void PreMadeMaze()
    {
        // [i]-Creating pre-made maze
        Maze preMadeMaze = new Maze();
        // [i]-Simulate what the screen should do
        Console.Clear();
        Console.WriteLine("Maze");
        Camera.CameraTest(preMadeMaze).Print();
               

    }

    public static void GeneratedMaze()
    {

    }

}