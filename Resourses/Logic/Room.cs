using System;
using System.Runtime.InteropServices;
namespace Resourses.Logic;

public class Room
{
    private Cell[,] roomCells;

    public Room() : this(9) 
    {
        //create a simple 9x9 room
    }

    public Room(int size)
    {
        roomCells = new Cell[size, size];        
    }

    public static void Create(LogicRoom logicRoom)
    {
        if (logicRoom.IsLeftWall())
        {

        }
        if (logicRoom.IsRightWall())
        {

        }
        if(logicRoom.IsUpWall())
        {

        }
        if(logicRoom.IsDownWall())
        {

        }
        //create a method to walk trough a row, col, diagonal
        //lineal functiun...
        //
        //add this to Tools.cs
    }    

}
