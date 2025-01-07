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
        MainMenue.Print();
        while(true)
        {
            char optionkey = Caption.GetKey_asChar();
            MainMenue.Option(optionkey);
        }
        
    }

    public static void PreMadeMaze()
    {
        // [i]-Creating pre-made maze
        Maze preMadeMaze = new Maze();
        
        

    }

    public static void GeneratedMaze()
    {

    }

}