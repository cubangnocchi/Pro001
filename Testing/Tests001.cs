using System;
using Spectre.Console;
using Resourses.Logic;
using Resourses.Visual;
using Resourses.Tools;
namespace Pro001;

public partial class MiniTest
{
    public static void TextBoxTest()
    {
        string[] strings =
        ["a e i o u",
         "eo",
         "aaaaaaaaaaaaaaa",
         "bbbbbbbbbbbbbbb",
         "1 2 3 4 5"];

        TextBox textBox = new(strings, [10, 10]);

        textBox.PrintText();
        Console.WriteLine(" ");
        Console.ReadKey(true);


    }

    public static void MovementTest002()
    {
        Maze maze = new(4, 7);
        maze.Create(Maze.Type.Standard);

        Player player = new("Pedrito", [0, 0, 3, 3]);
        
        Direction wsad = new();

        

            
        
        

        while (true)
        {
            Camera.Room(maze.GetRoom(player.GetRoomPos()), player).Print();
            char keyChar = Caption.GetKey_asChar();

            if (keyChar == 'x')
            {
                Program.CloseAplication();
            }
            if(keyChar == 'w' || keyChar == 's' || keyChar == 'a' || keyChar == 'd')
            {
                maze.MoveObjec(player, wsad.GetInt(keyChar));
                Program.ClearConsole();
            }

            


        }
    }
}

