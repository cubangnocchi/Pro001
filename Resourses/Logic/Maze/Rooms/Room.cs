using System;
using System.Runtime.InteropServices;
using Resourses.Tools;
using Resourses.Visual;
namespace Resourses.Logic;

public partial class Room
{
    //[i]-Room parameters
    private Cell[,] roomCells;

    int roomSize;

    //[i]-Room constructors

    public Room() : this(7) 
    {
        //create a simple 7x7 room
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

        SetStartingLogicWalls([true, true, true, true]);

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

    // ! System.IndexOutOfRangeException: Index was outside the bounds of the array.
    public Cell GetCell(int i, int j) => roomCells[i,j]; 

    public Cell GetCell(int[] pos) => roomCells[pos[0], pos[1]];

    //[i]-Set parameters
    //
    //++Idea... change a wall by using the "wasd" directions
    //          array... 

    //[i]-Room building methods

    public void Build()
    {
        WallMaker();
    }

    private void WallMaker()
    {
        
        for(int i = 0; i < 4; i++)
        {
            if(walls[i])
            {
                for(int j = 0; j < roomCells.GetLength(0); j++)
                {
                    int[] sw = WallSwitch(i, j); 
                    roomCells[sw[0], sw[1]].ChangeType(Cell.TypeOfCell.Wall);
                }

                if(connected[i])
                {
                    int[] sw = WallSwitch(i, roomCells.GetLength(0)/2);
                    roomCells[sw[0], sw[1]].ChangeType(Cell.TypeOfCell.Floor);
                }

            }
            else
            {
                int[] sw = WallSwitch(i, 0);
                roomCells[sw[0], sw[1]].ChangeType(Cell.TypeOfCell.Wall);
            }
            
        }

        

        //[!]TASK create a method to walk trough a row, col, diagonal
        //lineal functiun...
        //
        //add this to Tools
    }

    /// <summary>
    /// Method used to get positions in a wall as a one dimentional arr
    /// </summary>
    /// <param name="i">direction of the wall</param>
    /// <param name="j">psition in the wall line</param>
    /// <returns>int[] position of the position in a wall</returns>
    public int[] WallSwitch(int i, int j)
    {
        int l =  roomCells.GetLength(0) - 1;

        return i % 2 == 0 ? (i == 0 ? [0, j] : [j, 0]) : //up and left
                            (i == 1 ? [l, j] : [j, l]) ; //down and right
    }    

}
