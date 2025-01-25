using System;
using System.Runtime.InteropServices;
namespace Resourses.Logic;

public partial class Room
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
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                roomCells[i, j] = new Cell();
            }
        }
        roomSize = size;        
    }
    public Room(int[,] intCells)
    {
        roomCells = new Cell[intCells.GetLength(0), intCells.GetLength(1)];
        for (int i = 0; i < intCells.GetLength(0); i++)
        {
            for (int j = 0; j < intCells.GetLength(1); j++)
            {
                if (intCells[i, j] == 1)
                {
                    roomCells[i, j].ChangeType(Cell.TypeOfCell.Wall);
                }            
            }
        }
    }

    //[i]-Get parameters

    public int GetSize() => roomSize;

    public Cell GetCell(int i, int j) => roomCells[i,j];

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
                roomCells[i, 0].ChangeType(Cell.TypeOfCell.Wall);
            }
            //esto se puede optimizar tambien
            //incluso multiplicando y sumando por el array de direccione
            //jejeje

        }
        if (logicRoom.IsRightWall())
        {
            for (int i = 0; i < roomCells.GetLength(0); i++)
            {
                roomCells[i, roomCells.GetLength(0)-1].ChangeType(Cell.TypeOfCell.Wall);
            }
        }
        if(logicRoom.IsUpWall())
        {
            for (int i = 0; i < roomCells.GetLength(0); i++)
            {
                roomCells[0, i].ChangeType(Cell.TypeOfCell.Wall);
            }
        }
        if(logicRoom.IsDownWall())
        {
            for (int i = 0; i < roomCells.GetLength(0); i++)
            {
                roomCells[roomCells.GetLength(0)-1, i].ChangeType(Cell.TypeOfCell.Wall);
            }
        }
        //create a method to walk trough a row, col, diagonal
        //lineal functiun...
        //
        //add this to Tools.cs
    }    

}
