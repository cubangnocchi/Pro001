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

        /*
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
        */
        PreMadeMaze();
        
        
        
    }

    

    public static void PreMadeMaze()
    {
        //Console.Clear();
        Console.WriteLine("Creating maze");
        // [i]-Creating pre-made maze
        Maze preMadeMaze = new Maze();
        // [i]-Simulate what the screen should do
        
        Console.WriteLine("Maze");
        Camera.CameraTest(preMadeMaze).Print();

        ConsoleKeyInfo keyInfo = Console.ReadKey(true);

        //testing free movement

        Console.Clear();

        Player player = new("Juanito", 6, 6);
        Image playerImage = new(1);
        playerImage.SetPixel(0,0,Textures.GetTxtr(Textures.Txtr.player1));

        Menue.OptionMethod[] optionMethods = 
        {
            player.MoveUp,
            player.MoveDown,
            player.MoveLeft,
            player.MoveRight,
            Program.CloseAplication
        };

        Menue miniTest = new("PreMadeMazeTest",
                            ['w','s','a','d','x'],
                            ["up","down","left","right","exit"],
                            optionMethods);
        
        while(true)
        {
            
            
            
            Image.AddLayer(Camera.CameraTest(preMadeMaze),
                       playerImage,
                       player.GetRow(),
                       player.GetCol()).Print();
            Console.WriteLine("");
            Console.WriteLine("");
            miniTest.Print();
            miniTest.Option(Caption.GetKey_asChar());



        }

        

        

        
               

    }

    

    public static void GeneratedMaze()
    {

    }

}