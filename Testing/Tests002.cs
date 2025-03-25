using System;
using Spectre.Console;
using Resourses.Logic;
using Resourses.Visual;
using Resourses.Tools;
namespace Pro001;

public partial class MiniTest
{
    public static void DoorTest()
    {
        Maze maze = new(2, 5);
        int[] conDir = maze.GetRoom(0,0).ConnectedDirections();
        Console.WriteLine(conDir[0]);
        maze.DoorPlacing(new int[] { 0, 0 }, conDir[0], Door.TypeOfDoor.CanOpen);


        Direction wsad = new();
        Player player = new("Juan", [0,0,3,3]);
        
        while (true)
        {
            Camera.Room(maze.GetRoom(player.GetRoomPos()), player, maze.GetMapObjects()).Print();
            char keyChar = Caption.GetKey_asChar();

            if (keyChar == 'x')
            {
                Program.CloseAplication();
            }
            if (keyChar == 'w' || keyChar == 's' || keyChar == 'a' || keyChar == 'd')
            {
                maze.MoveObjec(player, wsad.GetInt(keyChar));
                Program.ClearConsole();
            }
            if (keyChar == 'e')
            {
                int[] pRoom = player.GetRoomPos();
                int[] pCell = player.GetCellPos();

                foreach (MapObject obj in maze.GetMapObjects())
                {
                    int[] objRoom = obj.GetRoomPos();
                    int[] objCell = obj.GetCellPos();

                    if(TL.ArrEqual(pRoom,objRoom))
                    {
                        int? objDir = TL.IsCloseDir(pCell,objCell);
                        if(objDir != null)
                        {
                            obj.GetAction(0).Execute();
                        }

                    }
                }
            }

            


        }
        
        
    }
}
