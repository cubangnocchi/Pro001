using System;
using Spectre.Console;
using Resourses.Logic;
using Resourses.Visual;
namespace Pro001;

class MiniTest
{
    

    public static void Run()
    {
      
        //GeneratedMaze001();
        MovementTest001();
        
        
    }

    

    public static void GeneratedMaze001()
    {
        Maze maze = new(10, 8, 7);
        maze.Create(Maze.Type.Standard);
        Camera.AllMapFixed(maze).Print();

    }

    public static void MovementTest001()
    {
        Maze maze = new(5, 7);
        maze.Create(Maze.Type.Standard);

        Player player1 = new("Pepe", 0,0);

        player1.SetPosition(3,3);
        Image playerTxtr = new Image(1,1);
        playerTxtr.SetPixel(0,0, Textures.GetTxtr(Textures.Txtr.player1)); 

        Image outputImage = new Image(15,15);

        /*
        Menue menue = new Menue("-----options-----", ['w','s','a','d','x'],
                                ["move up", "move down", "move left", "move right", "exit"],
                                new Menue.OptionMethod[]{player1.MoveUp(maze), player1.MoveDown(maze), player1.MoveLeft(maze), player1.MoveRight(maze), Program.CloseAplication});
        */ //problem with methods that needs parameters...


        while (true)
        {
            outputImage = Image.AddLayer(new Image(15,15),
                                     Camera.RoomAll(maze.GetRoom(player1.GetMazeRoomPos())),
                                     7 - player1.GetRow(), 7 - player1.GetCol());

            Image.AddLayer(outputImage, playerTxtr, 7,7).Print();

            char keyChar = Caption.GetKey_asChar();

            if(keyChar == 'w')
            {
                player1.MoveUp(maze);
            } 
            else if(keyChar == 's')
            {
                player1.MoveDown(maze);
            }
            else if(keyChar == 'a')
            {
                player1.MoveLeft(maze);
            }
            else if(keyChar == 'd')
            {
                player1.MoveRight(maze);
            }
            else if(keyChar == 'x')
            {
                Program.CloseAplication();
            }

            Program.ClearConsole();

            
        }

    }
 
    
    public static void PaintingRooms()
    {
        int[,] metaRoom = new int[5,5];
        //metaRoom = 
        Room room = new();
    }
    

    public static void GeneratedMaze()
    {

    }

}