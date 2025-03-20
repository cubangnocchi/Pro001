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
    public void DoorPlacing(int[] StartRoomPos, int dir, Door.TypeOfDoor typeOfDoor)
    {
        // + + + + + + + + + + + + + + + + + +
        //I need to create a Door giving it the 
        //position, the action that connects the cell and the door, and the type of door
        
        




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
}