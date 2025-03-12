using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
using Resourses.Tools;

namespace Resourses.Logic;
public partial class Maze
{
    public bool IsWalkable(int[] roomPos, int[] cellPos)
    {
        return this.GetRoom(roomPos[0], roomPos[1]).GetCell(cellPos).isWalkable();
    }

    public bool IsWalkable(int[] position)
    {
        return IsWalkable([position[0],position[1]],[position[2],position[3]]);
    }

    /// <summary>
    /// Moves a MazePos instance in a certain direction
    /// </summary>
    /// <param name="mazePos"></param>
    /// <param name="theDir"></param>
    /// <returns></returns>
    public bool MoveObjec(MazePos mazePos, int theDir)
    {
        int[] nextPos = Move(mazePos, theDir);
        if(!TL.ArrEqual(mazePos.GetPosition(), nextPos))
        {
            mazePos.SetPosition(nextPos);
            return true;
        }
        return false;

    }

    public int[] Move(MazePos mazePos, int theDir)
    {
        return Move(mazePos.GetRoomPos(), mazePos.GetCellPos(), theDir);
    }

    public int[] Move(int[] position, int theDir)
    {
        return Move([position[0],position[1]],[position[2],position[3]], theDir);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="initialRoomPos"> initial position of the object to move in maze </param>
    /// <param name="initialCellPos"> initial position of the object to move in room</param>
    /// <param name="theDir"> direction to move (in terms of Tools.Directios.cs "wsad") </param>
    /// <returns>
    /// Returns as int[] the new position as resoult of the movement
    /// in the next foormat:
    /// - position 0 and 1 are the Room position
    /// - position 2 and 3 are the Cell position
    /// 
    /// [ℹ️] If the output positions are the same of the input, it means
    /// that no movement have been done due to the pr
    /// </returns>
    public int[] Move(int[] initialRoomPos, int[] initialCellPos, int theDir)
    {
        int[] output = [initialRoomPos[0], initialRoomPos[1], initialCellPos[0], initialCellPos[1]];

        Direction wsad = new();
        int[] dir = wsad.GetDir(theDir);
        int roomSize = GetRoom(initialRoomPos).GetSize();

        if(TL.PosStepInRange(initialCellPos, roomSize, roomSize, theDir))
        {
            if(GetRoom(initialRoomPos).GetCell(TL.PosStep(initialCellPos, theDir)).isWalkable())
            {
                output[2] += dir[0];
                output[3] += dir[1];
                return output;
            }

        }

        if(TL.PosStepInRange(initialRoomPos, GetSize()[0], GetSize()[1], theDir))
        {
            int[] newRoomPos = TL.PosStep(initialRoomPos, theDir);
            int[] newCellPos = TL.PosStepOutside(initialCellPos, [roomSize, roomSize], theDir);

            if(GetRoom(newRoomPos).GetCell(newCellPos).isWalkable())
            {
                output[0] = newRoomPos[0];
                output[1] = newRoomPos[1];
                output[2] = newCellPos[0];
                output[3] = newCellPos[1];
                
                return output;
            }
        }

        return output; //if the movement was not posible, it will return the initial position.
    }

}