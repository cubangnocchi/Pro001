using System;
using System.Runtime.InteropServices;
namespace Resourses.Logic;

public class Room
{
    //[i]-Room parameters
    private Cell[,] roomCells;

    int roomSize;

    //[i]-Room constructors

    public Room() : this(9) 
    {
        //create a simple 9x9 room
    }

    public Room(int size)
    {
        roomCells = new Cell[size, size];
        roomSize = size;        
    }

    //[i]-Get parameters

    public int GetSize() => roomSize;

    //[i]-Set parameters
    //
    //++Idea... change a wall by using the "wasd" directions
    //          array... 

    //[i]-Room building methods

    public void Create(LogicRoom logicRoom)
    {
        if (logicRoom.IsLeftWall())
        {
            for (int i = 0; i < roomCells.GetLength(0); i++)
            {
                roomCells[i, 0].ChangeType(Cell.TypeOfCell.presetWall);
            }
            //esto se puede optimizar tambien
            //incluso multiplicando y sumando por el array de direccione
            //jejeje

        }
        if (logicRoom.IsRightWall())
        {
            for (int i = 0; i < roomCells.GetLength(0); i++)
            {
                roomCells[i, roomCells.GetLength(0)-1].ChangeType(Cell.TypeOfCell.presetWall);
            }
        }
        if(logicRoom.IsUpWall())
        {
            for (int i = 0; i < roomCells.GetLength(0); i++)
            {
                roomCells[0, i].ChangeType(Cell.TypeOfCell.presetWall);
            }
        }
        if(logicRoom.IsDownWall())
        {
            for (int i = 0; i < roomCells.GetLength(0); i++)
            {
                roomCells[roomCells.GetLength(0)-1, i].ChangeType(Cell.TypeOfCell.presetWall);
            }
        }
        //create a method to walk trough a row, col, diagonal
        //lineal functiun...
        //
        //add this to Tools.cs
    }    

}
