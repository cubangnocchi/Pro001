using System;
using Spectre.Console;
using Resourses.Logic;
using Resourses.Visual;
using Resourses.Tools;
namespace Pro001;

public partial class MiniTest
{
    

    public static void TestMenue()
    {
        
        Menue testMenue = 
        new("--- Test Menue ---",
            ['1','2','3','4','x'],
            ["Generate a maze", "Move in a maze", "Multiplayer ¨find each other¨","TextBox", "Exit"],
            [GeneratedMaze001, MovementTest002, TurnTest001, TextBoxTest, Program.CloseAplication]);

        testMenue.Print();
        
        
        
        testMenue.OptionLoop();
        

        //GeneratedMaze001();
        //MovementTest001();
        //TurnTest001();
        
        
    }

    public static void Run()
    {
        TestMenue();

        /*
        AnsiConsole.WriteLine("[]");
        AnsiConsole.WriteLine("[▥     ");
        AnsiConsole.WriteLine("[][][][][▤[][][][][][][][]");
        AnsiConsole.WriteLine("[][][][][][][][][][][][][]");
        AnsiConsole.MarkupLine("[grey][[Monoespace]][/] hola mundo ");
        Console.WriteLine("Hola mundo");
        */

        //  ↖↙⇱⇲▪◘≘≞≛⊚⊠⋰⋱⋮⋯⋮⋮⋯⋯⌖⨝⩍⩵⪥⫘⫘⫴⫵Ξ;⫯⫰ 

        //AnsiConsole.WriteLine("[]⫯⫰[]");
        //AnsiConsole.WriteLine("[][][]");

        //ConsoleKeyInfo a = Console.ReadKey(true);
        
    }

    

    public static void GeneratedMaze001()
    {
        Maze maze = new(10, 8, 7);
        maze.Create(Maze.Type.Standard);
        Camera.AllMapFixed(maze).Print();
        ConsoleKeyInfo a = Console.ReadKey(true);


    }

    public static void MovementTest001()
    {
        /*
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

        /*
        while (true)
        {
            outputImage = Image.AddLayer(new Image(15,15),
                                     Camera.RoomFixed(maze.GetRoom(player1.GetMazeRoomPos())),
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
        */

    }
 
    public static void TurnTest001()
    {
        Maze maze = new(4, 7);
        maze.Create(Maze.Type.Standard);

        Player[] players = [new Player("Pepe", [0,0, 3, 3]), new Player("Pepe", [3,3,3,3])];

        

        Image playerTxtr = new Image(1,1);
        Image otherPlayerTxtr = new Image(1,1);
        playerTxtr.SetPixel(0,0, Textures.GetTxtr(Textures.Txtr.player1)); 
        otherPlayerTxtr.SetPixel(0,0, Textures.GetTxtr(Textures.Txtr.player2));

        Image outputImage = new Image(15,15);

        /*
        Menue menue = new Menue("-----options-----", ['w','s','a','d','x'],
                                ["move up", "move down", "move left", "move right", "exit"],
                                new Menue.OptionMethod[]{player1.MoveUp(maze), player1.MoveDown(maze), player1.MoveLeft(maze), player1.MoveRight(maze), Program.CloseAplication});
        */ //problem with methods that needs parameters...

        int turn = 0;
        int who = 0;

        while (true)
        {
            if(turn%2 == 0) who = 0;
            else who = 1;

            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine($"Turn {turn} for player {(who + 1)} in {3 - i} secons");
                Thread.Sleep(1000);
                Program.ClearConsole();
            }
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine($"Turn {turn} for player {(who + 1)}, press any key");
            ConsoleKeyInfo a = Console.ReadKey(true);
            Program.ClearConsole();



            
            
            
            for(int i = 0; i < 10; i++)
            {
                /*
                outputImage = Image.AddLayer(new Image(15,15),
                                     Camera.RoomFixed(maze.GetRoom(players[who].GetMazeRoomPos())),
                                     7 - players[who].GetRow(), 7 - players[who].GetCol());

                outputImage = Image.AddLayer(outputImage, playerTxtr, 7,7);

                if(TL.ArrEqual(players[0].GetMazeRoomPos(), players[1].GetMazeRoomPos()))
                {
                    Console.WriteLine("you are not alone");

                    if(who == 0)
                    {
                        outputImage = Image.AddLayer(outputImage, otherPlayerTxtr, 
                        7 - players[0].GetRow() + players[1].GetRow(),
                        7 - players[0].GetCol() + players[1].GetCol());
                        
                        Console.WriteLine("player 2 is with you :)");

                    }
                    else
                    {
                        
                        outputImage = Image.AddLayer(outputImage, otherPlayerTxtr, 
                        7 - players[1].GetRow() + players[0].GetRow(),
                        7 - players[1].GetCol() + players[0].GetCol());
                        
                        Console.WriteLine("player 1 is with you :)");

                    }
                    
                }

                outputImage.Print();
                */

                Camera.Room(maze.GetRoom(players[who].GetRoomPos()), players[who],
                            (who == 0? [players[1]] : [players[0]])).Print();

                Console.WriteLine(" ");
                Console.WriteLine("player: " + (who + 1));
                Console.WriteLine("turn:   " + turn);
           
                Console.WriteLine($"movements you have [{10 - i}]");


                char keyChar = Caption.GetKey_asChar();

                bool validKey = false;

                while(!validKey)
                {

                    if(keyChar == 'w')
                    {
                        validKey = true;
                        players[who].SetPosition(maze.Move(players[who], 0));
                    } 
                    else if(keyChar == 's')
                    {
                        validKey = true;
                        players[who].SetPosition(maze.Move(players[who], 1));
                    }
                    else if(keyChar == 'a')
                    {
                        validKey = true;
                        players[who].SetPosition(maze.Move(players[who], 2));
                    }
                    else if(keyChar == 'd')
                    {
                        validKey = true;
                        players[who].SetPosition(maze.Move(players[who], 3));
                    }
                    else if (keyChar == 'x')
                    {
                        validKey = true;
                        Program.CloseAplication();
                    }

                }

                Program.ClearConsole(); 
            }

            turn ++;
            

        }

    }

    public static void PaintingRooms()
    {
        int[,] metaRoom = new int[5,5];
        //metaRoom = 
        Room room = new();
    }
    


}