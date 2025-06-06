using System;
using System.Diagnostics;
namespace Resourses.Logic;

public class MazePos
{
    int[] position;

    // Constructor to initialize position
    public MazePos(int[] initialPosition)
    {
        this.position = new int[]{initialPosition[0],initialPosition[1],initialPosition[2],initialPosition[3]};
    }

    //[i]-Get parameters
    public int[] GetPosition() => position; 
    public int[] GetRoomPos() => new int[] { position[0], position[1] };
    public int[] GetCellPos() => new int[] { position[2], position[3] };

    //[i]-Set parameters
    public void SetPosition(int[] thePos) => position = thePos;
    public void SetRoomPos(int[] theRoomPos)
    {
        position[0] = theRoomPos[0];
        position[1] = theRoomPos[1];
    }
    public void SetCellPos(int[] theCellPos)
    {
        position[2] = theCellPos[0];
        position[3] = theCellPos[1];
    }
}
