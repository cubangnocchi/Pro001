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
        

        //int[][] doorPositoions = TwoDoorPosCalculation(StartRoomPos, dir, roomSize);
        
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

    


}
