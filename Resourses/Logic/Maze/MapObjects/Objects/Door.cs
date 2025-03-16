using System;
using System.Diagnostics;
using Resourses.Tools;
namespace Resourses.Logic;
public class Door
{
    TypeOfDoor typeOfDoor;
    MapObject[] doors;

    public enum TypeOfDoor
    {
        CanOpenAll,
        CanOpenInside,
        CantOpen,
        BrokenDoor,
        PlankedUp,

    }

    public Door(TypeOfDoor theTypeOfDoor, int[] StartRoomPos, int dir, int roomSize)
    {
        

        int[][] doorPositoions = TwoDoorPosCalculation(StartRoomPos, dir, roomSize);
        
        //Actions[] actions = [new Action(),];

        // + + + + + + + + + + + + + ++ + + + + + + + + 
        // + + + + + + Esto debe hacerlo maze poeque hace falta info
        // + + + + + + de él...
        // + + + + + + + + + + + + + + + + + + + + + + + 
        // + + + + + + Si no hay que pasar mínimo dos Rooms ....
        //  + + + + + + + + + + + + + 
        // + + + + +  + aaaaaaahhhhhhh!!!!!!!!
        
        //doors = [new MapObject(doorPositoions[0]),
        //         new MapObject(doorPositoions[1])];

        //+ + + + + + + + + 
        //+ + Recuerda que perfectamente lo puedes hacer con
        //+ + una dirección y pos de la Room y pan ya
        //+ + + + + + + + +
        //+ + 
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
