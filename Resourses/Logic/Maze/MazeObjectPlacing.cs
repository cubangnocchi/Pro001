using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
using Resourses.Tools;

namespace Resourses.Logic;
public partial class Maze
{
    // + + + + + + + + + + + + ++  ++ 
    // revisa Doors que ahí están las instrucciones
    // + + + + + + + + + + + ++  ++  +
    // aaaaaaaaaaaaaaaaaaaaahhhh

    #region Door
    public void DoorPlacing(int[] StartRoomPos, int dir, Door.TypeOfDoor typeOfDoor)
    {
        
        //position, the action that connects the cell and the door, and the type of door
        int[][] twoDoorPos = TwoDoorPosCalculation(StartRoomPos, dir, mazeRooms[0,0].GetSize());
        Cell[] cells = [mazeRooms[twoDoorPos[0][0],twoDoorPos[0][1]].GetCell(twoDoorPos[0][2], twoDoorPos[0][3]),
                        mazeRooms[twoDoorPos[1][0],twoDoorPos[1][1]].GetCell(twoDoorPos[1][2], twoDoorPos[1][3])];
        
        Door door = new Door(typeOfDoor, twoDoorPos[0], twoDoorPos[1], cells);
        mapObjects.Add(door.GetDoors()[0]);
        mapObjects.Add(door.GetDoors()[1]);

        cells[0].SetUnwalcable();
        cells[1].SetUnwalcable();
        
    }

    public static int[][] TwoDoorPosCalculation(int[] startRoomPos, int dir, int roomSize)
    { 
        Direction wsad = new();
        int[] step = wsad.GetDir(dir);
        
        int[] endRoomPos = [startRoomPos[0]+step[0], startRoomPos[1]+step[1]];
        
        int[] startDoor = InRoomDoorPos(step, roomSize);
        int[] endDoor = InRoomDoorPos(TL.VectorScalarMultiplication(step, -1), roomSize);

        int[] start = TL.ConcatenateArrays(startRoomPos, startDoor);
        int[] end = TL.ConcatenateArrays(endRoomPos, endDoor);

        return [start,end];
    }

    public static int[] InRoomDoorPos(int[] step, int roomSize)
    {
        int [] output = new int[2];

        output[0] = StepToDoorPos(step[0], roomSize);
        output[1] = StepToDoorPos(step[1], roomSize);

        return output;
    }

    public static int StepToDoorPos(int n, int roomSize)
    {
        if (n == 0) return roomSize/2;
        if (n == 1) return roomSize;
        return 0;
    }

    #endregion

}